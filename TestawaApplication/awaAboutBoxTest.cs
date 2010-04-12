using awaApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for awaAboutBoxTest and is intended
    ///to contain all awaAboutBoxTest Unit Tests
    ///</summary>
    [TestClass()]
    public class awaAboutBoxTest
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
        ///A test for AssemblyVersion
        ///</summary>
        [TestMethod()]
        public void AssemblyVersionTest()
        {
            awaAboutBox target = new awaAboutBox(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AssemblyVersion;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AssemblyTitle
        ///</summary>
        [TestMethod()]
        public void AssemblyTitleTest()
        {
            awaAboutBox target = new awaAboutBox(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AssemblyTitle;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AssemblyProduct
        ///</summary>
        [TestMethod()]
        public void AssemblyProductTest()
        {
            awaAboutBox target = new awaAboutBox(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AssemblyProduct;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AssemblyDescription
        ///</summary>
        [TestMethod()]
        public void AssemblyDescriptionTest()
        {
            awaAboutBox target = new awaAboutBox(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AssemblyDescription;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AssemblyCopyright
        ///</summary>
        [TestMethod()]
        public void AssemblyCopyrightTest()
        {
            awaAboutBox target = new awaAboutBox(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AssemblyCopyright;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AssemblyCompany
        ///</summary>
        [TestMethod()]
        public void AssemblyCompanyTest()
        {
            awaAboutBox target = new awaAboutBox(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.AssemblyCompany;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for okButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaApplication.exe")]
        public void okButton_ClickTest()
        {
            awaAboutBox_Accessor target = new awaAboutBox_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.okButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaApplication.exe")]
        public void InitializeComponentTest()
        {
            awaAboutBox_Accessor target = new awaAboutBox_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaApplication.exe")]
        public void DisposeTest()
        {
            awaAboutBox_Accessor target = new awaAboutBox_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for awaAboutBox_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaApplication.exe")]
        public void awaAboutBox_LoadTest()
        {
            awaAboutBox_Accessor target = new awaAboutBox_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.awaAboutBox_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for awaAboutBox_FormClosed
        ///</summary>
        [TestMethod()]
        [DeploymentItem("awaApplication.exe")]
        public void awaAboutBox_FormClosedTest()
        {
            awaAboutBox_Accessor target = new awaAboutBox_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            FormClosedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.awaAboutBox_FormClosed(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for awaAboutBox Constructor
        ///</summary>
        [TestMethod()]
        public void awaAboutBoxConstructorTest()
        {
            awaAboutBox target = new awaAboutBox();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
