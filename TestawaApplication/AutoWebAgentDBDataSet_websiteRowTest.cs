using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSet_websiteRowTest and is intended
    ///to contain all AutoWebAgentDBDataSet_websiteRowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSet_websiteRowTest
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
        ///A test for url
        ///</summary>
        [TestMethod()]
        public void urlTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow target = new AutoWebAgentDBDataSet.websiteRow(rb); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.url = expected;
            actual = target.url;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for name
        ///</summary>
        [TestMethod()]
        public void nameTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow target = new AutoWebAgentDBDataSet.websiteRow(rb); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.name = expected;
            actual = target.name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for id
        ///</summary>
        [TestMethod()]
        public void idTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow target = new AutoWebAgentDBDataSet.websiteRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.id = expected;
            actual = target.id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SeturlNull
        ///</summary>
        [TestMethod()]
        public void SeturlNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow target = new AutoWebAgentDBDataSet.websiteRow(rb); // TODO: Initialize to an appropriate value
            target.SeturlNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetnameNull
        ///</summary>
        [TestMethod()]
        public void SetnameNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow target = new AutoWebAgentDBDataSet.websiteRow(rb); // TODO: Initialize to an appropriate value
            target.SetnameNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IsurlNull
        ///</summary>
        [TestMethod()]
        public void IsurlNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow target = new AutoWebAgentDBDataSet.websiteRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsurlNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsnameNull
        ///</summary>
        [TestMethod()]
        public void IsnameNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow target = new AutoWebAgentDBDataSet.websiteRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsnameNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetelementRows
        ///</summary>
        [TestMethod()]
        public void GetelementRowsTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow target = new AutoWebAgentDBDataSet.websiteRow(rb); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow[] expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow[] actual;
            actual = target.GetelementRows();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for websiteRow Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_websiteRowConstructorTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow target = new AutoWebAgentDBDataSet.websiteRow(rb);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
