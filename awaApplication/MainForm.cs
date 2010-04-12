using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using awaDAL;
namespace awaApplication
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class MainForm : Form
    {
        awaAboutBox aBox;
        private Login loginForm;
        private TextEntryForm scriptEntryForm, stepEntryForm;
        private DAL dal;
        private HtmlElement currentElement;
        private DAL.ElementType currentElementType = DAL.ElementType.NONE;
        public int WebsiteID { get; private set; }
        public AutoWebAgentDBDataSet.websiteRow WebsiteRow { get; private set; }

        enum SelectionState
        {
            IDLE, INPROGRESS, SELECTED
        }
        private SelectionState selectionState = SelectionState.IDLE;
        private IDictionary<HtmlElement, string> elementStyles = new Dictionary<HtmlElement, string>();
        
        public MainForm()
        {
            InitializeComponent();

            listBoxScripts.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnValidation;
            listBoxSteps.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnValidation;
            

            scriptEntryForm = new TextEntryForm("Please Enter New Script Name:");
            scriptEntryForm.Submitted += new EventHandler(scriptEntryForm_Submitted);
            scriptEntryForm.Location = buttonAddScript.Location;
            scriptEntryForm.BringToFront();
            scriptEntryForm.Visible = false;
            tabScript.Controls.Add(scriptEntryForm);

            stepEntryForm = new TextEntryForm("Please Enter New Step Name:");
            stepEntryForm.Submitted += new EventHandler(stepEntryForm_Submitted);
            stepEntryForm.Location = buttonAddScript.Location;
            stepEntryForm.BringToFront();
            stepEntryForm.Visible = false;
            tabScript.Controls.Add(stepEntryForm);

            aBox = new awaAboutBox();
            aBox.Hide();
            
            webBrowser.ObjectForScripting = this;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);

            dal = new DAL();
            dal.Init(Properties.Settings.Default.awaDB);
            loginForm = new Login(dal);
            DialogResult res = loginForm.ShowDialog(this);
            if (res == DialogResult.Abort)
            {
                Application.Exit();
            }


            scriptBindingSource.DataSource = dal.GetUserScripts(loginForm.UserID).ToList();
            
        }

        void stepEntryForm_Submitted(object sender, EventArgs e)
        {
            TextEntryForm dialog = (TextEntryForm)sender;
            dialog.Controls["panelContainer"].Controls["labelError"].Text = "";
            int script_id = (int)listBoxScripts.SelectedValue;
            dal.AddStep(dialog.Value, script_id, listBoxSteps.SelectedIndex);
            stepBindingSource.DataSource = dal.GetStepsByScriptID(script_id).ToList();
            if (listBoxSteps.SelectedIndex+1 < listBoxSteps.Items.Count)
            {
                listBoxSteps.SelectedIndex++;
            }
        }

        void scriptEntryForm_Submitted(object sender, EventArgs e)
        {
            TextEntryForm dialog = (TextEntryForm)sender;
            foreach (var item in listBoxScripts.Items)
            {
                if (item.ToString() == dialog.Value)
                {
                    dialog.Visible = true;
                    dialog.Controls["panelContainer"].Controls["labelError"].Text = "Script Name Already Exist";
                    return;
                }
            }
            dialog.Controls["panelContainer"].Controls["labelError"].Text = "";
            dal.AddScript(dialog.Value,loginForm.UserID);
            scriptBindingSource.DataSource = dal.GetUserScripts(loginForm.UserID);
        }

        

        

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aBox.IsDisposed)
            {
                aBox = null;
                aBox = new awaAboutBox();
            }
            aBox.Show();
            aBox.Activate();
        }

        private void listBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {

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
            if (!webBrowser.Focused) webBrowser.Focus();
            HtmlElement element = e.ToElement;
            if (!this.elementStyles.ContainsKey(element))
            {
                string style = element.Style;
                this.elementStyles.Add(element, style);
                element.Style = style + "; border-style: solid; border-color: red;";
                statusStrip1.Items[0].Text = "ID:" + (element.Id ?? "(no id)");
                if (e.ToElement.Id == "pswd")
                {

                }
            }
            // prevent opening new window via target="_blank"
            //if ((att.name == "target") && (att.value == "_blank")) att.value = "_self"; 
            if (element.GetAttribute("target") == "_blank") element.SetAttribute("target", "_self");
            currentElement = element;

        }

        void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.Document.MouseOver += new HtmlElementEventHandler(Document_MouseOver);
            webBrowser.Document.MouseLeave += new HtmlElementEventHandler(Document_MouseLeave);
            HtmlWindowCollection frames = webBrowser.Document.Window.Frames;
            foreach (HtmlWindow frame in frames)
            {
                frame.Document.MouseOver += new HtmlElementEventHandler(Document_MouseOver);
                frame.Document.MouseLeave += new HtmlElementEventHandler(Document_MouseLeave);
            }

        }
        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool found;
                var row = dal.GetWebsiteRow(websiteNameTextBox.Text, out found);
                if (found) urlTextBox.Text = row.url;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            if ((!urlTextBox.Text.StartsWith("http://")) &&
                 (!urlTextBox.Text.StartsWith("https://")) &&
                 (!urlTextBox.Text.StartsWith("file://")))
            {
                urlTextBox.Text = "http://" + urlTextBox.Text;
            }
            if ((Uri.IsWellFormedUriString(urlTextBox.Text, UriKind.RelativeOrAbsolute)) || urlTextBox.Text.StartsWith("file://"))
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
                    WebsiteRow = dal.GetWebsiteRow(urlTextBox.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Internal Error:" + exc.Message);
                    Application.Exit();
                }

                // New Website
                if (WebsiteID < 0)
                {
                    if (websiteNameTextBox.Text.Length > 0)
                    {
                        awaDAL.AutoWebAgentDBDataSet.websiteRow row = dal.DB.website.AddwebsiteRow(websiteNameTextBox.Text, urlTextBox.Text);
                    }
                    else
                    {
                        awaDAL.AutoWebAgentDBDataSet.websiteRow row = dal.DB.website.AddwebsiteRow(urlTextBox.Text, urlTextBox.Text);
                    }
                    dal.SaveChanges("website");
                    WebsiteID = dal.GetWebsiteID(urlTextBox.Text);
                    WebsiteRow = dal.GetWebsiteRow(urlTextBox.Text);

                }
                //update website
                else
                {
                    if (websiteNameTextBox.Text.Length > 0)
                    {
                        dal.DB.website.FindByid(WebsiteID).name = websiteNameTextBox.Text;
                    }
                    else
                    {
                        websiteNameTextBox.Text = dal.DB.website.FindByid(WebsiteID).name;
                    }

                }
                updateGrid();

            }
            else
            {
                MessageBox.Show("URL Error");
            }
        }
        private void updateGrid()
        {
            elementsDataGridView.AutoGenerateColumns = true;
            elementsDataGridView.DataSource = dal.CreateElementRecognitionView(WebsiteID);
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
            if (e.KeyCode == Keys.ShiftKey)
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
        /// <summary>
        /// called when double shift-key press is detected
        /// </summary>
        /// <param name="currentElement"></param>
        private void analyzeElement(HtmlElement currentElement)
        {
            string tag = "", type = "";
            elementNameTextBox.Text = "";
            selectedElementListView.Items.Clear();
            List<DAL.RecognitionProperty> props = new List<DAL.RecognitionProperty>();
            WatiN.Core.Native.InternetExplorer.IEElement element = new WatiN.Core.Native.InternetExplorer.IEElement(currentElement.DomElement);
            mshtml.IHTMLDOMNode nd = (mshtml.IHTMLDOMNode)element.AsHtmlElement;
            mshtml.IHTMLAttributeCollection attribs = (mshtml.IHTMLAttributeCollection)nd.attributes;


            if ((currentElement.TagName != null) && (currentElement.TagName.Length > 0))
            {
                props.Add(new DAL.RecognitionProperty("Tag", currentElement.TagName, 20));
                ListViewItem item = selectedElementListView.Items.Add("Tag");
                item.SubItems.Add(currentElement.TagName);
                item.SubItems.Add("20").Tag = 20;
                tag = currentElement.TagName;
            }

            if ((currentElement.OuterText != null) && (currentElement.OuterText.Length > 0))
            {
                props.Add(new DAL.RecognitionProperty("OuterText", currentElement.OuterText, 20));
                ListViewItem item = selectedElementListView.Items.Add("OuterText");
                item.SubItems.Add(currentElement.OuterText);
                item.SubItems.Add("20").Tag = 20;
            }
            // add containing frame property
            if (currentElement.Document.Window.WindowFrameElement != null)
            {
                props.Add(new DAL.RecognitionProperty("FrameContainer", currentElement.Document.Window.WindowFrameElement.Name, 20));
                ListViewItem xitem = selectedElementListView.Items.Add("FrameContainer");
                xitem.SubItems.Add(currentElement.Document.Window.WindowFrameElement.Name);
                xitem.SubItems.Add("20").Tag = 20;
            }
            if ((currentElement.InnerText != null) && (currentElement.InnerText.Length > 0))
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
                    if (string.Compare(att.name, "name", true) == 0)
                    {
                        item.SubItems.Add("50").Tag = 50;
                    }
                    else if (string.Compare(att.name, "id", true) == 0)
                    {
                        item.SubItems.Add("100").Tag = 100;
                    }
                    else if (string.Compare(att.name, "href", true) == 0)
                    {
                        item.SubItems.Add("45").Tag = 45;
                    }
                    else
                    {
                        item.SubItems.Add("10").Tag = 10;
                    }
                    if (string.Compare(att.name, "type", true) == 0)
                    {
                        type = att.value;
                    }

                }

            }
            /**
          * if element has no id/name
          * 1. determined position in parent children by counting the depth of nextSibling loop
          * 2. push count to stack
          * 3. then check if parent have id attribute: if true then push id to stack else if parent=null stop else repeat 1-3 
          * 4. serialize stack content and create a fake attribute: indirectPath => [stack contents] with the format
          *    <id:<id>|<name:<name>> <children indexes seperated by space> 
          */
            if ((currentElement.Name == "") && (currentElement.Id == null))
            {
                //int position = -1;
                StringBuilder stack = new StringBuilder();
                var elm = currentElement;
                do
                {
                    if (elm.Parent != null)
                    {

                        for (var i = 0; i < elm.Parent.Children.Count; i++)
                        {

                            if (elm.Parent.Children[i].Equals(elm))
                            {
                                stack.Insert(0, i.ToString() + " ");
                                break;
                            }
                        }

                        elm = elm.Parent;
                    }
                    else
                    {
                        break;
                    }

                } while ((elm != null) && (elm.Id == null) && (elm.Name == ""));
                if ((elm != null) && (elm.Id != null)) stack.Insert(0, "id:" + elm.Id + " ");
                else
                    if ((elm != null) && (elm.Name != "")) stack.Insert(0, "name:" + elm.Name + " ");
                //MessageBox.Show(stack.ToString().TrimEnd(' '));
                if (stack[0] > '9')
                {
                    props.Add(new DAL.RecognitionProperty("indirectPath", stack.ToString().TrimEnd(' '), 80));
                    ListViewItem item = selectedElementListView.Items.Add("indirectPath");
                    item.SubItems.Add(stack.ToString().TrimEnd(' '));
                    item.SubItems.Add("80").Tag = 80;
                }

            }

            if (string.Compare(tag, "input", true) == 0)
            {
                this.currentElementType = type == "" ? DAL.ElementType.TEXT : DAL.StringToElementType(type);
            }
            else if (string.Compare(tag, "textarea", true) == 0)
            {
                this.currentElementType = DAL.ElementType.AREA;
            }
            else if (string.Compare(tag, "select", true) == 0)
            {
                this.currentElementType = DAL.ElementType.SELECT;
            }
            else
            {
                this.currentElementType = DAL.ElementType.NONE;
            }


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
                MessageBox.Show("Failed to save changes:" + exc.Message);
                Application.Exit();

            }
        }

        void selectedElementListView_SubItemClicked(object sender, SubItemEventArgs e)
        {
            TextBox editBox = new TextBox();
            this.Controls.Add(editBox);
            selectedElementListView.StartEditing(editBox, e.Item, e.SubItem);
        }

        private void saveElementButton_Click(object sender, EventArgs e)
        {
            //int eid = -1;
            if (elementNameTextBox.Text.Length == 0)
            {
                var q = from ListViewItem item in selectedElementListView.Items
                        where (String.Compare("id", item.Text, true) == 0)
                        select item;
                if ((q.Count() > 0))
                {
                    elementNameTextBox.Text = q.ElementAt(0).SubItems[1].Text;
                }
                else
                {
                    q = from ListViewItem item in selectedElementListView.Items
                        where (String.Compare("name", item.Text, true) == 0)
                        select item;
                    if ((q.Count() > 0))
                    {
                        elementNameTextBox.Text = q.ElementAt(0).SubItems[1].Text;
                    }
                    else
                    {
                        MessageBox.Show("No Element Name provided, and no Id/Name attribute found.", "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            List<DAL.RecognitionProperty> elementProperties = new List<DAL.RecognitionProperty>();
            foreach (ListViewItem item in selectedElementListView.Items)
            {

                elementProperties.Add(new DAL.RecognitionProperty(item.SubItems[0].Text, item.SubItems[1].Text, int.Parse(item.SubItems[2].Text)));

            }
            try
            {
                dal.SetElement(WebsiteRow, elementNameTextBox.Text, currentElementType.ToString(), elementProperties);
                updateGrid();
            }
            catch (Exception exc)
            {

                MessageBox.Show("Internal Error:" + exc.Message);
            }

        }

        private void clearSiteButton_Click(object sender, EventArgs e)
        {
            dal.ClearWebsiteData(WebsiteID);
            WebsiteID = -1; // complete the deletion of the website and return to initial state
            updateGrid();
        }

        private void buttonAddScript_Click(object sender, EventArgs e)
        {
            scriptEntryForm.Visible = true;
            scriptEntryForm.Clear();
            scriptEntryForm.BringToFront();
        }

        private void buttonRemoveScript_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this,"Are you sure?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if (result== DialogResult.Yes)
            {
                dal.DeleteScript((int)listBoxScripts.SelectedValue);
                scriptBindingSource.DataSource = dal.GetUserScripts(loginForm.UserID);
                stepBindingSource.DataSource = dal.GetStepsByScriptID((int)listBoxScripts.SelectedValue);
            }
        }

        private void buttonAddStep_Click(object sender, EventArgs e)
        {
            stepEntryForm.Visible = true;
            stepEntryForm.Clear();
            stepEntryForm.BringToFront();
        }

        private void buttonRemoveStep_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                dal.DeleteStep((int)listBoxSteps.SelectedValue);
                stepBindingSource.DataSource = dal.GetStepsByScriptID((int)listBoxScripts.SelectedValue);
            }
        }

        private void listBoxScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listBoxScripts.SelectedValue != null) && ((int)listBoxScripts.SelectedValue) > -1)
            {
                stepBindingSource.DataSource = dal.GetStepsByScriptID((int)listBoxScripts.SelectedValue);
                if (listBoxSteps.Items.Count>0)
                {
                    listBoxSteps.SetSelected(0, true);
                }
                
            }
            
        }

        private void buttonStepUp_Click(object sender, EventArgs e)
        {
            if (listBoxSteps.SelectedIndex == 0)
            {
                return;
            }
            if ((listBoxSteps.SelectedValue != null) && ((int)listBoxSteps.SelectedValue) > -1)
            {
                dal.MoveStepUp((int)listBoxSteps.SelectedValue);
                stepBindingSource.DataSource = dal.GetStepsByScriptID((int)listBoxScripts.SelectedValue);
                listBoxSteps.SelectedIndex--;
            }
            

            
        }

        private void buttonStepDown_Click(object sender, EventArgs e)
        {
            if (listBoxSteps.SelectedIndex == listBoxSteps.Items.Count-1)
            {
                return;
            }
            if ((listBoxSteps.SelectedValue != null) && ((int)listBoxSteps.SelectedValue) > -1)
            {
                dal.MoveStepDown((int)listBoxSteps.SelectedValue);
                stepBindingSource.DataSource = dal.GetStepsByScriptID((int)listBoxScripts.SelectedValue);
                listBoxSteps.SelectedIndex++;
            }
        }

        private void listBoxSteps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSteps.SelectedItem is AutoWebAgentDBDataSet.stepRow)
            {
                textBoxStepName.Text = (listBoxSteps.SelectedItem as AutoWebAgentDBDataSet.stepRow).name;
            }
            

        }
    }
}
;