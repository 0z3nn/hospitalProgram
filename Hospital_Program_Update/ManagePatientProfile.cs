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
using System.Xml.Linq;

namespace HospitalProgram
{
    public partial class ManagePatientProfile : UserControl
    {
        private int userId;
        string connectionString = @"Data Source=TOKYODIALECT\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public ManagePatientProfile(int userID)
        {
            InitializeComponent();
            userId = userID;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // Start building the SQL query
            StringBuilder updateQuery = new StringBuilder("UPDATE Patients SET ");
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Conditionally add parameters for each field that has a value

            // First name (only update if there's a value)
            if (!string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                updateQuery.Append("firstname = @firstname, ");
                parameters.Add(new SqlParameter("@firstname", txtFirstName.Text));
            }

            // Last name (only update if there's a value)
            if (!string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                updateQuery.Append("lastname = @lastname, ");
                parameters.Add(new SqlParameter("@lastname", txtLastName.Text));
            }

            // Gender (only update if there's a value)
            if (comboGender.SelectedItem != null && !string.IsNullOrWhiteSpace(comboGender.SelectedItem.ToString()))
            {
                updateQuery.Append("gender = @gender, ");
                parameters.Add(new SqlParameter("@gender", comboGender.SelectedItem.ToString()));
            }

            // Date of birth (only update if there's a value)
            if (dateTimePicker1.Value.Date != DateTime.MinValue)
            {
                updateQuery.Append("dateofbirth = @dob, ");
                parameters.Add(new SqlParameter("@dob", dateTimePicker1.Value.Date));
            }

            // Phone number (only update if there's a value)
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                updateQuery.Append("phone = @phone, ");
                parameters.Add(new SqlParameter("@phone", txtPhone.Text));
            }

            // Address (only update if there's a value)
            if (!string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                updateQuery.Append("address = @address, ");
                parameters.Add(new SqlParameter("@address", txtAddress.Text));
            }

            // If no fields have been added for update, show a warning
            if (parameters.Count == 0)
            {
                MessageBox.Show("No fields have been changed. Please modify at least one field to update.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Remove the trailing comma and space from the query
            updateQuery.Length -= 2;

            // Add WHERE condition (we always update based on the userid)
            updateQuery.Append(" WHERE userid = @userid");
            parameters.Add(new SqlParameter("@userid", userId));

            // Execute the query
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery.ToString(), conn))
                {
                    // Add all parameters to the command
                    cmd.Parameters.AddRange(parameters.ToArray());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patient information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No matching user found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ManagePatientProfile_Load(object sender, EventArgs e)
        {
            LoadPatientInformation();
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
    }
}
