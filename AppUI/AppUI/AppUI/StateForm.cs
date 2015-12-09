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
    public partial class StateForm : Form
    {
        private AppUIMainA m_parentWnd;
        public StateForm(AppUIMainA pWnd)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            m_parentWnd = pWnd;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            string strContext = this.textState.Text;
            string strTest = strContext.Trim();

            if(strTest.Length != 0)
            {
                m_parentWnd.addStateRecord(strContext);
                this.Close();
                m_parentWnd.Show();
            }
            else
            {
               MessageBox.Show(this,"Please input something!","Warning");
            }
        }

        private void StateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            m_parentWnd.Show();
        }
    }
}
