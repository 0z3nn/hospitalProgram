using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalProgram
{
    public partial class PrescriptioncCtrl : UserControl
    {

        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";

        public PrescriptioncCtrl()
        {
            InitializeComponent();
            this.Load += PrescriptioncCtrl_Load;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)// ignore
        {

        }

        private void PrescriptioncCtrl_Load(object sender, EventArgs e) // ignore
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT NAME Medication FROM Medications";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxMeds.Items.Add(reader.GetString(0));
                    }
                }

                conn.Close();
            }

            
        }

        private void button2_Click(object sender, EventArgs e) //btnSavePrescription
        {
            string patientName = txtPatient.Text;
            DateTime datePrescribed = datePrescribedPicker.Value;

            if (string.IsNullOrWhiteSpace(patientName) || panelMeds.Controls.Count == 0)
            {
                MessageBox.Show("Please enter patient name and add at least one medication.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (Panel medRow in panelMeds.Controls)
                {
                    string medName = medRow.Tag.ToString();
                    string dosage = "";

                    foreach (Control ctrl in medRow.Controls)
                    {
                        if (ctrl is TextBox txt)
                            dosage = txt.Text;
                    }

                    string query = "INSERT INTO Prescriptions (PatientName, Medication, Dosage, DatePrescribed) VALUES (@PatientName, @Medication, @Dosage, @DatePrescribed)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientName", patientName);
                        cmd.Parameters.AddWithValue("@Medication", medName);
                        cmd.Parameters.AddWithValue("@Dosage", dosage);
                        cmd.Parameters.AddWithValue("@DatePrescribed", datePrescribed);

                        cmd.ExecuteNonQuery();
                    }
                }

                conn.Close();
            }

            MessageBox.Show("Prescription saved successfully!");
            panelMeds.Controls.Clear();
            txtBoxInstruction.Controls.Clear();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string medName = comboBoxMeds.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(medName)) return;

            // Check for duplicates
            foreach (Control c in panelMeds.Controls)
            {
                if (c.Tag?.ToString() == medName)
                    return;
            }

            // Create a panel (row) to hold the med info
            Panel medRow = new Panel
            {
                Width = panelMeds.Width - 30,
                Height = 35,
                Tag = medName,
                Margin = new Padding(0, 3, 0, 3)
            };

            // Label for med name
            Label lbl = new Label
            {
                Text = medName,
                Width = 120,
                Top = 8,
                Left = 5
            };

            // TextBox for dosage with placeholder simulation
            TextBox txtDosage = new TextBox
            {
                Width = 100,
                Top = 5,
                Left = 130,
                Text = "e.g. 500mg",
                ForeColor = Color.Gray
            };

            // Placeholder simulation events
            txtDosage.GotFocus += (s, ev) =>
            {
                if (txtDosage.Text == "e.g. 500mg")
                {
                    txtDosage.Text = "";
                    txtDosage.ForeColor = Color.Black;
                }
            };

            txtDosage.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtDosage.Text))
                {
                    txtDosage.Text = "e.g. 500mg";
                    txtDosage.ForeColor = Color.Gray;
                }
            };

            // "X" button to remove row
            Button btnRemove = new Button
            {
                Text = "X",
                Width = 20,
                Height = 25,
                Top = 5,
                Left = 240,
                BackColor = Color.Red,
                ForeColor = Color.White
            };

            btnRemove.Click += (s, ev) =>
            {
                panelMeds.Controls.Remove(medRow);
            };

            // Add controls to medRow panel
            medRow.Controls.Add(lbl);
            medRow.Controls.Add(txtDosage);
            medRow.Controls.Add(btnRemove);

            // Add medRow to main panel
            panelMeds.Controls.Add(medRow);
        }

       

        private void comboBoxMeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // history
        {

            // Create the history user control
            PrescriptionHistoryCtrl phc = new PrescriptionHistoryCtrl();

            // Find the parent form
            Form parentForm = this.FindForm();

            // Find the main panel in that form
            Panel panelMain = parentForm.Controls["panelMain"] as Panel; // Replace with your actual panel name

            if (panelMain != null)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(phc);
                phc.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Main display panel not found.");
            }

        }
    }
}
