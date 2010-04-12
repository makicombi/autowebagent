using awaDAL.AutoWebAgentDBDataSetTableAdapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for QueriesTableAdapterTest and is intended
    ///to contain all QueriesTableAdapterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class QueriesTableAdapterTest
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
        ///A test for CommandCollection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void CommandCollectionTest()
        {
            QueriesTableAdapter_Accessor target = new QueriesTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            IDbCommand[] actual;
            actual = target.CommandCollection;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InitCommandCollection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void InitCommandCollectionTest()
        {
            QueriesTableAdapter_Accessor target = new QueriesTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            target.InitCommandCollection();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DeleteWebsiteByName
        ///</summary>
        [TestMethod()]
        public void DeleteWebsiteByNameTest()
        {
            QueriesTableAdapter target = new QueriesTableAdapter(); // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteWebsiteByName(name);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteWebsiteByID
        ///</summary>
        [TestMethod()]
        public void DeleteWebsiteByIDTest()
        {
            QueriesTableAdapter target = new QueriesTableAdapter(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteWebsiteByID(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteRecognitionByElementId
        ///</summary>
        [TestMethod()]
        public void DeleteRecognitionByElementIdTest()
        {
            QueriesTableAdapter target = new QueriesTableAdapter(); // TODO: Initialize to an appropriate value
            int element_id = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteRecognitionByElementId(element_id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteElementsByWebsiteId
        ///</summary>
        [TestMethod()]
        public void DeleteElementsByWebsiteIdTest()
        {
            QueriesTableAdapter target = new QueriesTableAdapter(); // TODO: Initialize to an appropriate value
            Nullable<int> website_id = new Nullable<int>(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteElementsByWebsiteId(website_id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteAllRecognition
        ///</summary>
        [TestMethod()]
        public void DeleteAllRecognitionTest()
        {
            QueriesTableAdapter target = new QueriesTableAdapter(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteAllRecognition();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteAllElements
        ///</summary>
        [TestMethod()]
        public void DeleteAllElementsTest()
        {
            QueriesTableAdapter target = new QueriesTableAdapter(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DeleteAllElements();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for QueriesTableAdapter Constructor
        ///</summary>
        [TestMethod()]
        public void QueriesTableAdapterConstructorTest()
        {
            QueriesTableAdapter target = new QueriesTableAdapter();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
