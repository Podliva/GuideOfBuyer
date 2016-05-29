namespace GuideOfBuyer
{
    partial class DirectoryItemEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryItemEditorForm));
            this.lbCaptionId = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbCaptionName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCaptionId
            // 
            this.lbCaptionId.AutoSize = true;
            this.lbCaptionId.Location = new System.Drawing.Point(13, 29);
            this.lbCaptionId.Name = "lbCaptionId";
            this.lbCaptionId.Size = new System.Drawing.Size(19, 13);
            this.lbCaptionId.TabIndex = 0;
            this.lbCaptionId.Text = "Id:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(38, 29);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(13, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "0";
            // 
            // lbCaptionName
            // 
            this.lbCaptionName.AutoSize = true;
            this.lbCaptionName.Location = new System.Drawing.Point(12, 50);
            this.lbCaptionName.Name = "lbCaptionName";
            this.lbCaptionName.Size = new System.Drawing.Size(38, 13);
            this.lbCaptionName.TabIndex = 2;
            this.lbCaptionName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(58, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(214, 20);
            this.tbName.TabIndex = 3;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // butOk
            // 
            this.butOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butOk.Location = new System.Drawing.Point(116, 97);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(75, 23);
            this.butOk.TabIndex = 4;
            this.butOk.Text = "Ok";
            this.butOk.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Location = new System.Drawing.Point(197, 97);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // DirectoryItemEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbCaptionName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbCaptionId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectoryItemEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DirectoryItemEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCaptionId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbCaptionName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCancel;
    }
}