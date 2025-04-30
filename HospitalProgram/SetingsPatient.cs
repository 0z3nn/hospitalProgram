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
        private PatientForm parentForm;
        public SetingsPatient(PatientForm form, int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.parentForm = form;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
           ManagePatientProfile mpp = new ManagePatientProfile(userId);
            parentForm.panelMain.Controls.Clear();
            parentForm.panelMain.Controls.Add(mpp);
        }
    }
}
