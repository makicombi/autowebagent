using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.Serialization;
using System.Data;
using System;
using System.Xml.Schema;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSet_stepDataTableTest and is intended
    ///to contain all AutoWebAgentDBDataSet_stepDataTableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSet_stepDataTableTest
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
        ///A test for step_numberColumn
        ///</summary>
        [TestMethod()]
        public void step_numberColumnTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.step_numberColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for script_idColumn
        ///</summary>
        [TestMethod()]
        public void script_idColumnTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.script_idColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow actual;
            actual = target[index];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for idColumn
        ///</summary>
        [TestMethod()]
        public void idColumnTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.idColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for condition_idColumn
        ///</summary>
        [TestMethod()]
        public void condition_idColumnTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.condition_idColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for action_idColumn
        ///</summary>
        [TestMethod()]
        public void action_idColumnTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.action_idColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RemovestepRow
        ///</summary>
        [TestMethod()]
        public void RemovestepRowTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow row = null; // TODO: Initialize to an appropriate value
            target.RemovestepRow(row);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnRowDeleting
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void OnRowDeletingTest()
        {
            AutoWebAgentDBDataSet_Accessor.stepDataTable target = new AutoWebAgentDBDataSet_Accessor.stepDataTable(); // TODO: Initialize to an appropriate value
            DataRowChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnRowDeleting(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnRowDeleted
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void OnRowDeletedTest()
        {
            AutoWebAgentDBDataSet_Accessor.stepDataTable target = new AutoWebAgentDBDataSet_Accessor.stepDataTable(); // TODO: Initialize to an appropriate value
            DataRowChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnRowDeleted(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnRowChanging
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void OnRowChangingTest()
        {
            AutoWebAgentDBDataSet_Accessor.stepDataTable target = new AutoWebAgentDBDataSet_Accessor.stepDataTable(); // TODO: Initialize to an appropriate value
            DataRowChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnRowChanging(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnRowChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void OnRowChangedTest()
        {
            AutoWebAgentDBDataSet_Accessor.stepDataTable target = new AutoWebAgentDBDataSet_Accessor.stepDataTable(); // TODO: Initialize to an appropriate value
            DataRowChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnRowChanged(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for NewstepRow
        ///</summary>
        [TestMethod()]
        public void NewstepRowTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow actual;
            actual = target.NewstepRow();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NewRowFromBuilder
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void NewRowFromBuilderTest()
        {
            AutoWebAgentDBDataSet_Accessor.stepDataTable target = new AutoWebAgentDBDataSet_Accessor.stepDataTable(); // TODO: Initialize to an appropriate value
            DataRowBuilder builder = null; // TODO: Initialize to an appropriate value
            DataRow expected = null; // TODO: Initialize to an appropriate value
            DataRow actual;
            actual = target.NewRowFromBuilder(builder);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InitVars
        ///</summary>
        [TestMethod()]
        public void InitVarsTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            target.InitVars();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitClass
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void InitClassTest()
        {
            AutoWebAgentDBDataSet_Accessor.stepDataTable target = new AutoWebAgentDBDataSet_Accessor.stepDataTable(); // TODO: Initialize to an appropriate value
            target.InitClass();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetTypedTableSchema
        ///</summary>
        [TestMethod()]
        public void GetTypedTableSchemaTest()
        {
            XmlSchemaSet xs = null; // TODO: Initialize to an appropriate value
            XmlSchemaComplexType expected = null; // TODO: Initialize to an appropriate value
            XmlSchemaComplexType actual;
            actual = AutoWebAgentDBDataSet.stepDataTable.GetTypedTableSchema(xs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetRowType
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void GetRowTypeTest()
        {
            AutoWebAgentDBDataSet_Accessor.stepDataTable target = new AutoWebAgentDBDataSet_Accessor.stepDataTable(); // TODO: Initialize to an appropriate value
            Type expected = null; // TODO: Initialize to an appropriate value
            Type actual;
            actual = target.GetRowType();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FindByid
        ///</summary>
        [TestMethod()]
        public void FindByidTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow actual;
            actual = target.FindByid(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateInstance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void CreateInstanceTest()
        {
            AutoWebAgentDBDataSet_Accessor.stepDataTable target = new AutoWebAgentDBDataSet_Accessor.stepDataTable(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.CreateInstance();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AddstepRow
        ///</summary>
        [TestMethod()]
        public void AddstepRowTest1()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow row = null; // TODO: Initialize to an appropriate value
            target.AddstepRow(row);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddstepRow
        ///</summary>
        [TestMethod()]
        public void AddstepRowTest()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(); // TODO: Initialize to an appropriate value
            int script_id = 0; // TODO: Initialize to an appropriate value
            int condition_id = 0; // TODO: Initialize to an appropriate value
            int action_id = 0; // TODO: Initialize to an appropriate value
            int step_number = 0; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepRow actual;
            actual = target.AddstepRow(script_id, condition_id, action_id, step_number);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for stepDataTable Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_stepDataTableConstructorTest2()
        {
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for stepDataTable Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_stepDataTableConstructorTest1()
        {
            DataTable table = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepDataTable target = new AutoWebAgentDBDataSet.stepDataTable(table);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for stepDataTable Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void AutoWebAgentDBDataSet_stepDataTableConstructorTest()
        {
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet_Accessor.stepDataTable target = new AutoWebAgentDBDataSet_Accessor.stepDataTable(info, context);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
