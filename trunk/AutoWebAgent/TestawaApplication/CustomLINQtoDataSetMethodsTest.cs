using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data;
using System;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for CustomLINQtoDataSetMethodsTest and is intended
    ///to contain all CustomLINQtoDataSetMethodsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CustomLINQtoDataSetMethodsTest
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
        ///A test for CopyToDataTable
        ///</summary>
        public void CopyToDataTableTest1Helper<T>()
        {
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = CustomLINQtoDataSetMethods.CopyToDataTable<T>(source);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CopyToDataTableTest1()
        {
            CopyToDataTableTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for CopyToDataTable
        ///</summary>
        public void CopyToDataTableTestHelper<T>()
        {
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            DataTable table = null; // TODO: Initialize to an appropriate value
            Nullable<LoadOption> options = new Nullable<LoadOption>(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = CustomLINQtoDataSetMethods.CopyToDataTable<T>(source, table, options);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CopyToDataTableTest()
        {
            CopyToDataTableTestHelper<GenericParameterHelper>();
        }
    }
}
