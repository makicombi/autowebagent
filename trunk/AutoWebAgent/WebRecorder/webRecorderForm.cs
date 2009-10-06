using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using awaDAL;
namespace WebRecorder
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class webRecorderForm : Form
    {
        private DAL dal;
        private HtmlElement currentElement;
        public int WebsiteID { get; private set; }
        
        enum SelectionState
        {
            IDLE, INPROGRESS, SELECTED
        }
        private SelectionState selectionState = SelectionState.IDLE;
        private IDictionary<HtmlElement, string> elementStyles = new Dictionary<HtmlElement, string>();

        public webRecorderForm()
        {
          
            InitializeComponent();
            webBrowser.ObjectForScripting = this;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);
            
            dal = new DAL();
            dal.Init(Properties.Settings.Default.awaDB);
            //MessageBox.Show(dal.DB.website.Rows[0][dal.DB.website.urlColumn].ToString()); 
            
        }

        void Document_MouseLeave(object sender, HtmlElementEventArgs e)
        {
            HtmlElement element = e.FromElement;
            if (this.elementStyles.ContainsKey(element))
            {
                string style = this.elementStyles[element];
                this.elementStyles.Remove(element);
                element.Style = style;
            }
            if (!webBrowser.Focused)
            {
                webBrowser.Focus();
            }
            
        }

        void Document_MouseOver(object sender, HtmlElementEventArgs e)
        {
            if(!webBrowser.Focused) webBrowser.Focus();
            HtmlElement element = e.ToElement;
            if (!this.elementStyles.ContainsKey(element))
            {
                string style = element.Style;
                this.elementStyles.Add(element, style);
                element.Style = style + "; border-style: solid; border-color: red;";
                statusStrip1.Items[0].Text ="ID:" + (element.Id ?? "(no id)");
            }
            // prevent opening new window via target="_blank"
            //if ((att.name == "target") && (att.value == "_blank")) att.value = "_self"; 
            if (element.GetAttribute("target")=="_blank") element.SetAttribute("target","_self");
            currentElement = element;

        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.Document.MouseOver += new HtmlElementEventHandler(Document_MouseOver);
            webBrowser.Document.MouseLeave += new HtmlElementEventHandler(Document_MouseLeave);
            
        }

        

        private void goButton_Click(object sender, EventArgs e)
        {

            if ((!urlTextBox.Text.StartsWith("http://")) && (!urlTextBox.Text.StartsWith("https://")))
            {
                urlTextBox.Text = "http://" + urlTextBox.Text;
            }
            if (Uri.IsWellFormedUriString(urlTextBox.Text, UriKind.RelativeOrAbsolute))
            {
                try
                {
                    webBrowser.Navigate(urlTextBox.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    return;
                }
                try
                {
                    WebsiteID = dal.GetWebsiteID(urlTextBox.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Internal Error:" + exc.Message);
                    Application.Exit();
                }

                // New Website
                if (WebsiteID<0)
                {
                    if (websiteNameTextBox.Text.Length>0)
	                {
                		awaDAL.AutoWebAgentDBDataSet.websiteRow row = dal.DB.website.AddwebsiteRow(websiteNameTextBox.Text,urlTextBox.Text);
	                }
                    else
                    {
                        awaDAL.AutoWebAgentDBDataSet.websiteRow row = dal.DB.website.AddwebsiteRow(urlTextBox.Text, urlTextBox.Text);
                        
                    }
                }
                //update website
                else
                {
                    if (websiteNameTextBox.Text.Length>0)
                    {
                        dal.DB.website.FindByid(WebsiteID).name = websiteNameTextBox.Text;    
                    }
                    else
                    {
                        websiteNameTextBox.Text = dal.DB.website.FindByid(WebsiteID).name;
                    }
                    
                }

                
            }
            else
            {
                MessageBox.Show("URL Error");
            }
        }

        private void urlTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                goButton.PerformClick();
            }
        }
        private bool toggle;
        private void webBrowser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            toggle = !toggle;
            if (toggle) return;
            if (e.KeyCode==Keys.ShiftKey)
            {
                switch (selectionState)
                {
                    case SelectionState.IDLE:
                        selectionState = SelectionState.INPROGRESS;
                        break;
                    case SelectionState.INPROGRESS:
                        selectionState = SelectionState.SELECTED;
                        analyzeElement(currentElement);
                        break;
                    case SelectionState.SELECTED:
                        selectionState = SelectionState.INPROGRESS;
                        break;

                }
            }
            else
            {
                selectionState = SelectionState.IDLE;
            }
            statusStrip1.Items[1].Text = selectionState.ToString();    
            
        }

        private void analyzeElement(HtmlElement currentElement)
        {
            selectedElementListView.Items.Clear();
            List<DAL.RecognitionProperty> props = new List<DAL.RecognitionProperty>();
            WatiN.Core.Native.InternetExplorer.IEElement element = new WatiN.Core.Native.InternetExplorer.IEElement(currentElement.DomElement);
            mshtml.IHTMLDOMNode nd = (mshtml.IHTMLDOMNode)element.AsHtmlElement;
            mshtml.IHTMLAttributeCollection attribs = (mshtml.IHTMLAttributeCollection)nd.attributes;
            if ((currentElement.Name != null) && (currentElement.Name.Length > 0))
	        {
                props.Add(new DAL.RecognitionProperty("Name", currentElement.Name, 50));
                ListViewItem item = selectedElementListView.Items.Add("Name");
                item.SubItems.Add(currentElement.Name);
                item.SubItems.Add("50").Tag = 50;
	        }
            if ((currentElement.TagName != null) && (currentElement.TagName.Length > 0))
            {
                props.Add(new DAL.RecognitionProperty("Tag", currentElement.TagName, 20));
                ListViewItem item = selectedElementListView.Items.Add("Tag");
                item.SubItems.Add(currentElement.TagName);
                item.SubItems.Add("20").Tag = 20;
            }
            if ((currentElement.Id != null) && (currentElement.Id.Length > 0))
            {
                props.Add(new DAL.RecognitionProperty("Id", currentElement.Id, 100));
                ListViewItem item = selectedElementListView.Items.Add("Id");
                item.SubItems.Add(currentElement.Id);
                item.SubItems.Add("100").Tag = 100;
            }
            if ((currentElement.OuterText!=null) && (currentElement.OuterText.Length > 0))
            {
                props.Add(new DAL.RecognitionProperty("OuterText", currentElement.OuterText, 20));
                ListViewItem item = selectedElementListView.Items.Add("OuterText");
                item.SubItems.Add(currentElement.OuterText);
                item.SubItems.Add("20").Tag = 20;
            }
            if ((currentElement.InnerText!=null) && (currentElement.InnerText.Length > 0))
            {
                props.Add(new DAL.RecognitionProperty("InnerText", currentElement.InnerText, 20));
                ListViewItem item = selectedElementListView.Items.Add("InnerText");
                item.SubItems.Add(currentElement.InnerText);
                item.SubItems.Add("20").Tag = 20;
            }
            


            foreach (mshtml.IHTMLDOMAttribute2 att in attribs)
            {
                if (((mshtml.IHTMLDOMAttribute)att).specified)
                {
                    
                    props.Add(new DAL.RecognitionProperty(att.name, att.value, 10));
                    
                    ListViewItem item = selectedElementListView.Items.Add(att.name);
                    item.SubItems.Add(att.value);
                    item.SubItems.Add("10").Tag = 10;

                }

            }
            //IEnumerable<DAL.RecognitionProperty> a =  dal.GetElementRecogitionProperties();
            //foreach (var item in a)
            //{
                
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                dal.SaveChanges();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Failed to save changes:"+exc.Message);
                Application.Exit();

            }          
        }

        void selectedElementListView_SubItemClicked(object sender, SubItemEventArgs e)
        {
            TextBox editBox = new TextBox();
            this.Controls.Add(editBox);
            selectedElementListView.StartEditing(editBox, e.Item, e.SubItem);
        }
    }
}
