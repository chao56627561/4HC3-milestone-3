using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppUI
{
    public partial class AppUIMainB : Form
    {
        private Form[] m_fMainForm;
        public List<_tagChatRecord> m_list;
        private int m_insertPos;
        private int m_rawHeight;
        private int m_index = 0;
        private string[] m_picPath = {
            "Wolf@2x.png",
            "Tiger@2x.png",
            "Squirrel@2x.png",
            "Smiley 018@2x.png",
            "skull@2x.png",
            "Sheep@2x.png",
            "pig@2x.png",
            "Panda@2x.png",
            "Lion@2x.png",
            "Leopard@2x.png",
            "horse@2x.png",
            "Gorilla@2x",
            "Fox@2x.png",
            "Dog@2x.png",
            "cow@2x.png",
            "Cheetah@2x.png",
            "Cat@2x.png",
            "Camel@2x.png",
            };
        private int m_picIdx = 0;
        private int m_picCnt = 18;
        private bool m_bFromC = false;

        public AppUIMainB()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            m_insertPos = 0;
            m_rawHeight = panelTableContainer.Height;

            //SetStyle(this.txtSearch, ControlStyles.UserPaint, true);
            //SetStyle(this.txtSearch, ControlStyles.SupportsTransparentBackColor, true);
            //this.txtSearch.BackColor = Color.FromArgb(0, 255, 255, 255);

            initializeData();
            initializePanel();
        }

        public void setMainForm(Form[] forms)
        {
            m_fMainForm = forms;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[0].Show();
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

        private void AppUIMainB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public static bool SetStyle(Control c, ControlStyles Style, bool value)
        {
            bool retval = false;
            Type typeTB = typeof(Control);
            System.Reflection.MethodInfo misSetStyle = typeTB.GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            if (misSetStyle != null && c != null) { misSetStyle.Invoke(c, new object[] { Style, value }); retval = true; }
            return retval;
        }

        private void initializeData()
        {
            m_list = new List<_tagChatRecord>();

            _tagChatRecord tmp;
            tmp = new _tagChatRecord();
            tmp.tag = 0;
            tmp.date = DateTime.Now;
            tmp.picPath = "Camel@2x.png";
            tmp.name = "Bernard Tan";
            tmp.lastMsg = "I'm at home!";
            tmp.panel = null;
            tmp.allContext = new List<_tagChatContexts>();
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "Where are  you?"));
            tmp.allContext.Add(new _tagChatContexts(1, "Bernard Tan", "I'm at home!"));
            m_list.Add(tmp);

            tmp = new _tagChatRecord();
            tmp.tag = 0;
            tmp.date = DateTime.Now;
            tmp.picPath = "Dog@2x.png";
            tmp.name = "Anna Sidorova";
            tmp.lastMsg = "OK";
            tmp.panel = null;
            tmp.allContext = new List<_tagChatContexts>();
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "Where are  you?"));
            tmp.allContext.Add(new _tagChatContexts(1, "Anna Sidorova", "I'm at home!"));
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "OK"));
            m_list.Add(tmp);

            tmp = new _tagChatRecord();
            tmp.tag = 0;
            tmp.date = DateTime.Now;
            tmp.picPath = "cow@2x.png";
            tmp.name = "Detmar Straub";
            tmp.lastMsg = "and you?";
            tmp.panel = null;
            tmp.allContext = new List<_tagChatContexts>();
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "Where are  you?"));
            tmp.allContext.Add(new _tagChatContexts(1, "Detmar Straub", "I'm at home!"));
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "OK"));
            tmp.allContext.Add(new _tagChatContexts(1, "Detmar Straub", "and you?"));
            m_list.Add(tmp);

            tmp = new _tagChatRecord();
            tmp.tag = 0;
            tmp.date = DateTime.Now;
            tmp.picPath = "Cheetah@2x.png";
            tmp.name = "Cheri Speier";
            tmp.lastMsg = "I'm fine,thank you!";
            tmp.panel = null;
            tmp.allContext = new List<_tagChatContexts>();
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "How are  you?"));
            tmp.allContext.Add(new _tagChatContexts(1, "Cheri Speier", "I'm fine,thank you!"));
            m_list.Add(tmp);

            tmp = new _tagChatRecord();
            tmp.tag = 0;
            tmp.date = DateTime.Now;
            tmp.picPath = "Cat@2x.png";
            tmp.name = "Cheri Speier";
            tmp.lastMsg = "I'm fine,thank you!";
            tmp.panel = null;
            tmp.allContext = new List<_tagChatContexts>();
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "How are  you?"));
            tmp.allContext.Add(new _tagChatContexts(1, "Cheri Speier", "I'm fine,thank you!"));
            m_list.Add(tmp);

            tmp = new _tagChatRecord();
            tmp.tag = 1;
            tmp.date = DateTime.Now;
            tmp.picPath = "Mens@2x.png";
            tmp.name = "Sunday's Party";
            tmp.lastMsg = "Haha!";
            tmp.panel = null;
            tmp.allContext = new List<_tagChatContexts>();
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "How are  you?"));
            tmp.allContext.Add(new _tagChatContexts(1, "Detmar Straub", "I'm fine,thank you!"));
            tmp.allContext.Add(new _tagChatContexts(1, "Thelma Truex", "I'm fine,too!"));
            tmp.allContext.Add(new _tagChatContexts(1, "Mary Kate", "Haha!"));
            m_list.Add(tmp);

            tmp = new _tagChatRecord();
            tmp.tag = 1;
            tmp.date = DateTime.Now;
            tmp.picPath = "Mens@2x.png";
            tmp.name = "Film maker";
            tmp.lastMsg = "Yes,yes!!!";
            tmp.panel = null;
            tmp.allContext = new List<_tagChatContexts>();
            tmp.allContext.Add(new _tagChatContexts(1, "Christopher Smith", "Good morning!"));
            tmp.allContext.Add(new _tagChatContexts(1, "Lisa Zhu", "Good morning!"));
            tmp.allContext.Add(new _tagChatContexts(1, "Mary Kate", "fine,thanks!"));
            tmp.allContext.Add(new _tagChatContexts(1, "Mary Kate", "Haha!"));
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "Yes,yes!!!"));
            m_list.Add(tmp);

            tmp = new _tagChatRecord();
            tmp.tag = 1;
            tmp.date = DateTime.Now;
            tmp.picPath = "Mens@2x.png";
            tmp.name = "Voodoo";
            tmp.lastMsg = "chaos,chos,chos!!!";
            tmp.panel = null;
            tmp.allContext = new List<_tagChatContexts>();
            tmp.allContext.Add(new _tagChatContexts(1, "Elizabeth Wieland", "Good morning!"));
            tmp.allContext.Add(new _tagChatContexts(1, "Dana Jones", "Good morning!"));
            tmp.allContext.Add(new _tagChatContexts(1, "Jennie Triechler", "fine,thanks!"));
            tmp.allContext.Add(new _tagChatContexts(1, "Roxanne Galletta", "Haha!"));
            tmp.allContext.Add(new _tagChatContexts(-1, "Jack Gregory", "chaos,chaos,chaos!!!"));
            m_list.Add(tmp);
        }

        private void initializePanel()
        {
            int width = panelMain.Width;

            for(int i=0;i<m_list.Count;i++)
            {
                update_table_height(50);

                PanelChat tmp = new PanelChat(m_list[i], width);
                m_list[i].panel = tmp;
                tmp.Click += new System.EventHandler(this.panel_Click);
                tmp._index = i;
                panelMain.Controls.Add(tmp);
                tmp.Location = new Point(0, m_insertPos);
                
                m_insertPos += 50;
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            _tagChatRecord rec = ((PanelChat)sender)._record;
            rec.date = DateTime.Now;
            m_index = ((PanelChat)sender)._index;

            if(rec.tag==0)
            {
                ContextForm form = new ContextForm(rec);
                form.m_From_B = (AppUIMainB)m_fMainForm[1];
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                ContextGroupForm form = new ContextGroupForm(rec);
                form.m_From_B = (AppUIMainB)m_fMainForm[1];
                this.Hide();
                form.ShowDialog();
            }
        }

        private void update_table_height(int xDelta)
        {
            int newHeight = m_insertPos + xDelta;

            if (newHeight > this.panelMain.Height)
            {
                this.panelMain.Height = newHeight;
                this.vScrollBar1.Enabled = true;
                this.vScrollBar1.Maximum = newHeight - m_rawHeight;
                this.vScrollBar1.Minimum = 0;
            }
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int xOffset = this.vScrollBar1.Value;

            this.panelMain.Location = new Point(0, -xOffset);
        }

        public void reOrder()
        {
            _tagChatRecord recTmp = m_list[m_index];

            if (recTmp.allContext.Count > 0)
            {
                recTmp.lastMsg = recTmp.allContext[recTmp.allContext.Count - 1].msg;
                ((PanelChat)recTmp.panel).lblMsg.Text = recTmp.lastMsg;
            }

            if (m_index == 0)
                return;
            m_index--;

            while(m_index >= 0)
            {
                Point ptLoc = m_list[m_index].panel.Location;
                ptLoc.Y += 50;
                m_list[m_index].panel.Location = ptLoc;

                m_list[m_index + 1] = m_list[m_index];
                ((PanelChat)m_list[m_index].panel)._index++;
                m_index--;
            }

            m_list[0] = recTmp;
            recTmp.panel.Location = new Point(0, 0);
            ((PanelChat)recTmp.panel)._index = 0;

            m_index = 0;
        }

        private _tagChatRecord findChatRecordWithName(string strName)
        {
            for(int i=0;i < m_list.Count; i++)
            {
                _tagChatRecord tmp = m_list[i];

                if(strName.Equals(tmp.name,StringComparison.InvariantCultureIgnoreCase)==true)
                {
                    m_index = i;
                    return tmp;
                }
            }

            return null;
        }

        public void newChatFormFriend(string strName)
        {
            _tagChatRecord rec = findChatRecordWithName(strName);
            m_bFromC = true;

            if(rec!=null)
            {
                rec.date = DateTime.Now;
                ContextForm form = new ContextForm(rec);
                form.m_From_B = (AppUIMainB)m_fMainForm[1];
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                rec = new _tagChatRecord();
                rec.tag = 0;
                rec.date = DateTime.Now;
                rec.picPath = m_picPath[m_picIdx];
                rec.name = strName;
                rec.lastMsg = " ";
                rec.panel = null;
                rec.allContext = new List<_tagChatContexts>();
                update_table_height(50);
                PanelChat tmp = new PanelChat(rec, panelMain.Width);
                tmp.Click += new EventHandler(this.panel_Click);
                tmp._index = m_list.Count;
                panelMain.Controls.Add(tmp);
                tmp.Location = new Point(0, m_insertPos);
                rec.panel = tmp;
                m_list.Add(rec);
                m_picIdx++;
                m_picIdx = m_picIdx % m_picCnt;
                m_insertPos += 50;

                panel_Click(tmp, null);
            }
        }

        public void newChatFormGroup(string strName)
        {
            _tagChatRecord rec = findChatRecordWithName(strName);
            m_bFromC = true;

            if (rec != null)
            {
                rec.date = DateTime.Now;
                ContextGroupForm form = new ContextGroupForm(rec);
                form.m_From_B = (AppUIMainB)m_fMainForm[1];
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                rec = new _tagChatRecord();
                rec.tag = 1;
                rec.date = DateTime.Now;
                rec.picPath = "Mens@2x.png";
                rec.name = strName;
                rec.lastMsg = " ";
                rec.panel = null;
                rec.allContext = new List<_tagChatContexts>();
                update_table_height(50);
                PanelChat tmp = new PanelChat(rec, panelMain.Width);
                tmp.Click += new EventHandler(this.panel_Click);
                tmp._index = m_list.Count;
                panelMain.Controls.Add(tmp);
                tmp.Location = new Point(0, m_insertPos);
                rec.panel = tmp;
                m_list.Add(rec);
                m_insertPos += 50;

                panel_Click(tmp, null);
            }
        }

        public void doShow()
        {
            if(m_bFromC==true)
            {
                m_bFromC = false;
                this.Hide();
                m_fMainForm[2].Show();
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...") { txtSearch.Text = "";  }
            txtSearch.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") { txtSearch.Text = "Search..."; }
            txtSearch.ForeColor = Color.Gray;
        }
    }

    public class PanelChat : Panel
    {
        public PanelChat(_tagChatRecord rec, int width)
        {
            this.Width = width;
            this.Height = 50;
            this.BorderStyle = BorderStyle.FixedSingle;

            PictureBox picBox = new PictureBox();
            picBox.Image = Image.FromFile(rec.picPath);
            picBox.Width = 50;
            picBox.Height = 50;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.Enabled = false;
            this.Controls.Add(picBox);
            picBox.Location = new Point(0, 0);

            Label lblName = new Label();
            lblName.ForeColor = Color.Cyan;
            lblName.Text = rec.name;
            lblName.Width = width - 50 - 4;
            lblName.Height = 20;
            lblName.Font = new Font("Arial", 12, FontStyle.Bold);
            lblName.Enabled = false;
            this.Controls.Add(lblName);
            lblName.Location = new Point(54, 3);

            lblMsg = new Label();
            lblMsg.ForeColor = Color.Black;
            lblMsg.Text = rec.lastMsg;
            lblMsg.Width = lblName.Width;
            lblMsg.Height = 20;
            lblMsg.Font = new Font("Arial", 12, FontStyle.Italic);
            lblMsg.Enabled = false;
            this.Controls.Add(lblMsg);
            lblMsg.Location = new Point(54, 26);

            _record = rec;
        }

        public _tagChatRecord _record;
        public int _index;
        public Label lblMsg;
    }
}
