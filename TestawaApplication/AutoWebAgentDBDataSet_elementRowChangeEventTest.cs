using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSet_elementRowChangeEventTest and is intended
    ///to contain all AutoWebAgentDBDataSet_elementRowChangeEventTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSet_elementRowChangeEventTest
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
        ///A test for Row
        ///</summary>
        [TestMethod()]
        public void RowTest()
        {
            AutoWebAgentDBDataSet.elementRow row = null; // TODO: Initialize to an appropriate value
            DataRowAction action = new DataRowAction(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRowChangeEvent target = new AutoWebAgentDBDataSet.elementRowChangeEvent(row, action); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRow actual;
            actual = target.Row;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Action
        ///</summary>
        [TestMethod()]
        public void ActionTest()
        {
            AutoWebAgentDBDataSet.elementRow row = null; // TODO: Initialize to an appropriate value
            DataRowAction action = new DataRowAction(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRowChangeEvent target = new AutoWebAgentDBDataSet.elementRowChangeEvent(row, action); // TODO: Initialize to an appropriate value
            DataRowAction actual;
            actual = target.Action;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for elementRowChangeEvent Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_elementRowChangeEventConstructorTest()
        {
            AutoWebAgentDBDataSet.elementRow row = null; // TODO: Initialize to an appropriate value
            DataRowAction action = new DataRowAction(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementRowChangeEvent target = new AutoWebAgentDBDataSet.elementRowChangeEvent(row, action);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
