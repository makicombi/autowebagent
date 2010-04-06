using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace awaApplication
{
    public class Script
    {
        public StepCollection Steps { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public void Run()
        {
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
        }
    }
}
