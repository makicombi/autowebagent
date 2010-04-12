using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
using awaApplication;
namespace TestAWA
{
    public class TestSiteObject:SiteObject
    {
        private IE browser;
        private awaDAL.DAL dal;
        public TestSiteObject():base("http://www.google.com","pictures")
        {
            browser = new IE(this.Website);
            browser.WaitForComplete(20);
            dal = new awaDAL.DAL();
            dal.Init(@"Data Source=..\..\..\db\AutoWebAgentDB.sdf;Password=koby3274;Persist Security Info=True");
        }
        public void TestBind()
        {
            if (Bind(dal, browser))
            {
                Console.WriteLine("success");
                this.WatinElement.Flash(10);
            }
            else
            {
                Console.WriteLine("failure");
            }
            browser.Close();
        }
    }
}
