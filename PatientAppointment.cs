using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HospitalProgram
{
    public partial class PatientAppointment : UserControl
    {
        private int userId;
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public PatientAppointment(int userID)
        {
            InitializeComponent();
            userId = userID;
        }



        private void btnDone_Click(object sender, EventArgs e)
        {
            string symptoms = comboSymptoms.SelectedItem?.ToString();
            DateTime appointmentDate = datOfAppointment.Value.Date;

            int doctorId = 0;

            if (symptoms == "Chest Pain" ||
                symptoms == "Shortness of Breath" ||
                symptoms == "Palpitations" ||
                symptoms == "High Blood Pressure" ||
                symptoms == "Coughing" ||
                symptoms == "Dizziness or Fainting")
            {
                doctorId = 1;
            }
            else if (symptoms == "Headaches" ||
                     symptoms == "Seizures" ||
                     symptoms == "Speech Difficulties" ||
                     symptoms == "Numbness or Tingling")
            {
                doctorId = 2;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Appointments (doctorid, patientid, appointment_date, symptoms, status) 
                         VALUES (@doctorid, @patientid, @appointment_date, @symptoms, @status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@doctorid", doctorId);
                    cmd.Parameters.AddWithValue("@patientid", userId);
                    cmd.Parameters.AddWithValue("@appointment_date", appointmentDate);
                    cmd.Parameters.AddWithValue("@symptoms", symptoms);
                    cmd.Parameters.AddWithValue("@status", "Scheduled");

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Appointment scheduled successfully.");
            }
        }

        private void comboSymptoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            String symptoms = comboSymptoms.SelectedItem?.ToString();
            
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT name, startTime, endTime, schedule FROM Doctors Where userid = @userid;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                    if (symptoms == "Chest Pain" ||
                        symptoms == "Shortness of Breath" ||
                        symptoms == "Palpitations" ||
                        symptoms == "High Blood Pressure" ||
                        symptoms == "Coughing" ||
                        symptoms == "Dizziness or Fainting")
                    {
                        cmd.Parameters.AddWithValue("@userid", 1);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                doctor.Text = reader["name"].ToString();
                                sched.Text = reader["startTime"].ToString() + "AM - " + reader["endTime"].ToString() + "PM \n(" + reader["schedule"].ToString() + ")";
                            }
                        }
                    }
                    else if (symptoms == "Headaches" ||
                             symptoms == "Seizures"  ||
                             symptoms == "Speech Difficulties" ||
                             symptoms == "Numbness or Tingling")
                    {
                        cmd.Parameters.AddWithValue("@userid", 2);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                doctor.Text = reader["name"].ToString();
                                sched.Text = reader["startTime"].ToString() + "AM - " + reader["endTime"].ToString() + "PM (" + reader["schedule"].ToString() + ")";
                            }
                        }
                    }
                }
            }
        }
    }
}
