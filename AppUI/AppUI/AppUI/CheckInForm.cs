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
    public partial class CheckInForm : Form
    {
        private AppUIMainA m_parentWnd;

        public CheckInForm(AppUIMainA pWnd)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;

            this.listBoxLocation.SetSelected(0, true);
            m_parentWnd = pWnd;
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
                string strLocation = (string)this.listBoxLocation.SelectedItem;
                m_parentWnd.addCheckInRecord(strContext, strLocation);
                this.Close();
                m_parentWnd.Show();
            }
            else
            {
                MessageBox.Show(this, "Please input something in the text box!", "Warning");
            }
        }
        private void CheckInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }
    }
}
