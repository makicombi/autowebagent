using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
namespace awaApplication
{

    public interface IAction
    {
        void Execute();
    }
    abstract public class ActionBase : IAction
    {
        abstract public void Execute();
        public int Repetitions { get; set; }
        public awaDAL.DAL DAL { get; private set; }
        public WatiN.Core.IE IE { get; private set; }
        public SiteObject Target { get; set; }
        public ActionBase(awaDAL.DAL dal, WatiN.Core.IE ie, SiteObject target)
        {
            this.DAL = dal;
            this.IE = ie;
            Repetitions = 1;
            this.Target = target;
        }
    }
    public class ActionCollection : System.Collections.CollectionBase
    {
        public IAction this[int index]
        {
            get { return (IAction)this.List[index]; }
            set { this.List[index] = value; }
        }
        public void Add(IAction action)
        {
            this.List.Add(action);
        }
    }
    public class ClickAction: ActionBase
    {
        public ClickAction(awaDAL.DAL dal, WatiN.Core.IE ie, SiteObject target)
            : base(dal, ie, target)
        {
 
        }
        public override void Execute()
        {
            if (Target.Bind(DAL, IE))
            {
                Target.WatinElement.Click();
            }
            else
            {
                //write error log
            }

        }
    }


    public class CheckAction : ActionBase
    {
        public CheckAction(awaDAL.DAL dal, WatiN.Core.IE ie, SiteObject target)
            : base(dal, ie, target)
        {

        }
        public override void Execute()
        {
            if (Target.Bind(DAL, IE))
            {
                if (Target.Value!="checked")
                {
                    Target.WatinElement.Click();
                }
            }
            else
            {
                //write error log
            }

        }
    }

    public class UnCheckAction : ActionBase
    {
        public UnCheckAction(awaDAL.DAL dal, WatiN.Core.IE ie, SiteObject target)
            : base(dal, ie, target)
        {

        }
        public override void Execute()
        {
            if (Target.Bind(DAL, IE))
            {
                if (Target.Value == "checked")
                {
                    Target.WatinElement.Click();
                }
            }
            else
            {
                //write error log
            }

        }
    }


    public class SelectAction : ActionBase
    {
        string item;
        public SelectAction(string item, awaDAL.DAL dal, WatiN.Core.IE ie, SiteObject target)
            : base(dal, ie, target)
        {
            this.item = item;
        }
        public override void Execute()
        {
            if (Target.Bind(DAL, IE))
            {
                SelectList sl = new SelectList(Target.WatinElement.DomContainer, Target.WatinElement.NativeElement);
                sl.Select(new System.Text.RegularExpressions.Regex(".*"+item+".*",System.Text.RegularExpressions.RegexOptions.IgnoreCase));

            }
            else
            {
                //write error log
            }

        }
    }

    public class NotifyAction : ActionBase
    {
        public enum NotifyMethod
        {
            EMAIL=1,POPUP=2,LOG=4
        }
        NotifyMethod notifyMethod;
        public NotifyAction(NotifyMethod method, awaDAL.DAL dal, WatiN.Core.IE ie, SiteObject target)
            : base(dal, ie, target)
        {
            this.notifyMethod = method;
        }
        public override void Execute()
        {
            switch (notifyMethod)
            {
                case NotifyMethod.EMAIL:
                    break;
                case NotifyMethod.POPUP:
                    break;
                case NotifyMethod.LOG:
                    break;
                default:
                    break;
            }
        }
    }
    /// <summary>
    /// This Class Represent a typing in a text input field action
    /// </summary>
    public class TypeAction : ActionBase
    {
        string text;
        /// <summary>
        /// This Class Represent a typing in a text input field action
        /// </summary>
        /// <param name="text">the text to fill in the field</param>
        /// <param name="dal">the DAL class instance</param>
        /// <param name="ie">the WatiN browser object</param>
        /// <param name="target">the Target Object upon which to act</param>
        public TypeAction(string text, awaDAL.DAL dal, WatiN.Core.IE ie, SiteObject target)
            : base(dal, ie, target)
        {
            this.text = text;
        }
        public override void Execute()
        {
            if (Target.Bind(DAL, IE))
            {
                //TextField sl = new TextField(Target.WatinElement.DomContainer, Target.WatinElement.NativeElement);
                TextField sl =IE.TextField(Find.ByElement(e => e.OuterHtml == Target.WatinElement.OuterHtml));
                //TextField sl = Target.WatinElement.GetAdapter<TextField>();
                sl.TypeText(text);
                //Target.WatinElement.SetAttributeValue("value",text);
                

            }
            else
            {
                //write error log
                Log.GetInstance().Write("couldn't bind to " + Target.Website + Target.Name);
            }

        }
        public void Execute(bool clear)
        {
            if (Target.Bind(DAL, IE))
            {
                TextField sl = new TextField(Target.WatinElement.DomContainer, Target.WatinElement.NativeElement);
                if (clear)
                {
                    sl.Clear();
                }
                sl.TypeText(text);

            }
            else
            {
                //write error log
            }

        }
    }

}
