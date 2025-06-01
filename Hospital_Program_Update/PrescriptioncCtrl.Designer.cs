namespace HospitalProgram
{
    partial class PrescriptioncCtrl
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
            this.comboBoxMeds = new System.Windows.Forms.ComboBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMeds = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtBoxInstruction = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPatient = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.datePrescribedPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMeds
            // 
            this.comboBoxMeds.FormattingEnabled = true;
            this.comboBoxMeds.ItemHeight = 16;
            this.comboBoxMeds.Location = new System.Drawing.Point(79, 375);
            this.comboBoxMeds.Name = "comboBoxMeds";
            this.comboBoxMeds.Size = new System.Drawing.Size(250, 24);
            this.comboBoxMeds.TabIndex = 0;
            this.comboBoxMeds.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeds_SelectedIndexChanged);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Black;
            this.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnADD.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnADD.Location = new System.Drawing.Point(131, 431);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(152, 46);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Brown;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(516, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Selected Medications:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelMeds
            // 
            this.panelMeds.AutoScroll = true;
            this.panelMeds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMeds.Location = new System.Drawing.Point(516, 143);
            this.panelMeds.Name = "panelMeds";
            this.panelMeds.Size = new System.Drawing.Size(385, 129);
            this.panelMeds.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Brown;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(516, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(385, 33);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Instructions:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxInstruction
            // 
            this.txtBoxInstruction.Location = new System.Drawing.Point(516, 327);
            this.txtBoxInstruction.Multiline = true;
            this.txtBoxInstruction.Name = "txtBoxInstruction";
            this.txtBoxInstruction.Size = new System.Drawing.Size(385, 103);
            this.txtBoxInstruction.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(730, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPatient
            // 
            this.txtPatient.Location = new System.Drawing.Point(79, 167);
            this.txtPatient.Name = "txtPatient";
            this.txtPatient.Size = new System.Drawing.Size(250, 22);
            this.txtPatient.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(79, 128);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(93, 33);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "Patient:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(79, 239);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(68, 33);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Date";
            // 
            // datePrescribedPicker
            // 
            this.datePrescribedPicker.Location = new System.Drawing.Point(79, 271);
            this.datePrescribedPicker.Name = "datePrescribedPicker";
            this.datePrescribedPicker.Size = new System.Drawing.Size(250, 22);
            this.datePrescribedPicker.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(303, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "PRESCRIPTIONS";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(79, 336);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 33);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = "MEDICINE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(516, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "HISTORY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrescriptioncCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePrescribedPicker);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtPatient);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBoxInstruction);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panelMeds);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.comboBoxMeds);
            this.Name = "PrescriptioncCtrl";
            this.Size = new System.Drawing.Size(967, 552);
            this.Load += new System.EventHandler(this.PrescriptioncCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMeds;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelMeds;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtBoxInstruction;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPatient;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker datePrescribedPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
    }
}
