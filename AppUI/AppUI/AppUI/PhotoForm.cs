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
    public partial class PhotoForm : Form
    {
        private AppUIMainA m_parentWnd;
        private bool m_bPhotoSetting;
        private string m_strPhotoPath;

        public PhotoForm(AppUIMainA pWnd)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            m_parentWnd = pWnd;
            m_bPhotoSetting = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            string strContext = this.textBoxContext.Text;
            string strTest = strContext.Trim();

            if (strTest.Length != 0)
            {
                if (m_bPhotoSetting == false)
                    m_parentWnd.addStateRecord(strContext);
                else
                    m_parentWnd.addStatePhotoRecord(strContext, m_strPhotoPath);
                this.Close();
                m_parentWnd.Show();
            }
            else
            {
                MessageBox.Show(this, "Please input something in the text box!", "Warning");
            }
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "jpg file(*.jpg)|*.jpg|png file(*.png)|*.png|gif file(*.gif)|*.gif";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                m_strPhotoPath = dlg.FileName;
                this.pictureBoxShow.Image = Image.FromFile(m_strPhotoPath);
                m_bPhotoSetting = true;
                this.btnClear.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pictureBoxShow.Image = null;
            m_bPhotoSetting = false;
            this.btnClear.Enabled = false;
        }

        private void PhotoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }

    }
}
