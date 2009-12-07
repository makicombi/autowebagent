using WebRecorder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for SubItemEndEditingEventArgsTest and is intended
    ///to contain all SubItemEndEditingEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SubItemEndEditingEventArgsTest
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
        ///A test for DisplayText
        ///</summary>
        [TestMethod()]
        public void DisplayTextTest()
        {
            ListViewItem item = null; // TODO: Initialize to an appropriate value
            int subItem = 0; // TODO: Initialize to an appropriate value
            string display = string.Empty; // TODO: Initialize to an appropriate value
            bool cancel = false; // TODO: Initialize to an appropriate value
            SubItemEndEditingEventArgs target = new SubItemEndEditingEventArgs(item, subItem, display, cancel); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.DisplayText = expected;
            actual = target.DisplayText;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Cancel
        ///</summary>
        [TestMethod()]
        public void CancelTest()
        {
            ListViewItem item = null; // TODO: Initialize to an appropriate value
            int subItem = 0; // TODO: Initialize to an appropriate value
            string display = string.Empty; // TODO: Initialize to an appropriate value
            bool cancel = false; // TODO: Initialize to an appropriate value
            SubItemEndEditingEventArgs target = new SubItemEndEditingEventArgs(item, subItem, display, cancel); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.Cancel = expected;
            actual = target.Cancel;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SubItemEndEditingEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void SubItemEndEditingEventArgsConstructorTest()
        {
            ListViewItem item = null; // TODO: Initialize to an appropriate value
            int subItem = 0; // TODO: Initialize to an appropriate value
            string display = string.Empty; // TODO: Initialize to an appropriate value
            bool cancel = false; // TODO: Initialize to an appropriate value
            SubItemEndEditingEventArgs target = new SubItemEndEditingEventArgs(item, subItem, display, cancel);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
