using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalProgram
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-K0TECHD\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;"; 
        public LoginForm()
        {
            InitializeComponent();
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

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id FROM Users WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@password", pass);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int userId = Convert.ToInt32(result);

                    if (userId == 1 || userId == 2 || userId == 3)
                    {
                        DoctorForm doc = new DoctorForm(userId);
                        doc.Show();
                    }
                    else
                    {
                        PatientForm patient = new PatientForm(userId);
                        PatientAppointment patientAppointment = new PatientAppointment(userId);
                        patient.Show();
                    }

                    this.Hide();
                }
                else
                {
                    labelInvalid.Text = "Invalid username or password";
                }
            }
        }
    }
}
