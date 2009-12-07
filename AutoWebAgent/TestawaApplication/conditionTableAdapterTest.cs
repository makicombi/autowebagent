﻿using awaDAL.AutoWebAgentDBDataSetTableAdapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using awaDAL;
using System;
using System.Data;
using System.Data.SqlServerCe;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for conditionTableAdapterTest and is intended
    ///to contain all conditionTableAdapterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class conditionTableAdapterTest
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
        ///A test for Transaction
        ///</summary>
        [TestMethod()]
        public void TransactionTest()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            SqlCeTransaction expected = null; // TODO: Initialize to an appropriate value
            SqlCeTransaction actual;
            target.Transaction = expected;
            actual = target.Transaction;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Connection
        ///</summary>
        [TestMethod()]
        public void ConnectionTest()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            SqlCeConnection expected = null; // TODO: Initialize to an appropriate value
            SqlCeConnection actual;
            target.Connection = expected;
            actual = target.Connection;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CommandCollection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void CommandCollectionTest()
        {
            conditionTableAdapter_Accessor target = new conditionTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            SqlCeCommand[] actual;
            actual = target.CommandCollection;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ClearBeforeFill
        ///</summary>
        [TestMethod()]
        public void ClearBeforeFillTest()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.ClearBeforeFill = expected;
            actual = target.ClearBeforeFill;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Adapter
        ///</summary>
        [TestMethod()]
        public void AdapterTest()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            SqlCeDataAdapter actual;
            actual = target.Adapter;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest4()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            DataRow dataRow = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(dataRow);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest3()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet dataSet = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(dataSet);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest2()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionDataTable dataTable = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(dataTable);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest1()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            DataRow[] dataRows = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(dataRows);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            Nullable<int> p1 = new Nullable<int>(); // TODO: Initialize to an appropriate value
            string p2 = string.Empty; // TODO: Initialize to an appropriate value
            string p3 = string.Empty; // TODO: Initialize to an appropriate value
            string p4 = string.Empty; // TODO: Initialize to an appropriate value
            string p5 = string.Empty; // TODO: Initialize to an appropriate value
            string p6 = string.Empty; // TODO: Initialize to an appropriate value
            int p7 = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Update(p1, p2, p3, p4, p5, p6, p7);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        [TestMethod()]
        public void InsertTest()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            Nullable<int> p1 = new Nullable<int>(); // TODO: Initialize to an appropriate value
            string p2 = string.Empty; // TODO: Initialize to an appropriate value
            string p3 = string.Empty; // TODO: Initialize to an appropriate value
            string p4 = string.Empty; // TODO: Initialize to an appropriate value
            string p5 = string.Empty; // TODO: Initialize to an appropriate value
            string p6 = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Insert(p1, p2, p3, p4, p5, p6);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InitConnection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void InitConnectionTest()
        {
            conditionTableAdapter_Accessor target = new conditionTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            target.InitConnection();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitCommandCollection
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void InitCommandCollectionTest()
        {
            conditionTableAdapter_Accessor target = new conditionTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            target.InitCommandCollection();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitAdapter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaDAL.dll")]
        public void InitAdapterTest()
        {
            conditionTableAdapter_Accessor target = new conditionTableAdapter_Accessor(); // TODO: Initialize to an appropriate value
            target.InitAdapter();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetData
        ///</summary>
        [TestMethod()]
        public void GetDataTest()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionDataTable expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionDataTable actual;
            actual = target.GetData();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Fill
        ///</summary>
        [TestMethod()]
        public void FillTest()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.conditionDataTable dataTable = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Fill(dataTable);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        [TestMethod()]
        public void DeleteTest()
        {
            conditionTableAdapter target = new conditionTableAdapter(); // TODO: Initialize to an appropriate value
            int p1 = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Delete(p1);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for conditionTableAdapter Constructor
        ///</summary>
        [TestMethod()]
        public void conditionTableAdapterConstructorTest()
        {
            conditionTableAdapter target = new conditionTableAdapter();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
