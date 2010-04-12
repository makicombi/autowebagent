using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System;
using System.Collections.Generic;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for ObjectShredderTest and is intended
    ///to contain all ObjectShredderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ObjectShredderTest
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
        ///A test for ShredPrimitive
        ///</summary>
        public void ShredPrimitiveTestHelper<T>()
        {
            ObjectShredder<T> target = new ObjectShredder<T>(); // TODO: Initialize to an appropriate value
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            DataTable table = null; // TODO: Initialize to an appropriate value
            Nullable<LoadOption> options = new Nullable<LoadOption>(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.ShredPrimitive(source, table, options);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ShredPrimitiveTest()
        {
            ShredPrimitiveTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ShredObject
        ///</summary>
        public void ShredObjectTestHelper<T>()
        {
            ObjectShredder<T> target = new ObjectShredder<T>(); // TODO: Initialize to an appropriate value
            DataTable table = null; // TODO: Initialize to an appropriate value
            T instance = default(T); // TODO: Initialize to an appropriate value
            object[] expected = null; // TODO: Initialize to an appropriate value
            object[] actual;
            actual = target.ShredObject(table, instance);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ShredObjectTest()
        {
            ShredObjectTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Shred
        ///</summary>
        public void ShredTestHelper<T>()
        {
            ObjectShredder<T> target = new ObjectShredder<T>(); // TODO: Initialize to an appropriate value
            IEnumerable<T> source = null; // TODO: Initialize to an appropriate value
            DataTable table = null; // TODO: Initialize to an appropriate value
            Nullable<LoadOption> options = new Nullable<LoadOption>(); // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.Shred(source, table, options);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ShredTest()
        {
            ShredTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ExtendTable
        ///</summary>
        public void ExtendTableTestHelper<T>()
        {
            ObjectShredder<T> target = new ObjectShredder<T>(); // TODO: Initialize to an appropriate value
            DataTable table = null; // TODO: Initialize to an appropriate value
            Type type = null; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.ExtendTable(table, type);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ExtendTableTest()
        {
            ExtendTableTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ObjectShredder`1 Constructor
        ///</summary>
        public void ObjectShredderConstructorTestHelper<T>()
        {
            ObjectShredder<T> target = new ObjectShredder<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ObjectShredderConstructorTest()
        {
            ObjectShredderConstructorTestHelper<GenericParameterHelper>();
        }
    }
}
