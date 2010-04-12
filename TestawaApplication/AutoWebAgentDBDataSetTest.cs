using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.Serialization;
using System.Data;
using System.Xml.Schema;
using System.Xml;
using System.ComponentModel;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for AutoWebAgentDBDataSetTest and is intended
    ///to contain all AutoWebAgentDBDataSetTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AutoWebAgentDBDataSetTest
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
        ///A test for website
        ///</summary>
        [TestMethod()]
        public void websiteTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteDataTable actual;
            actual = target.website;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for users
        ///</summary>
        [TestMethod()]
        public void usersTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.usersDataTable actual;
            actual = target.users;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Tables
        ///</summary>
        [TestMethod()]
        public void TablesTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            DataTableCollection actual;
            actual = target.Tables;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for step
        ///</summary>
        [TestMethod()]
        public void stepTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.stepDataTable actual;
            actual = target.step;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for script
        ///</summary>
        [TestMethod()]
        public void scriptTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.scriptDataTable actual;
            actual = target.script;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SchemaSerializationMode
        ///</summary>
        [TestMethod()]
        public void SchemaSerializationModeTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            SchemaSerializationMode expected = new SchemaSerializationMode(); // TODO: Initialize to an appropriate value
            SchemaSerializationMode actual;
            target.SchemaSerializationMode = expected;
            actual = target.SchemaSerializationMode;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Relations
        ///</summary>
        [TestMethod()]
        public void RelationsTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            DataRelationCollection actual;
            actual = target.Relations;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for recognition
        ///</summary>
        [TestMethod()]
        public void recognitionTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.recognitionDataTable actual;
            actual = target.recognition;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for element
        ///</summary>
        [TestMethod()]
        public void elementTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.elementDataTable actual;
            actual = target.element;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for condition
        ///</summary>
        [TestMethod()]
        public void conditionTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionDataTable actual;
            actual = target.condition;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for action
        ///</summary>
        [TestMethod()]
        public void actionTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.actionDataTable actual;
            actual = target.action;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializewebsite
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializewebsiteTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializewebsite();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializeusers
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializeusersTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializeusers();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializeTables
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializeTablesTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializeTables();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializestep
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializestepTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializestep();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializescript
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializescriptTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializescript();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializeRelations
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializeRelationsTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializeRelations();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializerecognition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializerecognitionTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializerecognition();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializeelement
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializeelementTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializeelement();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializecondition
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializeconditionTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializecondition();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShouldSerializeaction
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ShouldSerializeactionTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.ShouldSerializeaction();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SchemaChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void SchemaChangedTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            CollectionChangeEventArgs e = null; // TODO: Initialize to an appropriate value
            target.SchemaChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ReadXmlSerializable
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void ReadXmlSerializableTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            XmlReader reader = null; // TODO: Initialize to an appropriate value
            target.ReadXmlSerializable(reader);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitVars
        ///</summary>
        [TestMethod()]
        public void InitVarsTest1()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            target.InitVars();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitVars
        ///</summary>
        [TestMethod()]
        public void InitVarsTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            bool initTable = false; // TODO: Initialize to an appropriate value
            target.InitVars(initTable);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeDerivedDataSet
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void InitializeDerivedDataSetTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeDerivedDataSet();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitClass
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void InitClassTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            target.InitClass();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetTypedDataSetSchema
        ///</summary>
        [TestMethod()]
        public void GetTypedDataSetSchemaTest()
        {
            XmlSchemaSet xs = null; // TODO: Initialize to an appropriate value
            XmlSchemaComplexType expected = null; // TODO: Initialize to an appropriate value
            XmlSchemaComplexType actual;
            actual = AutoWebAgentDBDataSet.GetTypedDataSetSchema(xs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSchemaSerializable
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void GetSchemaSerializableTest()
        {
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(); // TODO: Initialize to an appropriate value
            XmlSchema expected = null; // TODO: Initialize to an appropriate value
            XmlSchema actual;
            actual = target.GetSchemaSerializable();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Clone
        ///</summary>
        [TestMethod()]
        public void CloneTest()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet(); // TODO: Initialize to an appropriate value
            DataSet expected = null; // TODO: Initialize to an appropriate value
            DataSet actual;
            actual = target.Clone();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AutoWebAgentDBDataSet Constructor
        ///</summary>
        [TestMethod()]
        public void AutoWebAgentDBDataSetConstructorTest1()
        {
            AutoWebAgentDBDataSet target = new AutoWebAgentDBDataSet();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AutoWebAgentDBDataSet Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void AutoWebAgentDBDataSetConstructorTest()
        {
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet_Accessor target = new AutoWebAgentDBDataSet_Accessor(info, context);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
