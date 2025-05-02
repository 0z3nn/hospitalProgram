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
    public partial class ViewPatientInformation : UserControl
    {
        private int patientId;
        string connectionString = @"Data Source=TOKYODIALECT\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public ViewPatientInformation(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void ViewPatientInformation_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }

        private void LoadInformation()
        {
            string query = @"
        SELECT 
            P.firstname + ' ' + P.lastname AS name,
            P.gender,
            PI.age,
            PI.bloodtype,
            PI.conditions,
            PI.allergies,
            PI.labresults
        FROM Patients P
        LEFT JOIN PatientInformation PI ON P.userid = PI.userid
        WHERE P.userid = @userid";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userid", patientId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblName.Text = reader["name"].ToString();
                    lblGender.Text = reader["gender"].ToString();
                    lblAge.Text = reader["age"]?.ToString();
                    lblBlood.Text = reader["bloodtype"]?.ToString();
                    lblConditions.Text = reader["conditions"]?.ToString();
                    lblAllergies.Text = reader["allergies"]?.ToString();
                    lblLab.Text = reader["labresults"]?.ToString();
                }
            }
        }
    }
}
