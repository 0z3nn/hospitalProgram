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
    public partial class ManageDoctorAppointments : UserControl
    {
        private int userId;
        string connectionString = @"Data Source=TOKYODIALECT\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public ManageDoctorAppointments(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ManageDoctorAppointments_Load(object sender, EventArgs e)
        {
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

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            DateTime? date = GetSelectedAppointmentDate();
            if (date == null) return;

            string query = "UPDATE Appointments SET status = 'Completed' WHERE doctorid = @doctorId AND appointment_date = @date";
            ExecuteStatusUpdate(query, date.Value);
            MessageBox.Show("Appointment is Completed.");
        }


        private void btnRescheduled_Click(object sender, EventArgs e)
        {
            DateTime? date = GetSelectedAppointmentDate();
            if (date == null) return;

            DateTime newDate = date.Value.AddDays(1);

            string query = "UPDATE Appointments SET status = 'Re-Scheduled', appointment_date = @newDate WHERE doctorid = @doctorId AND appointment_date = @date";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@doctorId", userId);
                cmd.Parameters.AddWithValue("@date", date.Value);
                cmd.Parameters.AddWithValue("@newDate", newDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Appointment is Re-Scheduled.");
            LoadYourAppointments();
        }


        private void btnOnGoing_Click(object sender, EventArgs e)
        {
            DateTime? date = GetSelectedAppointmentDate();
            if (date == null) return;

            string query = "UPDATE Appointments SET status = 'On-Going' WHERE doctorid = @doctorId AND appointment_date = @date";
            ExecuteStatusUpdate(query, date.Value);
            MessageBox.Show("Appointment is On-Going.");
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            DateTime? date = GetSelectedAppointmentDate();
            if (date == null) return;

            string query = "DELETE FROM Appointments WHERE doctorid = @doctorId AND appointment_date = @date";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@doctorId", userId);
                cmd.Parameters.AddWithValue("@date", date.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Appointment is Removed.");
            LoadYourAppointments();
        }

        private void ExecuteStatusUpdate(string query, DateTime appointmentDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@doctorId", userId);
                cmd.Parameters.AddWithValue("@date", appointmentDate);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadYourAppointments();
        }


        private DateTime? GetSelectedAppointmentDate()
        {
            if (dataGridView1.CurrentRow != null)
            {
                object dateValue = dataGridView1.CurrentRow.Cells["DATE"].Value;
                if (dateValue != null && DateTime.TryParse(dateValue.ToString(), out DateTime appointmentDate))
                {
                    return appointmentDate;
                }
            }
            return null;
        }

    }
}
