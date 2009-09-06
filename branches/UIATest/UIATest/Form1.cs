using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Automation;
using System.Windows.Automation.Text;
using System.Text.RegularExpressions;

namespace UIATest
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string url="http://www.google.com";
            webBrowser1.Navigate(url);
            textBox1.Text = url;
            webBrowser1.ObjectForScripting = this;
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
            
            
        }
        private HtmlDocument document;
        private IDictionary<HtmlElement, string> elementStyles = new Dictionary<HtmlElement, string>();
        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Click += new HtmlElementEventHandler(Document_Click);
            webBrowser1.Document.MouseOver += new HtmlElementEventHandler(Document_MouseOver);
            webBrowser1.Document.MouseLeave += new HtmlElementEventHandler(Document_MouseLeave);

            
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
        }
        
        void Document_MouseOver(object sender, HtmlElementEventArgs e)
        {
            HtmlElement element = e.ToElement;
            if (!this.elementStyles.ContainsKey(element))
            { 
                string style = element.Style;
                this.elementStyles.Add(element, style); 
                //element.Style = style + "; background-color: #ffc;";
                element.Style = style + "; border-style: solid; border-color: red;"; 
                this.Text = element.Id ?? "(no id)"; 
            }

        }

        void Document_Click(object sender, HtmlElementEventArgs e)
        {
            if (e.CtrlKeyPressed)
            {
 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(textBox1.Text);
            
            


            
        }
    }
}
