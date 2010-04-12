using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSet_elementRowTest and is intended
    ///to contain all AutoWebAgentDBDataSet_elementRowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSet_elementRowTest
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
        ///A test for websiteRow
        ///</summary>
        [TestMethod()]
        public void websiteRowTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow actual;
            target.websiteRow = expected;
            actual = target.websiteRow;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for website_id
        ///</summary>
        [TestMethod()]
        public void website_idTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.website_id = expected;
            actual = target.website_id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for type
        ///</summary>
        [TestMethod()]
        public void typeTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.type = expected;
            actual = target.type;
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
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.id = expected;
            actual = target.id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Setwebsite_idNull
        ///</summary>
        [TestMethod()]
        public void Setwebsite_idNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
            target.Setwebsite_idNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SettypeNull
        ///</summary>
        [TestMethod()]
        public void SettypeNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
            target.SettypeNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Iswebsite_idNull
        ///</summary>
        [TestMethod()]
        public void Iswebsite_idNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Iswebsite_idNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IstypeNull
        ///</summary>
        [TestMethod()]
        public void IstypeNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IstypeNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetrecognitionRows
        ///</summary>
        [TestMethod()]
        public void GetrecognitionRowsTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow[] expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow[] actual;
            actual = target.GetrecognitionRows();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for elementRow Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_elementRowConstructorTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow target = new AutoWebAgentDBDataSet.elementRow(rb);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
