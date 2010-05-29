using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Collections.Generic;

namespace testDAL
{
    
    
    /// <summary>
    ///This is a test class for DALTest and is intended
    ///to contain all DALTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DALTest
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
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
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
        ///A test for IsInitialized
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void IsInitializedTest()
        {
            DAL_Accessor target = new DAL_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.IsInitialized = expected;
            actual = target.IsInitialized;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DB
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void DBTest()
        {
            DAL_Accessor target = new DAL_Accessor(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet actual;
            target.DB = expected;
            actual = target.DB;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StringToElementType
        ///</summary>
        [TestMethod()]
        public void StringToElementTypeTest()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            DAL.ElementType expected = new DAL.ElementType(); // TODO: Initialize to an appropriate value
            DAL.ElementType actual;
            actual = DAL.StringToElementType(s);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetElement
        ///</summary>
        [TestMethod()]
        public void SetElementTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow WebsiteRow = null; // TODO: Initialize to an appropriate value
            string elementName = string.Empty; // TODO: Initialize to an appropriate value
            string elementType = string.Empty; // TODO: Initialize to an appropriate value
            List<DAL.RecognitionProperty> elementProperties = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.SetElement(WebsiteRow, elementName, elementType, elementProperties);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveChanges
        ///</summary>
        [TestMethod()]
        public void SaveChangesTest1()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            string[] tableNames = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.SaveChanges(tableNames);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SaveChanges
        ///</summary>
        [TestMethod()]
        public void SaveChangesTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            target.SaveChanges();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Init
        ///</summary>
        [TestMethod()]
        public void InitTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            string connection = string.Empty; // TODO: Initialize to an appropriate value
            target.Init(connection);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetWebSiteUrlByName
        ///</summary>
        [TestMethod()]
        public void GetWebSiteUrlByNameTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            string wName = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetWebSiteUrlByName(wName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetWebsiteRow
        ///</summary>
        [TestMethod()]
        public void GetWebsiteRowTest1()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            string url = string.Empty; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow actual;
            actual = target.GetWebsiteRow(url);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetWebsiteRow
        ///</summary>
        [TestMethod()]
        public void GetWebsiteRowTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            bool found = false; // TODO: Initialize to an appropriate value
            bool foundExpected = false; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow actual;
            actual = target.GetWebsiteRow(name, out found);
            Assert.AreEqual(foundExpected, found);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetWebsiteIDByName
        ///</summary>
        [TestMethod()]
        public void GetWebsiteIDByNameTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetWebsiteIDByName(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetWebsiteID
        ///</summary>
        [TestMethod()]
        public void GetWebsiteIDTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            string url = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetWebsiteID(url);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetElementRecogitionProperties
        ///</summary>
        [TestMethod()]
        public void GetElementRecogitionPropertiesTest1()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            int wid = 0; // TODO: Initialize to an appropriate value
            int eid = 0; // TODO: Initialize to an appropriate value
            IEnumerable<DAL.RecognitionProperty> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<DAL.RecognitionProperty> actual;
            actual = target.GetElementRecogitionProperties(wid, eid);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetElementRecogitionProperties
        ///</summary>
        [TestMethod()]
        public void GetElementRecogitionPropertiesTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            string wName = string.Empty; // TODO: Initialize to an appropriate value
            string eName = string.Empty; // TODO: Initialize to an appropriate value
            IEnumerable<DAL.RecognitionProperty> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<DAL.RecognitionProperty> actual;
            actual = target.GetElementRecogitionProperties(wName, eName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateElementRecognitionView
        ///</summary>
        [TestMethod()]
        public void CreateElementRecognitionViewTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            int WebsiteID = 0; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.CreateElementRecognitionView(WebsiteID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateDB
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void CreateDBTest()
        {
            DAL_Accessor target = new DAL_Accessor(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            target.CreateDB(name);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ClearWebsiteData
        ///</summary>
        [TestMethod()]
        public void ClearWebsiteDataTest()
        {
            DAL target = new DAL(); // TODO: Initialize to an appropriate value
            int wid = 0; // TODO: Initialize to an appropriate value
            target.ClearWebsiteData(wid);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DAL Constructor
        ///</summary>
        [TestMethod()]
        public void DALConstructorTest()
        {
            DAL target = new DAL();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
