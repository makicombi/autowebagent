using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSet_actionRowTest and is intended
    ///to contain all AutoWebAgentDBDataSet_actionRowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSet_actionRowTest
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
        ///A test for value
        ///</summary>
        [TestMethod()]
        public void valueTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.value = expected;
            actual = target.value;
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
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.type = expected;
            actual = target.type;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for index
        ///</summary>
        [TestMethod()]
        public void indexTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.index = expected;
            actual = target.index;
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
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.id = expected;
            actual = target.id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetvalueNull
        ///</summary>
        [TestMethod()]
        public void SetvalueNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            target.SetvalueNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SettypeNull
        ///</summary>
        [TestMethod()]
        public void SettypeNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            target.SettypeNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetindexNull
        ///</summary>
        [TestMethod()]
        public void SetindexNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            target.SetindexNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IsvalueNull
        ///</summary>
        [TestMethod()]
        public void IsvalueNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsvalueNull();
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
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IstypeNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsindexNull
        ///</summary>
        [TestMethod()]
        public void IsindexNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsindexNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for actionRow Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_actionRowConstructorTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow target = new AutoWebAgentDBDataSet.actionRow(rb);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
