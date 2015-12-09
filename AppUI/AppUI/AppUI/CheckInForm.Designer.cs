namespace AppUI
{
    partial class CheckInForm
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
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.listBoxLocation = new System.Windows.Forms.ListBox();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelHead.Controls.Add(this.btnShare);
            this.panelHead.Controls.Add(this.btnCancel);
            this.panelHead.Controls.Add(this.lblTitle);
            this.panelHead.Location = new System.Drawing.Point(4, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(334, 50);
            this.panelHead.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(87, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Check In";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(8, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnShare
            // 
            this.btnShare.Location = new System.Drawing.Point(269, 12);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(52, 23);
            this.btnShare.TabIndex = 2;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // textBoxContext
            // 
            this.textBoxContext.Location = new System.Drawing.Point(3, 57);
            this.textBoxContext.Multiline = true;
            this.textBoxContext.Name = "textBoxContext";
            this.textBoxContext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContext.Size = new System.Drawing.Size(334, 68);
            this.textBoxContext.TabIndex = 1;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Image = global::AppUI.Properties.Resources._003;
            this.pictureBoxMap.Location = new System.Drawing.Point(4, 131);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(333, 241);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMap.TabIndex = 2;
            this.pictureBoxMap.TabStop = false;
            // 
            // listBoxLocation
            // 
            this.listBoxLocation.FormattingEnabled = true;
            this.listBoxLocation.ItemHeight = 12;
            this.listBoxLocation.Items.AddRange(new object[] {
            "Egington Ave",
            "Wilson Ave",
            "Allen Rd",
            "YORKDALE",
            "BEDFORD PARK",
            "NORTH TORONTO",
            "YORK",
            "Black Creek Dr",
            "MAPLE LEAF",
            "THORNCLIDDE PARK",
            "Dupont St",
            "Bloor St W",
            "Annette St",
            "Caledonia Rd",
            "Keele St",
            "Dufferin St",
            "Yonge St"});
            this.listBoxLocation.Location = new System.Drawing.Point(3, 378);
            this.listBoxLocation.Name = "listBoxLocation";
            this.listBoxLocation.Size = new System.Drawing.Size(333, 136);
            this.listBoxLocation.TabIndex = 3;
            // 
            // CheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 530);
            this.Controls.Add(this.listBoxLocation);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.textBoxContext);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CheckInForm";
            this.Text = "CheckInForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckInForm_FormClosed);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBoxContext;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.ListBox listBoxLocation;
    }
}