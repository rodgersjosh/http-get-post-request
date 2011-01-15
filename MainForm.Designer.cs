namespace HTTPRequest
{
    partial class MainForm
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.querystringtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.responseBox = new System.Windows.Forms.TextBox();
            this.jsonCheckbox = new System.Windows.Forms.CheckBox();
            this.postRadio = new System.Windows.Forms.RadioButton();
            this.getRadio = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.urlTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.urlTextBox.Location = new System.Drawing.Point(78, 31);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(740, 20);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // querystringtextbox
            // 
            this.querystringtextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.querystringtextbox.Enabled = false;
            this.querystringtextbox.Location = new System.Drawing.Point(78, 117);
            this.querystringtextbox.Name = "querystringtextbox";
            this.querystringtextbox.Size = new System.Drawing.Size(740, 20);
            this.querystringtextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Post Data:";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(78, 157);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(94, 30);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type";
            // 
            // responseBox
            // 
            this.responseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.responseBox.Location = new System.Drawing.Point(12, 201);
            this.responseBox.Multiline = true;
            this.responseBox.Name = "responseBox";
            this.responseBox.ReadOnly = true;
            this.responseBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseBox.Size = new System.Drawing.Size(806, 272);
            this.responseBox.TabIndex = 7;
            // 
            // jsonCheckbox
            // 
            this.jsonCheckbox.AutoSize = true;
            this.jsonCheckbox.Location = new System.Drawing.Point(15, 165);
            this.jsonCheckbox.Name = "jsonCheckbox";
            this.jsonCheckbox.Size = new System.Drawing.Size(54, 17);
            this.jsonCheckbox.TabIndex = 8;
            this.jsonCheckbox.Text = "Json?";
            this.jsonCheckbox.UseVisualStyleBackColor = true;
            // 
            // postRadio
            // 
            this.postRadio.AutoSize = true;
            this.postRadio.Location = new System.Drawing.Point(133, 71);
            this.postRadio.Name = "postRadio";
            this.postRadio.Size = new System.Drawing.Size(54, 17);
            this.postRadio.TabIndex = 9;
            this.postRadio.Text = "POST";
            this.postRadio.UseVisualStyleBackColor = true;
            this.postRadio.CheckedChanged += new System.EventHandler(this.RadioButtons_Changed);
            // 
            // getRadio
            // 
            this.getRadio.AutoSize = true;
            this.getRadio.Checked = true;
            this.getRadio.Location = new System.Drawing.Point(78, 71);
            this.getRadio.Name = "getRadio";
            this.getRadio.Size = new System.Drawing.Size(47, 17);
            this.getRadio.TabIndex = 10;
            this.getRadio.TabStop = true;
            this.getRadio.Text = "GET";
            this.getRadio.UseVisualStyleBackColor = true;
            this.getRadio.CheckedChanged += new System.EventHandler(this.RadioButtons_Changed);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "&History";
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clearHistoryToolStripMenuItem.Text = "&Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 485);
            this.Controls.Add(this.getRadio);
            this.Controls.Add(this.postRadio);
            this.Controls.Add(this.jsonCheckbox);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.querystringtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "GET or POSTer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox querystringtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox responseBox;
        private System.Windows.Forms.CheckBox jsonCheckbox;
        private System.Windows.Forms.RadioButton postRadio;
        private System.Windows.Forms.RadioButton getRadio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
    }
}

