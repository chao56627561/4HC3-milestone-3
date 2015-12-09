﻿using System;
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
    public partial class AppUIMainC : Form
    {
        private Form[] m_fMainForm;

        public AppUIMainC()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[1].Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_fMainForm[3].Show();
        }

        private void AppUIMainC_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
