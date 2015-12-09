namespace AppUI
{
    partial class AppUIMainA
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHead = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.PicPhoto = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.vScrollBarTable = new System.Windows.Forms.VScrollBar();
            this.panelTableContainer = new System.Windows.Forms.Panel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHead.Controls.Add(this.labelTitle);
            this.panelHead.Controls.Add(this.PicPhoto);
            this.panelHead.Location = new System.Drawing.Point(1, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(328, 68);
            this.panelHead.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(120, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(148, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "News Feed";
            // 
            // PicPhoto
            // 
            this.PicPhoto.ErrorImage = null;
            this.PicPhoto.Image = global::AppUI.Properties.Resources.headPic;
            this.PicPhoto.InitialImage = null;
            this.PicPhoto.Location = new System.Drawing.Point(0, 0);
            this.PicPhoto.Name = "PicPhoto";
            this.PicPhoto.Size = new System.Drawing.Size(78, 68);
            this.PicPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPhoto.TabIndex = 0;
            this.PicPhoto.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.vScrollBarTable);
            this.panelMain.Controls.Add(this.panelTableContainer);
            this.panelMain.Controls.Add(this.btnCheckIn);
            this.panelMain.Controls.Add(this.btnPhoto);
            this.panelMain.Controls.Add(this.btnState);
            this.panelMain.Location = new System.Drawing.Point(1, 71);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(328, 400);
            this.panelMain.TabIndex = 1;
            // 
            // vScrollBarTable
            // 
            this.vScrollBarTable.Enabled = false;
            this.vScrollBarTable.Location = new System.Drawing.Point(308, 33);
            this.vScrollBarTable.Name = "vScrollBarTable";
            this.vScrollBarTable.Size = new System.Drawing.Size(20, 364);
            this.vScrollBarTable.TabIndex = 0;
            this.vScrollBarTable.ValueChanged += new System.EventHandler(this.vScrollBarTable_ValueChanged);
            // 
            // panelTableContainer
            // 
            this.panelTableContainer.Controls.Add(this.panelTable);
            this.panelTableContainer.Location = new System.Drawing.Point(4, 33);
            this.panelTableContainer.Name = "panelTableContainer";
            this.panelTableContainer.Size = new System.Drawing.Size(303, 364);
            this.panelTableContainer.TabIndex = 3;
            // 
            // panelTable
            // 
            this.panelTable.Location = new System.Drawing.Point(3, 4);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(297, 361);
            this.panelTable.TabIndex = 0;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(232, 1);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.Location = new System.Drawing.Point(125, 2);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnPhoto.TabIndex = 1;
            this.btnPhoto.Text = "Photo";
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // btnState
            // 
            this.btnState.Location = new System.Drawing.Point(18, 3);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(75, 23);
            this.btnState.TabIndex = 0;
            this.btnState.Text = "State";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AppUI.Properties.Resources.gear_3x;
            this.pictureBox4.Location = new System.Drawing.Point(268, 475);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppUI.Properties.Resources.spartan_3x;
            this.pictureBox3.Location = new System.Drawing.Point(185, 476);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppUI.Properties.Resources.Speach_Bubble_Dialog_3x;
            this.pictureBox2.Location = new System.Drawing.Point(95, 477);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppUI.Properties.Resources.male_3x;
            this.pictureBox1.Location = new System.Drawing.Point(19, 477);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // AppUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 522);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AppUIMain";
            this.Text = "AppUI";
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.PictureBox PicPhoto;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelTableContainer;
        private System.Windows.Forms.VScrollBar vScrollBarTable;
        private System.Windows.Forms.Panel panelTable;
    }
}

