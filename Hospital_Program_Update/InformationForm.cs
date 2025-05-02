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
    public partial class InformationForm : Form
    {
        private int userid;
        string connectionString = @"Data Source=DESKTOP-K0TECHD\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";

        public InformationForm(int newuserid)
        {
            InitializeComponent();
            userid = newuserid;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text;
            string lastname = txtLastName.Text;
            string gender = comboGender.SelectedItem?.ToString();
            DateTime dob = dateTimePicker1.Value.Date;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;

            if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname) ||
                string.IsNullOrWhiteSpace(gender) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Patients 
                    (userid, firstname, lastname, gender, dateofbirth, address, phone)
                    VALUES (@userid, @firstname, @lastname, @gender, @dob, @address, @phone)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient information saved successfully!");

                        this.Hide();
                        new LoginForm().Show();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error saving patient information: " + ex.Message);
                    }
                }
            }
        }
    }
}
