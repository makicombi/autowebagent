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
            this.ie = ie;
            if (script_id != -1)
            {
                var scriptRow = dal.DB.script.Single(row => row.id == script_id);
                this.Name = scriptRow.name;
                this.Author = dal.DB.users.Single(row => row.id == scriptRow.user_id).name;
                this.Activated = false;
                this.Forced = false;
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
            foreach (Step step in Steps)
            {
                bool res = true;
                foreach (ICondition cond in step.Conditions)
                {
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
                            action.Execute();
                        }
                        catch (Exception e)
                        {
                            System.Windows.Forms.MessageBox.Show(e.Message);
                            throw e;
                        }
                       
                    }
                }
            }
            IsRunning = false;
        }
    }
}
