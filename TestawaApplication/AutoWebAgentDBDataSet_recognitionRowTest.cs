using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSet_recognitionRowTest and is intended
    ///to contain all AutoWebAgentDBDataSet_recognitionRowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSet_recognitionRowTest
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
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.value = expected;
            actual = target.value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for priority
        ///</summary>
        [TestMethod()]
        public void priorityTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.priority = expected;
            actual = target.priority;
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
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.id = expected;
            actual = target.id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for elementRow
        ///</summary>
        [TestMethod()]
        public void elementRowTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow actual;
            target.elementRow = expected;
            actual = target.elementRow;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for element_id
        ///</summary>
        [TestMethod()]
        public void element_idTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.element_id = expected;
            actual = target.element_id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for attribute
        ///</summary>
        [TestMethod()]
        public void attributeTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.attribute = expected;
            actual = target.attribute;
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
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            target.SetvalueNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetpriorityNull
        ///</summary>
        [TestMethod()]
        public void SetpriorityNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            target.SetpriorityNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IsvalueNull
        ///</summary>
        [TestMethod()]
        public void IsvalueNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsvalueNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IspriorityNull
        ///</summary>
        [TestMethod()]
        public void IspriorityNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IspriorityNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for recognitionRow Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_recognitionRowConstructorTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionRow target = new AutoWebAgentDBDataSet.recognitionRow(rb);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
