using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.Serialization;
using System.Data;
using System;
using System.Xml.Schema;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSet_actionDataTableTest and is intended
    ///to contain all AutoWebAgentDBDataSet_actionDataTableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSet_actionDataTableTest
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
        ///A test for valueColumn
        ///</summary>
        [TestMethod()]
        public void valueColumnTest()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.valueColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for typeColumn
        ///</summary>
        [TestMethod()]
        public void typeColumnTest()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.typeColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow actual;
            actual = target[index];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for indexColumn
        ///</summary>
        [TestMethod()]
        public void indexColumnTest()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.indexColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for idColumn
        ///</summary>
        [TestMethod()]
        public void idColumnTest()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RemoveactionRow
        ///</summary>
        [TestMethod()]
        public void RemoveactionRowTest()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow row = null; // TODO: Initialize to an appropriate value
            target.RemoveactionRow(row);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnRowDeleting
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void OnRowDeletingTest()
        {
            AutoWebAgentDBDataSet_Accessor.actionDataTable target = new AutoWebAgentDBDataSet_Accessor.actionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet_Accessor.actionDataTable target = new AutoWebAgentDBDataSet_Accessor.actionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet_Accessor.actionDataTable target = new AutoWebAgentDBDataSet_Accessor.actionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet_Accessor.actionDataTable target = new AutoWebAgentDBDataSet_Accessor.actionDataTable(); // TODO: Initialize to an appropriate value
            DataRowChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnRowChanged(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for NewRowFromBuilder
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void NewRowFromBuilderTest()
        {
            AutoWebAgentDBDataSet_Accessor.actionDataTable target = new AutoWebAgentDBDataSet_Accessor.actionDataTable(); // TODO: Initialize to an appropriate value
            DataRowBuilder builder = null; // TODO: Initialize to an appropriate value
            DataRow expected = null; // TODO: Initialize to an appropriate value
            DataRow actual;
            actual = target.NewRowFromBuilder(builder);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NewactionRow
        ///</summary>
        [TestMethod()]
        public void NewactionRowTest()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow actual;
            actual = target.NewactionRow();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InitVars
        ///</summary>
        [TestMethod()]
        public void InitVarsTest()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet_Accessor.actionDataTable target = new AutoWebAgentDBDataSet_Accessor.actionDataTable(); // TODO: Initialize to an appropriate value
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
            actual = AutoWebAgentDBDataSet.actionDataTable.GetTypedTableSchema(xs);
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
            AutoWebAgentDBDataSet_Accessor.actionDataTable target = new AutoWebAgentDBDataSet_Accessor.actionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow actual;
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
            AutoWebAgentDBDataSet_Accessor.actionDataTable target = new AutoWebAgentDBDataSet_Accessor.actionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AddactionRow
        ///</summary>
        [TestMethod()]
        public void AddactionRowTest1()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow row = null; // TODO: Initialize to an appropriate value
            target.AddactionRow(row);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddactionRow
        ///</summary>
        [TestMethod()]
        public void AddactionRowTest()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(); // TODO: Initialize to an appropriate value
            string type = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionRow actual;
            actual = target.AddactionRow(type, value, index);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for actionDataTable Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_actionDataTableConstructorTest2()
        {
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for actionDataTable Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_actionDataTableConstructorTest1()
        {
            DataTable table = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionDataTable target = new AutoWebAgentDBDataSet.actionDataTable(table);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for actionDataTable Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void AutoWebAgentDBDataSet_actionDataTableConstructorTest()
        {
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet_Accessor.actionDataTable target = new AutoWebAgentDBDataSet_Accessor.actionDataTable(info, context);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
