using WebRecorder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for SubItemEventArgsTest and is intended
    ///to contain all SubItemEventArgsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SubItemEventArgsTest
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
        ///A test for SubItem
        ///</summary>
        [TestMethod()]
        public void SubItemTest()
        {
            ListViewItem item = null; // TODO: Initialize to an appropriate value
            int subItem = 0; // TODO: Initialize to an appropriate value
            SubItemEventArgs target = new SubItemEventArgs(item, subItem); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.SubItem;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            ListViewItem item = null; // TODO: Initialize to an appropriate value
            int subItem = 0; // TODO: Initialize to an appropriate value
            SubItemEventArgs target = new SubItemEventArgs(item, subItem); // TODO: Initialize to an appropriate value
            ListViewItem actual;
            actual = target.Item;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SubItemEventArgs Constructor
        ///</summary>
        [TestMethod()]
        public void SubItemEventArgsConstructorTest()
        {
            ListViewItem item = null; // TODO: Initialize to an appropriate value
            int subItem = 0; // TODO: Initialize to an appropriate value
            SubItemEventArgs target = new SubItemEventArgs(item, subItem);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
