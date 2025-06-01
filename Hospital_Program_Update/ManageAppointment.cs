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
    public partial class ManageAppointment : UserControl
    {
        private int userId;
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public ManageAppointment(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ManageAppointment_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            string query = @"
        SELECT a.appointment_id, a.appointment_date, d.name AS doctor_name, a.symptoms, a.status
        FROM Appointments a
        JOIN Doctors d ON a.doctorid = d.userid
        WHERE a.patientid = @userId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["appointment_id"].Value);
                DateTime appointmentDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["appointment_date"].Value);
                string symptoms = dataGridView1.CurrentRow.Cells["symptoms"].Value.ToString();
                string status = dataGridView1.CurrentRow.Cells["status"].Value.ToString();

                int doctorId = 0;

                if (new[] { "Chest Pain", "Shortness of Breath", "Palpitations", "High Blood Pressure", "Coughing", "Dizziness or Fainting" }.Contains(symptoms))
                {
                    doctorId = 1;
                }
                else if (new[] { "Headaches", "Seizures", "Speech Difficulties", "Numbness or Tingling" }.Contains(symptoms))
                {
                    doctorId = 2;
                }
                else if (new[] { "Fever", "Rashes", "Diarrhea", "Abdominal Pain", "Lack of Appetite" }.Contains(symptoms))
                {
                    doctorId = 3;
                }

                string query = @"
            UPDATE Appointments
            SET appointment_date = @date,
                symptoms = @symptoms,
                status = @status,
                doctorid = @doctorId
            WHERE appointment_id = @id AND patientid = @userId";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@date", appointmentDate);
                    cmd.Parameters.AddWithValue("@symptoms", symptoms);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);
                    cmd.Parameters.AddWithValue("@id", appointmentId);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment updated with correct doctor.");
                LoadAppointments();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int appointmentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["appointment_id"].Value);

                string query = @"
            UPDATE Appointments
            SET status = 'Cancelled'
            WHERE appointment_id = @id AND patientid = @userId";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", appointmentId);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                LoadAppointments();
                MessageBox.Show("Appointment cancelled.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
