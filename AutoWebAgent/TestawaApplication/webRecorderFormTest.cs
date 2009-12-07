using WebRecorder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System;
using awaDAL;

namespace TestawaApplication
{
    
    
    /// <summary>
    ///This is a test class for webRecorderFormTest and is intended
    ///to contain all webRecorderFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class webRecorderFormTest
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
        ///A test for WebsiteRow
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void WebsiteRowTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow expected = null; // TODO: Initialize to an appropriate value
            AutoWebAgentDBDataSet.websiteRow actual;
            target.WebsiteRow = expected;
            actual = target.WebsiteRow;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WebsiteID
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void WebsiteIDTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.WebsiteID = expected;
            actual = target.WebsiteID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for webBrowser_PreviewKeyDown
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void webBrowser_PreviewKeyDownTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            PreviewKeyDownEventArgs e = null; // TODO: Initialize to an appropriate value
            target.webBrowser_PreviewKeyDown(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for webBrowser_DocumentCompleted
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void webBrowser_DocumentCompletedTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            WebBrowserDocumentCompletedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.webBrowser_DocumentCompleted(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for urlTextBox_KeyUp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void urlTextBox_KeyUpTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            KeyEventArgs e = null; // TODO: Initialize to an appropriate value
            target.urlTextBox_KeyUp(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for updateGrid
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void updateGridTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            target.updateGrid();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for textBox1_TextChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void textBox1_TextChangedTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.textBox1_TextChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for selectedElementListView_SubItemClicked
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void selectedElementListView_SubItemClickedTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            SubItemEventArgs e = null; // TODO: Initialize to an appropriate value
            target.selectedElementListView_SubItemClicked(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for saveElementButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void saveElementButton_ClickTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.saveElementButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for saveButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void saveButton_ClickTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.saveButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void InitializeComponentTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for goButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void goButton_ClickTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.goButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Document_MouseOver
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void Document_MouseOverTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            HtmlElementEventArgs e = null; // TODO: Initialize to an appropriate value
            target.Document_MouseOver(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Document_MouseLeave
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void Document_MouseLeaveTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            HtmlElementEventArgs e = null; // TODO: Initialize to an appropriate value
            target.Document_MouseLeave(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void DisposeTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for clearSiteButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void clearSiteButton_ClickTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.clearSiteButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for analyzeElement
        ///</summary>
        [TestMethod()]
        [DeploymentItem("WebRecorder.exe")]
        public void analyzeElementTest()
        {
            webRecorderForm_Accessor target = new webRecorderForm_Accessor(); // TODO: Initialize to an appropriate value
            HtmlElement currentElement = null; // TODO: Initialize to an appropriate value
            target.analyzeElement(currentElement);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for webRecorderForm Constructor
        ///</summary>
        [TestMethod()]
        public void webRecorderFormConstructorTest()
        {
            webRecorderForm target = new webRecorderForm();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
