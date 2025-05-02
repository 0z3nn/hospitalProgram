using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalProgram
{
    public partial class SetingsPatient : UserControl
    {
        private int userId;
        private PatientForm patientForm;
        public SetingsPatient(PatientForm form1, int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.patientForm = form1;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
           ManagePatientProfile mpp = new ManagePatientProfile(userId);
            patientForm.panelMain.Controls.Clear();
            patientForm.panelMain.Controls.Add(mpp);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ManageAccountPatient map = new ManageAccountPatient(userId);
            patientForm.panelMain.Controls.Clear();
            patientForm.panelMain.Controls.Add(map);
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ManageAppointment ma = new ManageAppointment(userId);
            patientForm.panelMain.Controls.Clear();
            patientForm.panelMain.Controls.Add(ma);
        }
    }
}
