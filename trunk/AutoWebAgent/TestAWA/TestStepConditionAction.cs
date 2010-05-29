using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
using awaApplication;
namespace TestAWA
{
    public class TestStepConditionAction 
    {
        private IE browser;
        private awaDAL.DAL dal;
        private SiteObject main,aux,button;
        private StepCollection steps;
        private ConditionCollection conds;
        private ActionCollection actions;
        private Script script;
        public TestStepConditionAction()
        {
            //browser = new IE("http://www.google.com");
            browser = new IE(@"http://localhost/testPage.htm");
            //file:///C:\Documents and Settings\User-1\My Documents\לימודים\AutoWebAgentProject2009\AutoWebAgent\trunk\AutoWebAgent\TestAWA\testPage.htm
            browser.WaitForComplete(20);
            dal = new awaDAL.DAL();
            dal.Init(@"Data Source=..\..\..\db\AutoWebAgentDB.sdf;Password=koby3274;Persist Security Info=True");
            main = new SiteObject("testpage", "text1");
            aux = new SiteObject("testpage", "area1");
            button = new SiteObject("testpage", "b1");
            steps = new StepCollection();
            actions = new ActionCollection();
            conds = new ConditionCollection();
        }
        public void PopulateSteps()
        {
            Step s = new Step(browser,dal,-1);
            
            ValueCondition vc = new ValueCondition("this is a text area", dal, browser);
            vc.ConditionElement = aux;
            TypeAction ta = new TypeAction("I found a little 'Chrome'", dal, browser, main);
            ClickAction ca = new ClickAction(dal, browser, button);
            s.Conditions.Add(vc);
            s.Actions.Add(ta);
            s.Actions.Add(ca);
            steps.Add(s);
            steps.Add(s);
            steps.Add(s);
            steps.Add(s);

        }
        public void ExecuteSteps()
        {
            foreach (IStep step in steps)
            {
                step.Execute();
            }
        }
        public void CreateScript()
        {
            script = new Script(browser,dal,-1);
            script.Name = "test";
            script.Author = "koby hershkovitz";
            script.LastModifiedTime = DateTime.Now;
            script.Steps = steps;
        }
        public void RunScript()
        {
            script.Run();
        }
        public void Cleanup()
        {
            browser.Close();
        }
    }
}
