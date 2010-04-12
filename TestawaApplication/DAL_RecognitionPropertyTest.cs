using awaDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for DAL_RecognitionPropertyTest and is intended
    ///to contain all DAL_RecognitionPropertyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DAL_RecognitionPropertyTest
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
        ///A test for Value
        ///</summary>
        [TestMethod()]
        public void ValueTest()
        {
            string a = string.Empty; // TODO: Initialize to an appropriate value
            string v = string.Empty; // TODO: Initialize to an appropriate value
            int p = 0; // TODO: Initialize to an appropriate value
            DAL.RecognitionProperty target = new DAL.RecognitionProperty(a, v, p); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Value = expected;
            actual = target.Value;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Priority
        ///</summary>
        [TestMethod()]
        public void PriorityTest()
        {
            string a = string.Empty; // TODO: Initialize to an appropriate value
            string v = string.Empty; // TODO: Initialize to an appropriate value
            int p = 0; // TODO: Initialize to an appropriate value
            DAL.RecognitionProperty target = new DAL.RecognitionProperty(a, v, p); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Priority = expected;
            actual = target.Priority;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Attribute
        ///</summary>
        [TestMethod()]
        public void AttributeTest()
        {
            string a = string.Empty; // TODO: Initialize to an appropriate value
            string v = string.Empty; // TODO: Initialize to an appropriate value
            int p = 0; // TODO: Initialize to an appropriate value
            DAL.RecognitionProperty target = new DAL.RecognitionProperty(a, v, p); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Attribute = expected;
            actual = target.Attribute;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RecognitionProperty Constructor
        ///</summary>
        [TestMethod()]
        public void DAL_RecognitionPropertyConstructorTest()
        {
            string a = string.Empty; // TODO: Initialize to an appropriate value
            string v = string.Empty; // TODO: Initialize to an appropriate value
            int p = 0; // TODO: Initialize to an appropriate value
            DAL.RecognitionProperty target = new DAL.RecognitionProperty(a, v, p);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
