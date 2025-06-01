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
    public partial class PrescriptionHistoryCtrl : UserControl
    {
        public PrescriptionHistoryCtrl()
        {
            InitializeComponent();
            this.Load += PrescriptionHistoryCtrl_Load;
        }

        private void PrescriptionHistoryCtrl_Load(object sender, EventArgs e)
        {
            
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, PatientName, Medication, Dosage, DatePrescribed FROM Prescriptions";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
               // MessageBox.Show($"Rows Loaded: {table.Rows.Count}");
                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void dataGridViewHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Extract data
                string patientName = row.Cells["PatientName"].Value.ToString();
                string medication = row.Cells["Medication"].Value.ToString();
                string dosage = row.Cells["Dosage"].Value.ToString();
                string datePrescribed = row.Cells["DatePrescribed"].Value.ToString();

                // Show full details in a MessageBox or another form
                string details = $"Patient: {patientName}\nMedication: {medication}\nDosage: {dosage}\nDate: {datePrescribed}";
                //MessageBox.Show(details, "Prescription Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create a new instance of the Prescription user control
            PrescriptioncCtrl prescriptionCtrl = new PrescriptioncCtrl();

            // Get the parent form
            Form parentForm = this.FindForm();

            // Get the panel in the parent form where user controls are loaded
            Panel panelMain = parentForm.Controls["panelMain"] as Panel;

            if (panelMain != null)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(prescriptionCtrl);
                prescriptionCtrl.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Main panel not found.");
            }
        }
    }
}
