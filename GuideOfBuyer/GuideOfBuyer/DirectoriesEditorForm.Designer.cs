namespace GuideOfBuyer
{
    partial class DirectoriesEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoriesEditorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butReload = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbSpecialization = new System.Windows.Forms.GroupBox();
            this.lvSpec = new System.Windows.Forms.ListView();
            this.chSpecId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSpecName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.butSpecDelete = new System.Windows.Forms.Button();
            this.butSpecEdit = new System.Windows.Forms.Button();
            this.butSpecAdd = new System.Windows.Forms.Button();
            this.gbTypeOfOwnership = new System.Windows.Forms.GroupBox();
            this.lvToo = new System.Windows.Forms.ListView();
            this.chTooId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTooName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.butTooDelete = new System.Windows.Forms.Button();
            this.butTooEdit = new System.Windows.Forms.Button();
            this.butTooAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSpecialization.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbTypeOfOwnership.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butReload);
            this.panel1.Controls.Add(this.butSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 39);
            this.panel1.TabIndex = 0;
            // 
            // butReload
            // 
            this.butReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butReload.Location = new System.Drawing.Point(701, 7);
            this.butReload.Name = "butReload";
            this.butReload.Size = new System.Drawing.Size(75, 23);
            this.butReload.TabIndex = 1;
            this.butReload.Text = "Reload";
            this.butReload.UseVisualStyleBackColor = true;
            this.butReload.Click += new System.EventHandler(this.butReload_Click);
            // 
            // butSave
            // 
            this.butSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSave.Location = new System.Drawing.Point(620, 7);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(75, 23);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbSpecialization);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbTypeOfOwnership);
            this.splitContainer1.Size = new System.Drawing.Size(788, 420);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbSpecialization
            // 
            this.gbSpecialization.Controls.Add(this.lvSpec);
            this.gbSpecialization.Controls.Add(this.panel2);
            this.gbSpecialization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSpecialization.Location = new System.Drawing.Point(0, 0);
            this.gbSpecialization.Name = "gbSpecialization";
            this.gbSpecialization.Size = new System.Drawing.Size(365, 420);
            this.gbSpecialization.TabIndex = 0;
            this.gbSpecialization.TabStop = false;
            this.gbSpecialization.Text = "Specializations";
            // 
            // lvSpec
            // 
            this.lvSpec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSpecId,
            this.chSpecName});
            this.lvSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSpec.FullRowSelect = true;
            this.lvSpec.HideSelection = false;
            this.lvSpec.Location = new System.Drawing.Point(3, 62);
            this.lvSpec.MultiSelect = false;
            this.lvSpec.Name = "lvSpec";
            this.lvSpec.ShowGroups = false;
            this.lvSpec.Size = new System.Drawing.Size(359, 355);
            this.lvSpec.TabIndex = 2;
            this.lvSpec.UseCompatibleStateImageBehavior = false;
            this.lvSpec.View = System.Windows.Forms.View.Details;
            this.lvSpec.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSpec_MouseDoubleClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.butSpecDelete);
            this.panel2.Controls.Add(this.butSpecEdit);
            this.panel2.Controls.Add(this.butSpecAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 46);
            this.panel2.TabIndex = 1;
            // 
            // butSpecDelete
            // 
            this.butSpecDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSpecDelete.Location = new System.Drawing.Point(281, 12);
            this.butSpecDelete.Name = "butSpecDelete";
            this.butSpecDelete.Size = new System.Drawing.Size(75, 23);
            this.butSpecDelete.TabIndex = 2;
            this.butSpecDelete.Text = "Delete";
            this.butSpecDelete.UseVisualStyleBackColor = true;
            this.butSpecDelete.Click += new System.EventHandler(this.butSpecDelete_Click);
            // 
            // butSpecEdit
            // 
            this.butSpecEdit.Location = new System.Drawing.Point(93, 12);
            this.butSpecEdit.Name = "butSpecEdit";
            this.butSpecEdit.Size = new System.Drawing.Size(75, 23);
            this.butSpecEdit.TabIndex = 1;
            this.butSpecEdit.Text = "Edit";
            this.butSpecEdit.UseVisualStyleBackColor = true;
            this.butSpecEdit.Click += new System.EventHandler(this.butSpecEdit_Click);
            // 
            // butSpecAdd
            // 
            this.butSpecAdd.Location = new System.Drawing.Point(12, 12);
            this.butSpecAdd.Name = "butSpecAdd";
            this.butSpecAdd.Size = new System.Drawing.Size(75, 23);
            this.butSpecAdd.TabIndex = 0;
            this.butSpecAdd.Text = "Add";
            this.butSpecAdd.UseVisualStyleBackColor = true;
            this.butSpecAdd.Click += new System.EventHandler(this.butSpecAdd_Click);
            // 
            // gbTypeOfOwnership
            // 
            this.gbTypeOfOwnership.Controls.Add(this.lvToo);
            this.gbTypeOfOwnership.Controls.Add(this.panel3);
            this.gbTypeOfOwnership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTypeOfOwnership.Location = new System.Drawing.Point(0, 0);
            this.gbTypeOfOwnership.Name = "gbTypeOfOwnership";
            this.gbTypeOfOwnership.Size = new System.Drawing.Size(419, 420);
            this.gbTypeOfOwnership.TabIndex = 0;
            this.gbTypeOfOwnership.TabStop = false;
            this.gbTypeOfOwnership.Text = "Type of ownership";
            // 
            // lvToo
            // 
            this.lvToo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTooId,
            this.chTooName});
            this.lvToo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvToo.FullRowSelect = true;
            this.lvToo.HideSelection = false;
            this.lvToo.Location = new System.Drawing.Point(3, 62);
            this.lvToo.MultiSelect = false;
            this.lvToo.Name = "lvToo";
            this.lvToo.ShowGroups = false;
            this.lvToo.Size = new System.Drawing.Size(413, 355);
            this.lvToo.TabIndex = 3;
            this.lvToo.UseCompatibleStateImageBehavior = false;
            this.lvToo.View = System.Windows.Forms.View.Details;
            this.lvToo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvToo_MouseDoubleClick);
            // 
            // chTooId
            // 
            this.chTooId.Text = "Id";
            // 
            // chTooName
            // 
            this.chTooName.Text = "Name";
            this.chTooName.Width = 327;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butTooDelete);
            this.panel3.Controls.Add(this.butTooEdit);
            this.panel3.Controls.Add(this.butTooAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 46);
            this.panel3.TabIndex = 1;
            // 
            // butTooDelete
            // 
            this.butTooDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butTooDelete.Location = new System.Drawing.Point(335, 12);
            this.butTooDelete.Name = "butTooDelete";
            this.butTooDelete.Size = new System.Drawing.Size(75, 23);
            this.butTooDelete.TabIndex = 5;
            this.butTooDelete.Text = "Delete";
            this.butTooDelete.UseVisualStyleBackColor = true;
            this.butTooDelete.Click += new System.EventHandler(this.butTooDelete_Click);
            // 
            // butTooEdit
            // 
            this.butTooEdit.Location = new System.Drawing.Point(93, 12);
            this.butTooEdit.Name = "butTooEdit";
            this.butTooEdit.Size = new System.Drawing.Size(75, 23);
            this.butTooEdit.TabIndex = 4;
            this.butTooEdit.Text = "Edit";
            this.butTooEdit.UseVisualStyleBackColor = true;
            this.butTooEdit.Click += new System.EventHandler(this.butTooEdit_Click);
            // 
            // butTooAdd
            // 
            this.butTooAdd.Location = new System.Drawing.Point(12, 12);
            this.butTooAdd.Name = "butTooAdd";
            this.butTooAdd.Size = new System.Drawing.Size(75, 23);
            this.butTooAdd.TabIndex = 3;
            this.butTooAdd.Text = "Add";
            this.butTooAdd.UseVisualStyleBackColor = true;
            this.butTooAdd.Click += new System.EventHandler(this.butTooAdd_Click);
            // 
            // DirectoriesEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 459);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DirectoriesEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Directories";
            this.Shown += new System.EventHandler(this.DirectoriesEditorForm_Shown);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSpecialization.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbTypeOfOwnership.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button butReload;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.GroupBox gbSpecialization;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butSpecDelete;
        private System.Windows.Forms.Button butSpecEdit;
        private System.Windows.Forms.Button butSpecAdd;
        private System.Windows.Forms.GroupBox gbTypeOfOwnership;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butTooDelete;
        private System.Windows.Forms.Button butTooEdit;
        private System.Windows.Forms.Button butTooAdd;
        private System.Windows.Forms.ListView lvSpec;
        private System.Windows.Forms.ListView lvToo;
        private System.Windows.Forms.ColumnHeader chSpecId;
        private System.Windows.Forms.ColumnHeader chSpecName;
        private System.Windows.Forms.ColumnHeader chTooId;
        private System.Windows.Forms.ColumnHeader chTooName;
    }
}