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

//ignore this. Just trying to see if code have changes
namespace HospitalProgram
{
    public partial class DoctorForm : Form
    {
        private int userId;
        string connectionString = @"Data Source=DESKTOP-K0TECHD\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public DoctorForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
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

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            DoctorDashboard dash = new DoctorDashboard(userId);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dash);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name FROM Doctors WHERE userid = @userid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userid", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["name"].ToString();
                        }
                    }
                }
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DoctorDashboard dash = new DoctorDashboard(userId);
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dash);
        }
    }
}
 