using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestAWA
{
    
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //TestSiteObject tso = new TestSiteObject();
            //tso.TestBind();
            TestStepConditionAction tsca = new TestStepConditionAction();
            tsca.PopulateSteps();
            tsca.ExecuteSteps();
        }
    }
}
