using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace awaApplication
{
    public interface ICondition
    {
        bool Eval();
    }
    
    public abstract class ConditionBase : ICondition
    {

        public enum ConditionType
        {
            TRUE,
            FALSE,
            EQUAL,
            SELECTED,
            VALUE,
            NOT_EQUAL,
            NOT_SELECETED,
            NOT_VALUE,
            CONTAINS
        }
        public SiteObject ConditionElement { get; set; }
        public awaDAL.DAL DAL { get; private set; }
        public WatiN.Core.IE IE { get; private set; }
        public ConditionBase(awaDAL.DAL dal, WatiN.Core.IE ie)
        {
            this.DAL = dal;
            this.IE = ie;
        }
        virtual public bool Eval()
        {
            if ( ConditionElement.IsBound==false)
            {
                if (!ConditionElement.Bind(DAL,IE))
                throw new SiteObjectNotBoundException(ConditionElement);
            }
            return true;
        }
        public static Dictionary<string, ConditionType> ConditionTypeEnum = 
            new Dictionary<string, ConditionType>() {{"Contains",ConditionType.CONTAINS},
                {"Contains",ConditionType.EQUAL},
                {"False",ConditionType.FALSE},
                {"NotEqual",ConditionType.NOT_EQUAL},
                {"NotSelected",ConditionType.NOT_SELECETED},
                {"NotValue",ConditionType.NOT_VALUE},
                {"Selected",ConditionType.SELECTED},
                {"True",ConditionType.TRUE},
                {"Value",ConditionType.VALUE}
            };
    }
    public class ConditionCollection : System.Collections.CollectionBase
    {
        public ICondition this[int index]
        {
            get { return (ICondition)this.List[index]; }
            set { this.List[index] = value; }
        }
        public void Add(ICondition condition)
        {
            this.List.Add(condition);
        }
    }

    public class ValueCondition : ConditionBase
    {
        private string value;
        public ValueCondition(string value,awaDAL.DAL dal,WatiN.Core.IE ie):base(dal,ie)
        {
            this.value = value;
        }
        public override bool Eval()
        {
            if (ConditionElement.IsBound == false)
            {
                    if (!ConditionElement.Bind(this.DAL, this.IE))
                        return false;
            }
            return (ConditionElement.Value == value);
        }
    }

    public class ContainsCondition : ConditionBase
    {
        private string value;
        public ContainsCondition(string value, awaDAL.DAL dal, WatiN.Core.IE ie)
            : base(dal, ie)
        {
            this.value = value;
        }
        public override bool Eval()
        {
            if (ConditionElement.IsBound == false)
            {
                if (!ConditionElement.Bind(this.DAL, this.IE))
                    return false;
            }
            return (ConditionElement.Value.Contains(value));
        }
    }

    public class NotContainsCondition : ConditionBase
    {
        private string value;
        public NotContainsCondition(string value, awaDAL.DAL dal, WatiN.Core.IE ie)
            : base(dal, ie)
        {
            this.value = value;
        }
        public override bool Eval()
        {
            if (ConditionElement.IsBound == false)
            {
                if (!ConditionElement.Bind(this.DAL, this.IE))
                    return false;
            }
            return !(ConditionElement.Value.Contains(value));
        }
    }

    public class NotValueCondition : ConditionBase
    {
        private string value;
        public NotValueCondition(string value, awaDAL.DAL dal, WatiN.Core.IE ie)
            : base(dal, ie)
        {
            this.value = value;
        }
        public override bool Eval()
        {
            if (ConditionElement.IsBound == false)
            {
                if (!ConditionElement.Bind(this.DAL, this.IE))
                    return false;
            }
            return (ConditionElement.Value != value);
        }
    }

    public class EqualityCondition : ConditionBase
    {
        public enum ComparisonAttribute
        {
            VALUE, CLASS, NAME, INNERHTML, INNERTEXT
        }
        private ComparisonAttribute ca = ComparisonAttribute.VALUE;
        public SiteObject AuxElement { get; set; }

        public EqualityCondition(ComparisonAttribute attr, awaDAL.DAL dal, WatiN.Core.IE ie)
            : base(dal, ie)
        {
            this.ca = attr;
        }
        public override bool Eval()
        {
            base.Eval();
            if ((AuxElement.IsBound == false))
            {
                if (!AuxElement.Bind(DAL,IE))
                    throw new SiteObjectNotBoundException(AuxElement);
            }
            switch (ca)
            {
                case ComparisonAttribute.VALUE:
                    return (ConditionElement.Value == AuxElement.Value);
                    
                case ComparisonAttribute.CLASS:
                    return (ConditionElement.WatinElement.ClassName == AuxElement.WatinElement.ClassName);
                   
                case ComparisonAttribute.NAME:
                    return (ConditionElement.Name == AuxElement.Name);
                   
                case ComparisonAttribute.INNERHTML:
                    return (ConditionElement.WatinElement.InnerHtml == AuxElement.WatinElement.InnerHtml);
                    
                case ComparisonAttribute.INNERTEXT:
                    return (ConditionElement.WatinElement.Text == AuxElement.WatinElement.Text);
                    
                default:
                    break;
            }
            return false;
           
        }
    }

    public class NotEqualityCondition : ConditionBase
    {
        public enum ComparisonAttribute
        {
            VALUE, CLASS, NAME, INNERHTML, INNERTEXT
        }
        private ComparisonAttribute ca = ComparisonAttribute.VALUE;
        public SiteObject AuxElement { get; set; }

        public NotEqualityCondition(ComparisonAttribute attr, awaDAL.DAL dal, WatiN.Core.IE ie)
            : base(dal, ie)
        {
            this.ca = attr;
        }
        public override bool Eval()
        {
            base.Eval();
            if ((AuxElement.IsBound == false))
            {
                if (!AuxElement.Bind(DAL, IE))
                    throw new SiteObjectNotBoundException(AuxElement);
            }
            switch (ca)
            {
                case ComparisonAttribute.VALUE:
                    return (ConditionElement.Value != AuxElement.Value);

                case ComparisonAttribute.CLASS:
                    return (ConditionElement.WatinElement.ClassName == AuxElement.WatinElement.ClassName);

                case ComparisonAttribute.NAME:
                    return (ConditionElement.Name != AuxElement.Name);

                case ComparisonAttribute.INNERHTML:
                    return (ConditionElement.WatinElement.InnerHtml != AuxElement.WatinElement.InnerHtml);

                case ComparisonAttribute.INNERTEXT:
                    return (ConditionElement.WatinElement.Text != AuxElement.WatinElement.Text);

                default:
                    break;
            }
            return false;

        }
    }

    public class CheckedCondition : ConditionBase
    {
        public CheckedCondition(awaDAL.DAL dal, WatiN.Core.IE ie)
            : base(dal, ie)
        {
 
        }
        public override bool  Eval()
        {
 	         if ((ConditionElement.IsBound == false) )
            {
                throw new SiteObjectNotBoundException(ConditionElement);
            }
             String type=ConditionElement.WatinElement.GetAttributeValue("type");
             if (type == "checkbox")
             {
                 return ConditionElement.WatinElement.GetAdapter<WatiN.Core.CheckBox>().Checked;
             }
             if (type == "radio")
             {
                 return ConditionElement.WatinElement.GetAdapter<WatiN.Core.RadioButton>().Checked;
             }
             return false;
        }
       
    }
    public class SelectedCondition : ConditionBase
    {
        private string selectedItem;
        public SelectedCondition(string si, awaDAL.DAL dal, WatiN.Core.IE ie)
            : base(dal, ie)
        {
            selectedItem = si;
        }
        public override bool Eval()
        {
            if ((ConditionElement.IsBound == false))
            {
                throw new SiteObjectNotBoundException(ConditionElement);
            }
            return (ConditionElement.WatinElement.GetAdapter<WatiN.Core.SelectList>().SelectedItem==selectedItem);
        }
    }
    public class NotSelectedCondition : ConditionBase
    {
        private string selectedItem;
        public NotSelectedCondition(string si, awaDAL.DAL dal, WatiN.Core.IE ie)
            : base(dal, ie)
        {
            selectedItem = si;
        }
        public override bool Eval()
        {
            if ((ConditionElement.IsBound == false))
            {
                throw new SiteObjectNotBoundException(ConditionElement);
            }
            return (ConditionElement.WatinElement.GetAdapter<WatiN.Core.SelectList>().SelectedItem != selectedItem);
        }
    }

    public class TrueCondition : ConditionBase
    {
        public TrueCondition() : base(null, null) { }
         public override bool Eval()
         {
             return true;
         }
    }
    public class FalseCondition : ConditionBase
    {
        public FalseCondition() : base(null, null) { }
        public override bool Eval()
        {
            return false;
        }
    }

    
}
