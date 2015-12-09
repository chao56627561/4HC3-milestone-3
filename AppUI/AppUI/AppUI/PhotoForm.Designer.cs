namespace AppUI
{
    partial class PhotoForm
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.textBoxContext = new System.Windows.Forms.TextBox();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHead.Controls.Add(this.btnShare);
            this.panelHead.Controls.Add(this.btnCancel);
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Location = new System.Drawing.Point(1, 3);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(336, 54);
            this.panelHead.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(115, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Photo";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(16, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnShare
            // 
            this.btnShare.Location = new System.Drawing.Point(266, 14);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(52, 23);
            this.btnShare.TabIndex = 2;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // textBoxContext
            // 
            this.textBoxContext.Location = new System.Drawing.Point(1, 64);
            this.textBoxContext.Multiline = true;
            this.textBoxContext.Name = "textBoxContext";
            this.textBoxContext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContext.Size = new System.Drawing.Size(336, 98);
            this.textBoxContext.TabIndex = 1;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxShow.Location = new System.Drawing.Point(1, 169);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(336, 187);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShow.TabIndex = 2;
            this.pictureBoxShow.TabStop = false;
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Location = new System.Drawing.Point(23, 368);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(129, 23);
            this.btnSelectPicture.TabIndex = 3;
            this.btnSelectPicture.Text = "Select A Picture";
            this.btnSelectPicture.UseVisualStyleBackColor = true;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(205, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 530);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelectPicture);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.textBoxContext);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PhotoForm";
            this.Text = "PhotoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PhotoForm_FormClosed);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxContext;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Button btnClear;
    }
}