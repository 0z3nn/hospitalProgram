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
    public partial class DoctorPatients : UserControl
    {
        private Panel doctorPanel;
        string connectionString = @"Data Source=TOKYODIALECT\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
        public DoctorPatients(Panel doctorPanel)
        {
            InitializeComponent();
            this.doctorPanel = doctorPanel;
        }

        private void DoctorPatients_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            string query = @"
        SELECT userid as 'PATIENT ID', firstname + lastname as 'NAME', gender as 'GENDER', dateofbirth as 'DOB', address as 'ADDRESS', phone as 'PHONE'
        FROM Patients";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int patientId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PATIENT ID"].Value);
                ViewPatientInformation vpi = new ViewPatientInformation(patientId);
                doctorPanel.Controls.Clear();
                doctorPanel.Controls.Add(vpi);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int patientId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PATIENT ID"].Value);
                EditPatientInformation epi = new EditPatientInformation(patientId);
                doctorPanel.Controls.Clear();
                doctorPanel.Controls.Add(epi);
            }
        }
    }
}
