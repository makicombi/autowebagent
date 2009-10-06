namespace WebRecorder
{
    partial class webRecorderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.saveButton = new System.Windows.Forms.Button();
            this.websiteNameTextBox = new System.Windows.Forms.TextBox();
            this.labelWebsiteName = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.selectedElementGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedElementListView = new WebRecorder.ListViewEx();
            this.AttColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.valColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.priorityColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.elementsDataGridView = new System.Windows.Forms.DataGridView();
            this.goButton = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.selectedElementGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.saveButton);
            this.splitContainer1.Panel1.Controls.Add(this.websiteNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.labelWebsiteName);
            this.splitContainer1.Panel1.Controls.Add(this.clearButton);
            this.splitContainer1.Panel1.Controls.Add(this.selectedElementGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.elementsDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.goButton);
            this.splitContainer1.Panel1.Controls.Add(this.urlLabel);
            this.splitContainer1.Panel1.Controls.Add(this.urlTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 740);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1033, 154);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // websiteNameTextBox
            // 
            this.websiteNameTextBox.Location = new System.Drawing.Point(62, 38);
            this.websiteNameTextBox.Name = "websiteNameTextBox";
            this.websiteNameTextBox.Size = new System.Drawing.Size(965, 20);
            this.websiteNameTextBox.TabIndex = 8;
            this.websiteNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelWebsiteName
            // 
            this.labelWebsiteName.AutoSize = true;
            this.labelWebsiteName.Location = new System.Drawing.Point(24, 41);
            this.labelWebsiteName.Name = "labelWebsiteName";
            this.labelWebsiteName.Size = new System.Drawing.Size(35, 13);
            this.labelWebsiteName.TabIndex = 7;
            this.labelWebsiteName.Text = "Name";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(711, 154);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // selectedElementGroupBox
            // 
            this.selectedElementGroupBox.Controls.Add(this.selectedElementListView);
            this.selectedElementGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectedElementGroupBox.Location = new System.Drawing.Point(0, 188);
            this.selectedElementGroupBox.Name = "selectedElementGroupBox";
            this.selectedElementGroupBox.Size = new System.Drawing.Size(1186, 123);
            this.selectedElementGroupBox.TabIndex = 5;
            this.selectedElementGroupBox.TabStop = false;
            this.selectedElementGroupBox.Text = "Selected Element";
            // 
            // selectedElementListView
            // 
            this.selectedElementListView.AllowColumnReorder = true;
            this.selectedElementListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AttColumnHeader,
            this.valColumnHeader,
            this.priorityColumnHeader});
            this.selectedElementListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectedElementListView.DoubleClickActivation = false;
            this.selectedElementListView.GridLines = true;
            this.selectedElementListView.LabelEdit = true;
            this.selectedElementListView.Location = new System.Drawing.Point(3, 16);
            this.selectedElementListView.MultiSelect = false;
            this.selectedElementListView.Name = "selectedElementListView";
            this.selectedElementListView.Size = new System.Drawing.Size(306, 104);
            this.selectedElementListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.selectedElementListView.TabIndex = 0;
            this.selectedElementListView.UseCompatibleStateImageBehavior = false;
            this.selectedElementListView.View = System.Windows.Forms.View.Details;
            this.selectedElementListView.DoubleClickActivation = true;
            this.selectedElementListView.SubItemClicked += new SubItemEventHandler(selectedElementListView_SubItemClicked);
            // 
            // AttColumnHeader
            // 
            this.AttColumnHeader.Text = "Attribute";
            // 
            // valColumnHeader
            // 
            this.valColumnHeader.Text = "Value";
            this.valColumnHeader.Width = 180;
            // 
            // priorityColumnHeader
            // 
            this.priorityColumnHeader.Text = "Priority";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1186, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(129, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // elementsDataGridView
            // 
            this.elementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementsDataGridView.Location = new System.Drawing.Point(62, 64);
            this.elementsDataGridView.Name = "elementsDataGridView";
            this.elementsDataGridView.Size = new System.Drawing.Size(643, 113);
            this.elementsDataGridView.TabIndex = 3;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(1033, 10);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "GO";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(27, 15);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(32, 13);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "URL:";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(62, 12);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(965, 20);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = "www.google.com";
            this.urlTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyUp);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1186, 403);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webBrowser_PreviewKeyDown);
            // 
            // webRecorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 740);
            this.Controls.Add(this.splitContainer1);
            this.Name = "webRecorderForm";
            this.Text = "Web Recorder";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.selectedElementGroupBox.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView elementsDataGridView;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox selectedElementGroupBox;
        private System.Windows.Forms.TextBox websiteNameTextBox;
        private System.Windows.Forms.Label labelWebsiteName;
        private System.Windows.Forms.Button saveButton;
        private ListViewEx selectedElementListView;
        private System.Windows.Forms.ColumnHeader AttColumnHeader;
        private System.Windows.Forms.ColumnHeader valColumnHeader;
        private System.Windows.Forms.ColumnHeader priorityColumnHeader;
    }
}

