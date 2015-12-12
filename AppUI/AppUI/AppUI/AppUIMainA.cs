using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI
{
    public partial class AppUIMainA : Form
    {
        public AppUIMainA()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            m_List = new List<_tagRecord>(100);
            m_rawHeight = this.panelTable.Height;
            m_insertPos = 2;

            addSomeUserRecord();

            m_strUserName = "Jack Gregory";

            AppUIMainB form_b = new AppUIMainB();
            AppUIMainC form_c = new AppUIMainC();
            AppUIMainD form_d = new AppUIMainD();

            m_fMainForm = new Form[4];
            m_fMainForm[0] = this;
            m_fMainForm[1] = form_b;
            m_fMainForm[2] = form_c;
            m_fMainForm[3] = form_d;

            form_b.setMainForm(m_fMainForm);
            form_c.setMainForm(m_fMainForm);
            form_d.setMainForm(m_fMainForm);
        }

        public void addStateRecord(string strContext)
        {
            _tagRecord record = new _tagRecord();
            record.nType = 1;
            record.strContext = strContext;
            
            update_table_height(120);

            int width = this.panelTable.Width;
            PanelTypeA type_a = new PanelTypeA(m_strUserName,strContext, width);
            this.panelTable.Controls.Add(type_a);
            type_a.Location = new Point(0, 2);

            m_insertPos = m_insertPos + type_a.Height;
            record.panel = type_a;
            m_List.Add(record);
        }

        public void addStatePhotoRecord(string strContext, string strPhotoPath)
        {
            _tagRecord record = new _tagRecord();
            record.nType = 2;
            record.strContext = strContext;
            record.strPath = strPhotoPath;

            update_table_height(230);

            int width = this.panelTable.Width;
            PanelTypeB type_b = new PanelTypeB(m_strUserName,strContext, strPhotoPath, width);
            this.panelTable.Controls.Add(type_b);
            type_b.Location = new Point(0, 2);

            m_insertPos = m_insertPos + type_b.Height;
            record.panel = type_b;
            m_List.Add(record);
        }

        public void addCheckInRecord(string strContext, string strLocation)
        {
            _tagRecord record = new _tagRecord();
            record.nType = 3;
            record.strContext = strContext;
            record.strPath = strLocation;

            update_table_height(250);

            int width = this.panelTable.Width;
            PanelTypeC type_c = new PanelTypeC(m_strUserName,strContext, strLocation, width);
            this.panelTable.Controls.Add(type_c);
            type_c.Location = new Point(0, 2);

            m_insertPos = m_insertPos + type_c.Height;
            record.panel = type_c;
            m_List.Add(record);
        }
  
        private void btnState_Click(object sender, EventArgs e)
        {
            this.Hide();
            StateForm form = new StateForm(this);
            form.ShowDialog();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhotoForm form = new PhotoForm(this);
            form.ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInForm form = new CheckInForm(this);
            form.ShowDialog();
        }

        private void vScrollBarTable_ValueChanged(object sender, EventArgs e)
        {
            int xOffset = this.vScrollBarTable.Value;

            this.panelTable.Location = new Point(0, -xOffset);
        }

        private List<_tagRecord> m_List;
        private int m_insertPos;
        private int m_rawHeight;
        private string m_strUserName;
        private Form[] m_fMainForm;

        private void addSomeUserRecord()
        {
            m_strUserName = "Bernard Tan";
            addCheckInRecord("I love eating bananas!", "Egington Ave");

            m_strUserName = "Anna Sidorova";
            addStateRecord("To be or not to be?");

            m_strUserName = "Eric Korpics";
            addStateRecord("The film or that film?");

            m_strUserName = "Jennie Triechler";
            addStatePhotoRecord("The beautiful sunshine!", "sunshine.jpg");
        }

        private void update_table_height(int xDelta)
        {
            int newHeight = m_insertPos + xDelta;

            if (newHeight > this.panelTable.Height)
            {
                this.panelTable.Height = newHeight;
                this.vScrollBarTable.Enabled = true;
                this.vScrollBarTable.Maximum = newHeight - m_rawHeight;
                this.vScrollBarTable.Minimum = 0;
            }

            for (int i = 0; i < m_List.Count; i++)
            {
                _tagRecord tmp = m_List[i];
                int oldY = tmp.panel.Location.Y;
                tmp.panel.Location = new Point(0, oldY + xDelta);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[1].Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[2].Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[3].Show();
        }

        private void vScrollBarTable_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }

    public class _tagRecord
    {
        public int nType;
        public string strContext;
        public string strPath;
        public string strLocation;
        public Panel panel;
    }

    public class PanelTypeA : Panel
    {
        public PanelTypeA(string strUser, string strContext,int width)
        {
            this.Width = width;
            this.Height = 120;
            this.BorderStyle = BorderStyle.Fixed3D;

            PictureBox picBox = new PictureBox();
            picBox.Image = Image.FromFile("male@2x.png");
            picBox.Width = 48;
            picBox.Height = 48;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(picBox);
            picBox.Location = new Point(2, 2);

            Label lblName = new Label();
            lblName.ForeColor = Color.Cyan;
            lblName.Text = strUser;
            lblName.Width = width - 50 - 6;
            lblName.Height = 20;
            lblName.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(lblName);
            lblName.Location = new Point(52, 5);

            Label lblDate = new Label();
            lblDate.ForeColor = Color.Black;
            lblDate.Text = DateTime.Now.ToString();
            lblName.Width = width - 50 - 4;
            lblName.Height = 14;
            lblDate.Font = new Font("Arial", 6, FontStyle.Italic);
            this.Controls.Add(lblDate);
            lblDate.Location = new Point(52, 26);

            TextBox txtBox = new TextBox();
            txtBox.Text = strContext;
            txtBox.ScrollBars = ScrollBars.Vertical;
            txtBox.Font = new Font("Arial", 10, FontStyle.Regular);
            txtBox.Width = width-8;
            txtBox.Height = 42;
            txtBox.ReadOnly = true;
            txtBox.Multiline = true;
            this.Controls.Add(txtBox);
            txtBox.Location = new Point(2, 51);

            Random rd = new Random();
            Label lblLike = new Label();
            lblLike.Text = "Like " + (rd.Next(10) + 1);
            lblLike.ForeColor = Color.Blue;
            lblLike.Font = new Font("Arial", 10, FontStyle.Regular);
            lblLike.Width = 60;
            lblLike.Height = 16;
            this.Controls.Add(lblLike);
            lblLike.Location = new Point(10, 99);

            Label lblComment = new Label();
            lblComment.Text = "Comment";
            lblComment.ForeColor = Color.Blue;
            lblComment.Font = new Font("Arial", 10, FontStyle.Regular);
            lblComment.Width = 70;
            lblComment.Height = 16;
            this.Controls.Add(lblComment);
            lblComment.Location = new Point(110, 99);

            Label lblShare = new Label();
            lblShare.Text = "Share";
            lblShare.ForeColor = Color.Blue;
            lblShare.Font = new Font("Arial", 10, FontStyle.Regular);
            lblShare.Width = 60;
            lblShare.Height = 16;
            this.Controls.Add(lblShare);
            lblShare.Location = new Point(230, 99);
        }
    }

    public class PanelTypeB : Panel
    {
        public PanelTypeB(string strUser, string strContext, string strPhotoPath, int width)
        {
            this.Width = width;
            this.Height = 230;
            this.BorderStyle = BorderStyle.Fixed3D;

            PictureBox picBox = new PictureBox();
            picBox.Image = Image.FromFile("male@2x.png");
            picBox.Width = 48;
            picBox.Height = 48;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(picBox);
            picBox.Location = new Point(2, 2);

            Label lblName = new Label();
            lblName.ForeColor = Color.Cyan;
            lblName.Text = strUser;
            lblName.Width = width - 50 - 6;
            lblName.Height = 20;
            lblName.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(lblName);
            lblName.Location = new Point(52, 5);

            Label lblDate = new Label();
            lblDate.ForeColor = Color.Black;
            lblDate.Text = DateTime.Now.ToString();
            lblName.Width = width - 50 - 4;
            lblName.Height = 14;
            lblDate.Font = new Font("Arial", 6, FontStyle.Italic);
            this.Controls.Add(lblDate);
            lblDate.Location = new Point(52, 26);

            TextBox txtBox = new TextBox();
            txtBox.Text = strContext;
            txtBox.ScrollBars = ScrollBars.Vertical;
            txtBox.Font = new Font("Arial", 10, FontStyle.Regular);
            txtBox.Width = width - 8;
            txtBox.Height = 42;
            txtBox.ReadOnly = true;
            txtBox.Multiline = true;
            this.Controls.Add(txtBox);
            txtBox.Location = new Point(2, 51);

            PictureBox picPhoto = new PictureBox();
            picPhoto.Image = Image.FromFile(strPhotoPath);
            picPhoto.Width = width;
            picPhoto.Height = 110;
            picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picPhoto);
            picPhoto.Location = new Point(0, 98);

            Random rd = new Random();
            Label lblLike = new Label();
            lblLike.Text = "Like " +(rd.Next(10) + 1);
            lblLike.ForeColor = Color.Blue;
            lblLike.Font = new Font("Arial", 10, FontStyle.Regular);
            lblLike.Width = 60;
            lblLike.Height = 16;
            this.Controls.Add(lblLike);
            lblLike.Location = new Point(10, 209);

            Label lblComment = new Label();
            lblComment.Text = "Comment";
            lblComment.ForeColor = Color.Blue;
            lblComment.Font = new Font("Arial", 10, FontStyle.Regular);
            lblComment.Width = 70;
            lblComment.Height = 16;
            this.Controls.Add(lblComment);
            lblComment.Location = new Point(110, 209);

            Label lblShare = new Label();
            lblShare.Text = "Share";
            lblShare.ForeColor = Color.Blue;
            lblShare.Font = new Font("Arial", 10, FontStyle.Regular);
            lblShare.Width = 60;
            lblShare.Height = 16;
            this.Controls.Add(lblShare);
            lblShare.Location = new Point(230, 209);
        }
    }

    public class PanelTypeC : Panel
    {
        public PanelTypeC(string strUser, string strContext, string strLocation, int width)
        {
            this.Width = width;
            this.Height = 250;
            this.BorderStyle = BorderStyle.Fixed3D;

            PictureBox picBox = new PictureBox();
            picBox.Image = Image.FromFile("male@2x.png");
            picBox.Width = 48;
            picBox.Height = 48;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(picBox);
            picBox.Location = new Point(2, 2);

            Label lblName = new Label();
            lblName.ForeColor = Color.Cyan;
            lblName.Text = strUser;
            lblName.Width = width - 50 - 6;
            lblName.Height = 20;
            lblName.Font = new Font("Arial", 12, FontStyle.Bold);
            this.Controls.Add(lblName);
            lblName.Location = new Point(52, 5);

            Label lblDate = new Label();
            lblDate.ForeColor = Color.Black;
            lblDate.Text = DateTime.Now.ToString();
            lblName.Width = width - 50 - 4;
            lblName.Height = 14;
            lblDate.Font = new Font("Arial", 6, FontStyle.Italic);
            this.Controls.Add(lblDate);
            lblDate.Location = new Point(52, 26);

            TextBox txtBox = new TextBox();
            txtBox.Text = strContext;
            txtBox.ScrollBars = ScrollBars.Vertical;
            txtBox.Font = new Font("Arial", 10, FontStyle.Regular);
            txtBox.Width = width - 8;
            txtBox.Height = 42;
            txtBox.ReadOnly = true;
            txtBox.Multiline = true;
            this.Controls.Add(txtBox);
            txtBox.Location = new Point(2, 51);

            PictureBox picPhoto = new PictureBox();
            picPhoto.Image = Image.FromFile("map.jpg");
            picPhoto.Width = width;
            picPhoto.Height = 110;
            picPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picPhoto);
            picPhoto.Location = new Point(0, 98);

            Label lblLocation = new Label();
            lblLocation.ForeColor = Color.Orange;
            lblLocation.Text = "Location:  " + strLocation;
            lblLocation.Width = width - 6;
            lblLocation.Height = 20;
            lblLocation.Font = new Font("Arial", 9, FontStyle.Underline);
            this.Controls.Add(lblLocation);
            lblLocation.Location = new Point(2, 210);

            Random rd = new Random();
            Label lblLike = new Label();
            lblLike.Text = "Like " + (rd.Next(10) + 1);
            lblLike.ForeColor = Color.Blue;
            lblLike.Font = new Font("Arial", 10, FontStyle.Regular);
            lblLike.Width = 60;
            lblLike.Height = 16;
            this.Controls.Add(lblLike);
            lblLike.Location = new Point(10, 229);

            Label lblComment = new Label();
            lblComment.Text = "Comment";
            lblComment.ForeColor = Color.Blue;
            lblComment.Font = new Font("Arial", 10, FontStyle.Regular);
            lblComment.Width = 70;
            lblComment.Height = 16;
            this.Controls.Add(lblComment);
            lblComment.Location = new Point(110, 229);

            Label lblShare = new Label();
            lblShare.Text = "Share";
            lblShare.ForeColor = Color.Blue;
            lblShare.Font = new Font("Arial", 10, FontStyle.Regular);
            lblShare.Width = 60;
            lblShare.Height = 16;
            this.Controls.Add(lblShare);
            lblShare.Location = new Point(230, 229);
        }
    }
}
