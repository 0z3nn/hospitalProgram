using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProgram
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelPatients.Visible = false;
            panelRecords.Visible = false;
            panelDashboard.Visible = true;
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            panelRecords.Visible = false;
            panelDashboard.Visible = false;
            panelPatients.Visible = true;
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            panelPatients.Visible = false;
            panelDashboard.Visible = false;
            panelRecords.Visible = true;
        }
    }
}
