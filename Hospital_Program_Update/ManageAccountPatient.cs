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
    public partial class ManageAccountPatient : UserControl
    {
        private int userId;
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public ManageAccountPatient(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            string oldPassword = txtOldPass.Text;
            string newPassword = txtNewPass.Text;
            string confirmPassword = txtConfPass.Text;

            if (!IsOldPasswordValid(userId, oldPassword))
            {
                MessageBox.Show("The old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The new password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UpdatePassword(userId, newPassword))
            {
                MessageBox.Show("Password has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while updating the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsOldPasswordValid(int userId, string oldPassword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT password FROM Users WHERE id = @userid";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid", userId);

                conn.Open();
                string storedPassword = cmd.ExecuteScalar() as string;
                conn.Close();

                return storedPassword == oldPassword;
            }
        }

        private bool UpdatePassword(int userId, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET password = @newpass WHERE id = @userId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@newpass", newPassword);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }
    }
}
