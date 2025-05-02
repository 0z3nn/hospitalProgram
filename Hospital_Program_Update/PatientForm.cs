using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProgram
{
    public partial class PatientForm : Form
    {
        private int userId;
        string connectionString = @"Data Source=DESKTOP-K0TECHD\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public PatientForm(int useryes)
        {
            InitializeComponent();
            userId = useryes;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            PatientDashboard dash = new PatientDashboard(userId);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dash);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT firstname, lastname FROM Patients WHERE userid = @userid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userid", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["firstname"].ToString() + "\n" + reader["lastname"].ToString();
                        }
                    }
                }
            }

        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PatientDashboard dash = new PatientDashboard(userId);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dash);
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientAppointment app = new PatientAppointment(userId);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(app);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetingsPatient app = new SetingsPatient(this, userId);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(app);
        }
    }
}
