using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace awaApplication
{

    public interface IStep
    {
        void Execute();
    }
    public class Step:IStep
    {
        public ConditionCollection Conditions { get; set; }
        public ActionCollection Actions { get; set; }
        public Step()
        {
            Conditions = new ConditionCollection();
            Actions = new ActionCollection();
        }
        public void Execute()
        {
            foreach (ICondition cond in Conditions)
            {
                if (!cond.Eval()) return;
            }
            foreach (IAction act in Actions)
            {
                act.Execute();
            }
        }
        
    }
    public class StepCollection : System.Collections.CollectionBase
    {
        public IStep this[int index]
        {
            get { return (IStep)this.List[index]; }
            set { this.List[index] = value; }
        }
        public void Add(IStep step)
        {
            this.List.Add(step);
        }
    }
}
