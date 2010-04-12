using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.Serialization;
using System.Data;
using System;
using System.Xml.Schema;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSet_conditionDataTableTest and is intended
    ///to contain all AutoWebAgentDBDataSet_conditionDataTableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSet_conditionDataTableTest
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
        ///A test for rhs_valueColumn
        ///</summary>
        [TestMethod()]
        public void rhs_valueColumnTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.rhs_valueColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for rhs_element_idColumn
        ///</summary>
        [TestMethod()]
        public void rhs_element_idColumnTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.rhs_element_idColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for rhs_element_attrColumn
        ///</summary>
        [TestMethod()]
        public void rhs_element_attrColumnTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.rhs_element_attrColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for opColumn
        ///</summary>
        [TestMethod()]
        public void opColumnTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.opColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for lhs_element_idColumn
        ///</summary>
        [TestMethod()]
        public void lhs_element_idColumnTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.lhs_element_idColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for lhs_element_attrColumn
        ///</summary>
        [TestMethod()]
        public void lhs_element_attrColumnTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            DataColumn actual;
            actual = target.lhs_element_attrColumn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionRow actual;
            actual = target[index];
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for idColumn
        ///</summary>
        [TestMethod()]
        public void idColumnTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RemoveconditionRow
        ///</summary>
        [TestMethod()]
        public void RemoveconditionRowTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionRow row = null; // TODO: Initialize to an appropriate value
            target.RemoveconditionRow(row);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnRowDeleting
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void OnRowDeletingTest()
        {
            AutoWebAgentDBDataSet_Accessor.conditionDataTable target = new AutoWebAgentDBDataSet_Accessor.conditionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet_Accessor.conditionDataTable target = new AutoWebAgentDBDataSet_Accessor.conditionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet_Accessor.conditionDataTable target = new AutoWebAgentDBDataSet_Accessor.conditionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet_Accessor.conditionDataTable target = new AutoWebAgentDBDataSet_Accessor.conditionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet_Accessor.conditionDataTable target = new AutoWebAgentDBDataSet_Accessor.conditionDataTable(); // TODO: Initialize to an appropriate value
            DataRowBuilder builder = null; // TODO: Initialize to an appropriate value
            DataRow expected = null; // TODO: Initialize to an appropriate value
            DataRow actual;
            actual = target.NewRowFromBuilder(builder);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NewconditionRow
        ///</summary>
        [TestMethod()]
        public void NewconditionRowTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionRow actual;
            actual = target.NewconditionRow();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InitVars
        ///</summary>
        [TestMethod()]
        public void InitVarsTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet_Accessor.conditionDataTable target = new AutoWebAgentDBDataSet_Accessor.conditionDataTable(); // TODO: Initialize to an appropriate value
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
            actual = AutoWebAgentDBDataSet.conditionDataTable.GetTypedTableSchema(xs);
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
            AutoWebAgentDBDataSet_Accessor.conditionDataTable target = new AutoWebAgentDBDataSet_Accessor.conditionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionRow actual;
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
            AutoWebAgentDBDataSet_Accessor.conditionDataTable target = new AutoWebAgentDBDataSet_Accessor.conditionDataTable(); // TODO: Initialize to an appropriate value
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
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AddconditionRow
        ///</summary>
        [TestMethod()]
        public void AddconditionRowTest1()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionRow row = null; // TODO: Initialize to an appropriate value
            target.AddconditionRow(row);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for AddconditionRow
        ///</summary>
        [TestMethod()]
        public void AddconditionRowTest()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(); // TODO: Initialize to an appropriate value
            int lhs_element_id = 0; // TODO: Initialize to an appropriate value
            string op = string.Empty; // TODO: Initialize to an appropriate value
            string lhs_element_attr = string.Empty; // TODO: Initialize to an appropriate value
            string rhs_value = string.Empty; // TODO: Initialize to an appropriate value
            string rhs_element_id = string.Empty; // TODO: Initialize to an appropriate value
            string rhs_element_attr = string.Empty; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionRow actual;
            actual = target.AddconditionRow(lhs_element_id, op, lhs_element_attr, rhs_value, rhs_element_id, rhs_element_attr);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for conditionDataTable Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_conditionDataTableConstructorTest2()
        {
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for conditionDataTable Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSet_conditionDataTableConstructorTest1()
        {
            DataTable table = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionDataTable target = new AutoWebAgentDBDataSet.conditionDataTable(table);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for conditionDataTable Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void AutoWebAgentDBDataSet_conditionDataTableConstructorTest()
        {
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet_Accessor.conditionDataTable target = new AutoWebAgentDBDataSet_Accessor.conditionDataTable(info, context);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
