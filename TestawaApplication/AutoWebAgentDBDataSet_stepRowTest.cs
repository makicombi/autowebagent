using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSet_stepRowTest and is intended
    ///to contain all AutoWebAgentDBDataSet_stepRowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSet_stepRowTest
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
        ///A test for step_number
        ///</summary>
        [TestMethod()]
        public void step_numberTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.step_number = expected;
            actual = target.step_number;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for script_id
        ///</summary>
        [TestMethod()]
        public void script_idTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.script_id = expected;
            actual = target.script_id;
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
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.id = expected;
            actual = target.id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for condition_id
        ///</summary>
        [TestMethod()]
        public void condition_idTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.condition_id = expected;
            actual = target.condition_id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for action_id
        ///</summary>
        [TestMethod()]
        public void action_idTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.action_id = expected;
            actual = target.action_id;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Setstep_numberNull
        ///</summary>
        [TestMethod()]
        public void Setstep_numberNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            target.Setstep_numberNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Setscript_idNull
        ///</summary>
        [TestMethod()]
        public void Setscript_idNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            target.Setscript_idNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Setcondition_idNull
        ///</summary>
        [TestMethod()]
        public void Setcondition_idNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            target.Setcondition_idNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Setaction_idNull
        ///</summary>
        [TestMethod()]
        public void Setaction_idNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            target.Setaction_idNull();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Isstep_numberNull
        ///</summary>
        [TestMethod()]
        public void Isstep_numberNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Isstep_numberNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Isscript_idNull
        ///</summary>
        [TestMethod()]
        public void Isscript_idNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Isscript_idNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Iscondition_idNull
        ///</summary>
        [TestMethod()]
        public void Iscondition_idNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Iscondition_idNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Isaction_idNull
        ///</summary>
        [TestMethod()]
        public void Isaction_idNullTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Isaction_idNull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for stepRow Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_stepRowConstructorTest()
        {
            DataRowBuilder rb = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow target = new AutoWebAgentDBDataSet.stepRow(rb);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
