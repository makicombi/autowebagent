using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
namespace awaApplication
{
    public class Script
    {
        public StepCollection Steps { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Reccurance { get; set; }
        public int Count { get; set; }
        public bool Activated { get; set; }
        public bool Forced { get; set; }
        public bool IsRunning { get; set; }
        private IE ie;
        
        public Script(IE ie,awaDAL.DAL dal, int script_id)
        {
            Steps = new StepCollection();
            this.ie = ie;
            if (script_id != -1)
            {
                var scriptRow = dal.DB.script.Single(row => row.id == script_id);
                this.Name = scriptRow.name;
                this.Author = dal.DB.users.Single(row => row.id == scriptRow.user_id).name;
                this.Activated = false;
                this.Forced = false;
                this.Count = 1;
                this.Reccurance = TimeSpan.Zero;
                this.LastModifiedTime = scriptRow.modified;
                var steps = dal.GetStepsByScriptID(script_id);
                foreach (var step in steps)
                {
                    IStep newStep = new Step(ie, dal, step.id);
                    Steps.Add(newStep);

                }
            }
        }
        public void Run()
        {
            IsRunning = true;
            Log.GetInstance().Write(string.Format("running script \"{0}\"", this.Name));
            int step_num=1;
            foreach (Step step in Steps)
            {
                Log.GetInstance().Write(string.Format("evaluating step [{0}]", step_num++));
                bool res = true;
                foreach (ICondition cond in step.Conditions)
                {
                    Log.GetInstance().Write("evaluating condition" );
                    if (cond.Eval() == false)
                    {
                        res = false;
                        break;
                    }
                }
                if (res)
                {
                    
                    foreach (IAction action in step.Actions)
                    { 
                        try
                        {
                            Log.GetInstance().Write("performing action");
                            action.Execute();
                        }
                        catch (Exception e)
                        {
                            Log.GetInstance().Write(e.Message);
                            Log.GetInstance().Write(e.StackTrace);
                        }
                       
                    }
                }
            }
            IsRunning = false;
            Forced = false;
        }

        internal void Kill()
        {
            ie.Close();
            ie.Dispose();
            ie = null;
        }
    }
}
