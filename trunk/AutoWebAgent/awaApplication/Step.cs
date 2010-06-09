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
        public Step(WatiN.Core.IE ie, awaDAL.DAL dal, int step_id)
        {
            
            if (step_id != -1)
            {
                Conditions = new ConditionCollection();
                ICondition newCondition = null;
                var conditions = dal.DB.condition.Where(row => row.step_id == step_id);
                foreach (var condition in conditions)
                {
                    if (condition.op.ToLower() == "none")
                    {
                        continue;
                    }
                    
                    var condElm = dal.DB.element.SingleOrDefault(row => row.id == condition.lhs_element_id);
                    var auxElm = dal.DB.element.SingleOrDefault(row => row.id == condition.rhs_element_id);
                    switch (ConditionBase.ConditionTypeEnum[condition.op])
                    {
                        case ConditionBase.ConditionType.CONTAINS:
                            newCondition = new ContainsCondition(condition.lhs_element_attr, dal, ie);
                            break;
                        case ConditionBase.ConditionType.EQUAL:
                            EqualityCondition.ComparisonAttribute cmpAttr = EqualityCondition.ComparisonAttribute.INNERTEXT;
                            if (condition.lhs_element_attr.ToLower() == "value")
                            {
                                cmpAttr = EqualityCondition.ComparisonAttribute.VALUE;
                            }
                            else
                                if (condition.lhs_element_attr.ToLower() == "class")
                                {
                                    cmpAttr = EqualityCondition.ComparisonAttribute.CLASS;
                                }
                                else
                                    if (condition.lhs_element_attr.ToLower() == "innerhtml")
                                    {
                                        cmpAttr = EqualityCondition.ComparisonAttribute.INNERHTML;
                                    }
                                    else
                                        if (condition.lhs_element_attr.ToLower() == "name")
                                        {
                                            cmpAttr = EqualityCondition.ComparisonAttribute.NAME;
                                        }
                            EqualityCondition eqCond = new EqualityCondition(cmpAttr, dal, ie);

                            eqCond.ConditionElement = new SiteObject(condElm.websiteRow.name, condElm.name);
                            newCondition = eqCond;
                            break;
                        case ConditionBase.ConditionType.FALSE:
                            newCondition = new FalseCondition();
                            break;
                        case ConditionBase.ConditionType.NOT_EQUAL:
                            NotEqualityCondition.ComparisonAttribute ncmpAttr = NotEqualityCondition.ComparisonAttribute.INNERTEXT;
                            if (condition.lhs_element_attr.ToLower() == "value")
                            {
                                cmpAttr = EqualityCondition.ComparisonAttribute.VALUE;
                            }
                            else
                                if (condition.lhs_element_attr.ToLower() == "class")
                                {
                                    cmpAttr = EqualityCondition.ComparisonAttribute.CLASS;
                                }
                                else
                                    if (condition.lhs_element_attr.ToLower() == "innerhtml")
                                    {
                                        cmpAttr = EqualityCondition.ComparisonAttribute.INNERHTML;
                                    }
                                    else
                                        if (condition.lhs_element_attr.ToLower() == "name")
                                        {
                                            cmpAttr = EqualityCondition.ComparisonAttribute.NAME;
                                        }
                            var neqCond = new NotEqualityCondition(ncmpAttr, dal, ie);

                            neqCond.ConditionElement = new SiteObject(condElm.websiteRow.name, condElm.name);
                            newCondition = neqCond;
                            break;
                        case ConditionBase.ConditionType.NOT_SELECETED:
                            newCondition = new NotSelectedCondition(condition.lhs_element_attr, dal, ie);
                            break;
                        case ConditionBase.ConditionType.NOT_VALUE:
                            newCondition = new NotValueCondition(condition.lhs_element_attr, dal, ie);
                            break;
                        case ConditionBase.ConditionType.SELECTED:
                            newCondition = new SelectedCondition(condition.lhs_element_attr, dal, ie);
                            break;
                        case ConditionBase.ConditionType.TRUE:
                            newCondition = new TrueCondition();
                            break;
                        case ConditionBase.ConditionType.VALUE:
                            newCondition = new ValueCondition(condition.lhs_element_attr, dal, ie);
                            break;
                    }
                }
                    
                    Conditions.Add(newCondition);
                
                Actions = new ActionCollection();
                var actions = dal.DB.action.Where(row => row.step_id == step_id);
                foreach (var action in actions)
                {
                    if (action.type.ToLower() == "none")
                    {
                        continue;
                    }
                    var targetElm = dal.DB.element.Single(row => row.id == action.target_id);
                    SiteObject targetSiteObject = new SiteObject(targetElm.websiteRow.name, targetElm.name);
                    IAction newAction = null;
                    if (action.type.ToLower() == "click")
                    {
                        newAction = new ClickAction(dal, ie, targetSiteObject);
                    }
                    else
                    if (action.type.ToLower() == "check")
                    {
                        newAction = new CheckAction(dal, ie, targetSiteObject);
                    }
                    else
                    if (action.type.ToLower() == "uncheck")
                    {
                        newAction = new UnCheckAction(dal, ie, targetSiteObject);
                    }
                    else
                    if (action.type.ToLower() == "type text")
                    {
                        newAction = new TypeAction(action.value, dal, ie, targetSiteObject);
                    }
                    else
                    if (action.type.ToLower() == "select")
                    {
                        newAction = new SelectAction(action.value, dal, ie, targetSiteObject);
                    }
                    if (action.type.ToLower() == "notify")
                    {
                        if (action.notifyMethod.ToLower() == "none")
                        {
                            continue;
                        }
                        NotifyAction.NotifyMethod method = NotifyAction.NotifyMethod.LOG;
                        if (action.notifyMethod.ToLower() == "email")
                            method = NotifyAction.NotifyMethod.EMAIL;
                        else
                        if (action.notifyMethod.ToLower() == "popup")
                            method = NotifyAction.NotifyMethod.POPUP;
                        newAction = new NotifyAction(method, dal, ie, targetSiteObject);
                    }
                    Actions.Add(newAction);
                }
            }
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
