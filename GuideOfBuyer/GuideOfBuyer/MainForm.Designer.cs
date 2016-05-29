namespace GuideOfBuyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.cbToo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSpect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butEditDirectories = new System.Windows.Forms.Button();
            this.butShowEditor = new System.Windows.Forms.Button();
            this.pnEditor = new System.Windows.Forms.Panel();
            this.butDeleteFirm = new System.Windows.Forms.Button();
            this.butEditFirm = new System.Windows.Forms.Button();
            this.butAddFirm = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvFirms = new System.Windows.Forms.ListView();
            this.chSpecId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpecName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chToo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTimeWork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.cbToo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbSpect);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.butEditDirectories);
            this.panel1.Controls.Add(this.butShowEditor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 47);
            this.panel1.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(528, 14);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(358, 20);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(481, 17);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(41, 13);
            this.lbSearch.TabIndex = 6;
            this.lbSearch.Text = "Search";
            this.lbSearch.Click += new System.EventHandler(this.lbSearch_Click);
            // 
            // cbToo
            // 
            this.cbToo.FormattingEnabled = true;
            this.cbToo.Location = new System.Drawing.Point(315, 14);
            this.cbToo.Name = "cbToo";
            this.cbToo.Size = new System.Drawing.Size(160, 21);
            this.cbToo.TabIndex = 5;
            this.cbToo.SelectedIndexChanged += new System.EventHandler(this.cbFiler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Types";
            // 
            // cbSpect
            // 
            this.cbSpect.FormattingEnabled = true;
            this.cbSpect.Location = new System.Drawing.Point(134, 14);
            this.cbSpect.Name = "cbSpect";
            this.cbSpect.Size = new System.Drawing.Size(134, 21);
            this.cbSpect.TabIndex = 3;
            this.cbSpect.SelectedIndexChanged += new System.EventHandler(this.cbFiler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spec.";
            // 
            // butEditDirectories
            // 
            this.butEditDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butEditDirectories.Location = new System.Drawing.Point(892, 12);
            this.butEditDirectories.Name = "butEditDirectories";
            this.butEditDirectories.Size = new System.Drawing.Size(75, 23);
            this.butEditDirectories.TabIndex = 1;
            this.butEditDirectories.Text = "Directo...";
            this.butEditDirectories.UseVisualStyleBackColor = true;
            this.butEditDirectories.Click += new System.EventHandler(this.butEditDirectories_Click);
            // 
            // butShowEditor
            // 
            this.butShowEditor.Location = new System.Drawing.Point(12, 12);
            this.butShowEditor.Name = "butShowEditor";
            this.butShowEditor.Size = new System.Drawing.Size(75, 23);
            this.butShowEditor.TabIndex = 0;
            this.butShowEditor.Text = "Editor";
            this.butShowEditor.UseVisualStyleBackColor = true;
            this.butShowEditor.Click += new System.EventHandler(this.butShowEditor_Click);
            // 
            // pnEditor
            // 
            this.pnEditor.Controls.Add(this.butDeleteFirm);
            this.pnEditor.Controls.Add(this.butEditFirm);
            this.pnEditor.Controls.Add(this.butAddFirm);
            this.pnEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEditor.Location = new System.Drawing.Point(0, 47);
            this.pnEditor.Name = "pnEditor";
            this.pnEditor.Size = new System.Drawing.Size(979, 37);
            this.pnEditor.TabIndex = 1;
            this.pnEditor.Visible = false;
            // 
            // butDeleteFirm
            // 
            this.butDeleteFirm.Location = new System.Drawing.Point(892, 6);
            this.butDeleteFirm.Name = "butDeleteFirm";
            this.butDeleteFirm.Size = new System.Drawing.Size(75, 23);
            this.butDeleteFirm.TabIndex = 2;
            this.butDeleteFirm.Text = "Delete firm";
            this.butDeleteFirm.UseVisualStyleBackColor = true;
            this.butDeleteFirm.Click += new System.EventHandler(this.butDeleteFirm_Click);
            // 
            // butEditFirm
            // 
            this.butEditFirm.Location = new System.Drawing.Point(96, 6);
            this.butEditFirm.Name = "butEditFirm";
            this.butEditFirm.Size = new System.Drawing.Size(75, 23);
            this.butEditFirm.TabIndex = 1;
            this.butEditFirm.Text = "Edit firm";
            this.butEditFirm.UseVisualStyleBackColor = true;
            this.butEditFirm.Click += new System.EventHandler(this.butEditFirm_Click);
            // 
            // butAddFirm
            // 
            this.butAddFirm.Location = new System.Drawing.Point(12, 6);
            this.butAddFirm.Name = "butAddFirm";
            this.butAddFirm.Size = new System.Drawing.Size(75, 23);
            this.butAddFirm.TabIndex = 0;
            this.butAddFirm.Text = "New firm";
            this.butAddFirm.UseVisualStyleBackColor = true;
            this.butAddFirm.Click += new System.EventHandler(this.butAddFirm_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 84);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvFirms);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(979, 572);
            this.splitContainer1.SplitterDistance = 451;
            this.splitContainer1.TabIndex = 2;
            // 
            // lvFirms
            // 
            this.lvFirms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSpecId,
            this.chSpecName,
            this.chSpec,
            this.chToo,
            this.chTimeWork});
            this.lvFirms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFirms.FullRowSelect = true;
            this.lvFirms.HideSelection = false;
            this.lvFirms.Location = new System.Drawing.Point(0, 0);
            this.lvFirms.MultiSelect = false;
            this.lvFirms.Name = "lvFirms";
            this.lvFirms.ShowGroups = false;
            this.lvFirms.Size = new System.Drawing.Size(979, 451);
            this.lvFirms.TabIndex = 4;
            this.lvFirms.UseCompatibleStateImageBehavior = false;
            this.lvFirms.View = System.Windows.Forms.View.Details;
            this.lvFirms.SelectedIndexChanged += new System.EventHandler(this.lvFirms_SelectedIndexChanged);
            this.lvFirms.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFirms_MouseDoubleClick);
            // 
            // chSpecId
            // 
            this.chSpecId.Text = "Id";
            // 
            // chSpecName
            // 
            this.chSpecName.Text = "Name";
            this.chSpecName.Width = 272;
            // 
            // chSpec
            // 
            this.chSpec.Text = "Specialization";
            // 
            // chToo
            // 
            this.chToo.Text = "Type of ownership";
            this.chToo.Width = 190;
            // 
            // chTimeWork
            // 
            this.chTimeWork.Text = "TimeWork";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(979, 117);
            this.splitContainer2.SplitterDistance = 481;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddress.Location = new System.Drawing.Point(3, 16);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(475, 98);
            this.tbAddress.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPhone);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 117);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phones";
            // 
            // tbPhone
            // 
            this.tbPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhone.Location = new System.Drawing.Point(3, 16);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(488, 98);
            this.tbPhone.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 656);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnEditor);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Guide Of Buyer";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnEditor.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butEditDirectories;
        private System.Windows.Forms.Button butShowEditor;
        private System.Windows.Forms.Panel pnEditor;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.ComboBox cbToo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSpect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDeleteFirm;
        private System.Windows.Forms.Button butEditFirm;
        private System.Windows.Forms.Button butAddFirm;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvFirms;
        private System.Windows.Forms.ColumnHeader chSpecId;
        private System.Windows.Forms.ColumnHeader chSpecName;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ColumnHeader chSpec;
        private System.Windows.Forms.ColumnHeader chToo;
        private System.Windows.Forms.ColumnHeader chTimeWork;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPhone;

    }
}

