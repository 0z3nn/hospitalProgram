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
    public partial class EditPatientInformation : UserControl
    {
        private int patientId;
        string connectionString = @"Data Source=TOKYODIALECT\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public EditPatientInformation(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
        }

        private void EditPatientInformation_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }

        private void LoadInformation()
        {
            string connectionString = @"Data Source=TOKYODIALECT\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
            string query = @"
        SELECT 
            firstname + ' ' + lastname as name,
            gender
        FROM Patients
        WHERE userid = @userid";

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
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if PatientInformation already exists for this userid
                string checkQuery = "SELECT COUNT(*) FROM PatientInformation WHERE userid = @userid";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@userid", patientId);
                    int count = (int)checkCmd.ExecuteScalar();

                    // Use parameterized fields only if they have input
                    var fields = new List<string>();
                    var cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (!string.IsNullOrWhiteSpace(txtAge.Text))
                    {
                        fields.Add("age = @age");
                        cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    }
                    if (!string.IsNullOrWhiteSpace(txtBlood.Text))
                    {
                        fields.Add("bloodtype = @bloodtype");
                        cmd.Parameters.AddWithValue("@bloodtype", txtBlood.Text);
                    }
                    if (!string.IsNullOrWhiteSpace(txtConditions.Text))
                    {
                        fields.Add("conditions = @conditions");
                        cmd.Parameters.AddWithValue("@conditions", txtConditions.Text);
                    }
                    if (!string.IsNullOrWhiteSpace(txtAllergies.Text))
                    {
                        fields.Add("allergies = @allergies");
                        cmd.Parameters.AddWithValue("@allergies", txtAllergies.Text);
                    }
                    if (!string.IsNullOrWhiteSpace(txtLab.Text))
                    {
                        fields.Add("labresults = @labresults");
                        cmd.Parameters.AddWithValue("@labresults", txtLab.Text);
                    }

                    if (fields.Count == 0)
                    {
                        MessageBox.Show("No changes to update.");
                        return;
                    }

                    if (count > 0)
                    {
                        // Update existing record
                        cmd.CommandText = $"UPDATE PatientInformation SET {string.Join(", ", fields)} WHERE userid = @userid";
                    }
                    else
                    {
                        // Insert new record
                        var insertFields = new List<string>();
                        var insertValues = new List<string>();
                        foreach (SqlParameter param in cmd.Parameters)
                        {
                            insertFields.Add(param.ParameterName.Substring(1)); // remove '@'
                            insertValues.Add(param.ParameterName);
                        }
                        insertFields.Insert(0, "userid");
                        insertValues.Insert(0, "@userid");
                        cmd.CommandText = $"INSERT INTO PatientInformation ({string.Join(", ", insertFields)}) VALUES ({string.Join(", ", insertValues)})";
                    }

                    cmd.Parameters.AddWithValue("@userid", patientId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Patient information saved successfully.");
        }

    }
}
