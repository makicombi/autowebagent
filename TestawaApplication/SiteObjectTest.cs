using awaApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using awaDAL;
using WatiN.Core;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for SiteObjectTest and is intended
    ///to contain all SiteObjectTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SiteObjectTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        private static WatiN.Core.IE ie;
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            ie = new IE("www.google.com");
        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Website
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaApplication.exe")]
        public void WebsiteTest()
        {
            PrivateObject param0 = new PrivateObject("www.google.com"); // TODO: Initialize to an appropriate value
            SiteObject_Accessor target = new SiteObject_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Website = expected;
            actual = target.Website;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WatinElement
        ///</summary>
        [TestMethod()]
        public void WatinElementTest()
        {
            string website = string.Empty; // TODO: Initialize to an appropriate value
            string elementName = string.Empty; // TODO: Initialize to an appropriate value
            SiteObject target = new SiteObject(website, elementName); // TODO: Initialize to an appropriate value
            Element expected = null; // TODO: Initialize to an appropriate value
            Element actual;
            target.WatinElement = expected;
            actual = target.WatinElement;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Value
        ///</summary>
        [TestMethod()]
        public void ValueTest()
        {
            string website = string.Empty; // TODO: Initialize to an appropriate value
            string elementName = string.Empty; // TODO: Initialize to an appropriate value
            SiteObject target = new SiteObject(website, elementName); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaApplication.exe")]
        public void NameTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            SiteObject_Accessor target = new SiteObject_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Bind
        ///</summary>
        [TestMethod()]
        public void BindTest()
        {
            string website = string.Empty; // TODO: Initialize to an appropriate value
            string elementName = string.Empty; // TODO: Initialize to an appropriate value
            SiteObject target = new SiteObject(website, elementName); // TODO: Initialize to an appropriate value
            DAL dal = null; // TODO: Initialize to an appropriate value
            IE ie = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Bind(dal, ie);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SiteObject Constructor
        ///</summary>
        [TestMethod()]
        public void SiteObjectConstructorTest()
        {
            string website = "www.google.com"; // TODO: Initialize to an appropriate value
            string elementName = "q"; // TODO: Initialize to an appropriate value
            SiteObject target = new SiteObject(website, elementName);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
