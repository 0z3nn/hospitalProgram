using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalProgram
{
    public partial class PatientDashboard : UserControl
    {
        private int userId;
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public PatientDashboard(int currentUserId)
        {
            InitializeComponent();
            userId = currentUserId;
        }

        private void LoadPatientInformation()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT firstname, lastname, gender, dateofbirth, address, phone FROM Patients WHERE userid = @userid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userid", userId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullname = reader["firstname"].ToString() + " " + reader["lastname"].ToString();
                            lblName.Text = fullname;
                            lblDOB.Text = Convert.ToDateTime(reader["dateofbirth"]).ToString("MMM dd, yyyy");
                            lblGender.Text = reader["gender"].ToString();
                            lblPhone.Text = reader["phone"].ToString();
                            lblAddress.Text = reader["address"].ToString();
                        }
                    }
                }
            }
        }
        private void PatientDashboard_Load_1(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadPatientInformation();
                LoadAppointments();
            }
        }

        private void LoadAppointments()
        {
            string query = @"
        SELECT a.appointment_date, d.name AS doctor_name, a.symptoms, a.status
        FROM Appointments a
        JOIN Doctors d ON a.doctorid = d.userid";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
    }
}
