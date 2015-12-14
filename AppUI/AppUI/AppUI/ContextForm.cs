using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppUI
{
    public partial class ContextForm : Form
    {
        private _tagChatRecord m_record;
        public AppUIMainB m_From_B;
        private int m_keyboardHeight;
        int m_insertPos = 5;

        public ContextForm(_tagChatRecord record)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            m_record = record;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            m_From_B.reOrder();
            m_From_B.Show();
            m_From_B.doShow();
        }

        private void ContextForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            m_From_B.reOrder();
            m_From_B.Show();
            m_From_B.doShow();
        }

        private void ContextForm_Load(object sender, EventArgs e)
        {
            labelTitle.Text = m_record.name;

            m_keyboardHeight = picBoxKeyboard.Height;
            picBoxKeyboard.Height = 0;
            panelMainCCC.Height += m_keyboardHeight;
            panelMain.Height += m_keyboardHeight;
            vScrollBar1.Height += m_keyboardHeight;

            Point ptLoc = panelToolBar.Location;
            ptLoc.Y += m_keyboardHeight;
            panelToolBar.Location = ptLoc;

            for(int i=0;i<m_record.allContext.Count;i++)
            {
                update_table_height(45);
                PanelExtend tmp = new PanelExtend(m_record.allContext[i],
                    m_record.picPath, panelMain.Width);
                panelMain.Controls.Add(tmp);
                tmp.Location = new Point(0, m_insertPos);
                m_insertPos += 45;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            picBoxKeyboard.Height = 0;
            panelMainCCC.Height += m_keyboardHeight;
            panelMain.Height += m_keyboardHeight;
            vScrollBar1.Height += m_keyboardHeight;

            Point ptLoc = panelToolBar.Location;
            ptLoc.Y += m_keyboardHeight;
            panelToolBar.Location = ptLoc;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            picBoxKeyboard.Height = m_keyboardHeight;
            panelMainCCC.Height -= m_keyboardHeight;
            panelMain.Height -= m_keyboardHeight;
            vScrollBar1.Height -= m_keyboardHeight;

            Point ptLoc = panelToolBar.Location;
            ptLoc.Y -= m_keyboardHeight;
            panelToolBar.Location = ptLoc;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string strMsg = textBox1.Text.Trim();
                if(strMsg.Length > 0)
                {
                    _tagChatContexts tmpContext = new _tagChatContexts(-1, "Jack Gregory",strMsg);
                    update_table_height(45);
                    PanelExtend tmp = new PanelExtend(tmpContext,
                        m_record.picPath, panelMain.Width);
                    panelMain.Controls.Add(tmp);
                    tmp.Location = new Point(0, m_insertPos);
                    m_insertPos += 45;

                    m_record.allContext.Add(tmpContext);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            VideoForm fomr = new VideoForm(this,m_record.name);

            this.Hide();
            fomr.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VoiceChat form = new VoiceChat(this, m_record.name);

            this.Hide();
            form.ShowDialog();
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int xOffset = this.vScrollBar1.Value;

            this.panelMain.Location = new Point(0, -xOffset);
        }

        private void update_table_height(int xDelta)
        {
            int newHeight = m_insertPos + xDelta;

            if (newHeight > this.panelMain.Height)
            {
                this.panelMain.Height = newHeight;
                this.vScrollBar1.Enabled = true;
                this.vScrollBar1.Maximum = newHeight - panelMainCCC.Height;
                this.vScrollBar1.Minimum = 0;
                this.vScrollBar1.Value = vScrollBar1.Maximum;
            }
        }

        private class PanelExtend : Panel
        {
            public _tagChatContexts _record;
            public PanelExtend(_tagChatContexts record,string imgPath,int width)
            {
                _record = record;
                this.Width = width;
                this.Height = 40;

                PictureBox picBox = new PictureBox();
                if (record.tag != -1)
                    picBox.Image = Image.FromFile(imgPath);
                else
                    picBox.Image = Image.FromFile("elephant@2x.png");
                picBox.Width = 40;
                picBox.Height = 40;
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(picBox);
                if (record.tag != -1)
                    picBox.Location = new Point(5, 0);
                else
                    picBox.Location = new Point(width - picBox.Width - 5, 5);

                Graphics graphics = CreateGraphics();
                SizeF sizeF = graphics.MeasureString(record.msg, new Font("Arial", 9));
                graphics.Dispose();

                Label lblMsg = new Label();
                lblMsg.Text = record.msg;
                lblMsg.Font = new Font("Arial", 9);
                lblMsg.Width = (int)sizeF.Width + 10;
                lblMsg.Height = 15;
                lblMsg.BackColor = Color.White;
                this.Controls.Add(lblMsg);
                if (record.tag != -1)
                    lblMsg.Location = new Point(50, 10);
                else
                    lblMsg.Location = new Point(picBox.Location.X - 5 - lblMsg.Width, 10);
            }
        }
    }
}
