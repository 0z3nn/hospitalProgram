namespace HospitalProgram
{
    partial class PatientAppointment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboSymptoms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.doctor = new System.Windows.Forms.Label();
            this.sched = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "MAKE AN APPOINTMENT";
            // 
            // comboSymptoms
            // 
            this.comboSymptoms.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSymptoms.FormattingEnabled = true;
            this.comboSymptoms.Items.AddRange(new object[] {
            "Chest Pain",
            "Shortness of Breath",
            "Palpitations",
            "High Blood Pressure",
            "Coughing",
            "Dizziness or Fainting",
            "Headaches",
            "Seizures",
            "Speech Difficulties",
            "Numbness or Tingling",
            "Fever",
            "Rashes",
            "Diarrhea",
            "Abdominal Pain",
            "Lack of Appetite"});
            this.comboSymptoms.Location = new System.Drawing.Point(303, 159);
            this.comboSymptoms.Margin = new System.Windows.Forms.Padding(2);
            this.comboSymptoms.Name = "comboSymptoms";
            this.comboSymptoms.Size = new System.Drawing.Size(303, 35);
            this.comboSymptoms.TabIndex = 18;
            this.comboSymptoms.SelectedIndexChanged += new System.EventHandler(this.comboSymptoms_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(170, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "SYMPTOMS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(50, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "DATE OF APPOINTMENT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(200, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "DOCTOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(76, 341);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "DOCTOR\'S SCHEDULE:";
            // 
            // datOfAppointment
            // 
            this.datOfAppointment.CalendarFont = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datOfAppointment.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datOfAppointment.Location = new System.Drawing.Point(305, 223);
            this.datOfAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.datOfAppointment.Name = "datOfAppointment";
            this.datOfAppointment.Size = new System.Drawing.Size(303, 33);
            this.datOfAppointment.TabIndex = 24;
            // 
            // doctor
            // 
            this.doctor.AutoSize = true;
            this.doctor.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.doctor.Location = new System.Drawing.Point(296, 286);
            this.doctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(0, 23);
            this.doctor.TabIndex = 25;
            // 
            // sched
            // 
            this.sched.AutoSize = true;
            this.sched.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sched.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sched.Location = new System.Drawing.Point(296, 341);
            this.sched.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sched.Name = "sched";
            this.sched.Size = new System.Drawing.Size(0, 23);
            this.sched.TabIndex = 26;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(300, 415);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(152, 46);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // PatientAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.sched);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.datOfAppointment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSymptoms);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientAppointment";
            this.Size = new System.Drawing.Size(779, 504);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSymptoms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datOfAppointment;
        private System.Windows.Forms.Label doctor;
        private System.Windows.Forms.Label sched;
        private System.Windows.Forms.Button btnDone;
    }
}
