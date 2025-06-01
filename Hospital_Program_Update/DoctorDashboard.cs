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
    public partial class DoctorDashboard : UserControl
    {
        private int userId;
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public DoctorDashboard(int currentuserID)
        {
            InitializeComponent();
            userId = currentuserID;
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            LoadDoctorInformation();
            LoadYourAppointments();
        }

        private void LoadYourAppointments()
        {
            string query = @"
        SELECT a.appointment_date AS DATE, p.firstname + ' ' + p.lastname AS PATIENT, a.symptoms AS SYMPTOMS, a.status AS STATUS
        FROM Appointments a
        JOIN Patients p ON a.patientid = p.userid
        WHERE a.doctorid = @userId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", userId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void LoadDoctorInformation()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name, specialty, phone, email, startTime, endTime, schedule FROM Doctors WHERE userid = @userid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userid", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblName.Text = reader["name"].ToString();
                            lblSpecialty.Text = reader["specialty"].ToString();
                            lblPhone.Text = reader["phone"].ToString();
                            lblEmail.Text = reader["email"].ToString();
                            lblSched.Text = reader["startTime"].ToString() + "AM - " + reader["endTime"].ToString() + "PM \n(" + reader["schedule"].ToString() + ")";
                        }
                    }
                }
            }
        }
    }
}
