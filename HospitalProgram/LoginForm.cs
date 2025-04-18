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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            string user = txtUser.Text;
            string pass = txtPass.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user == "doctor" && pass == "doctor123")
            {
                this.Hide();
                new DoctorForm().Show();
            }
            else if (user == "" && pass == "")
            {
                labelInvalid.Text = "Input your Username and Password!";
                labelInvalid.Visible = true;
            }
            else
            {
                labelInvalid.Text = "Invalid Username or Password!";
                labelInvalid.Visible = true;
            }
                
        }
    }
}
