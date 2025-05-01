namespace HospitalProgram
{
    partial class SetingsPatient
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 52);
            this.label1.TabIndex = 18;
            this.label1.Text = "SETTINGS";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProfile.FlatAppearance.BorderSize = 5;
            this.btnProfile.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(93, 153);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(917, 53);
            this.btnProfile.TabIndex = 19;
            this.btnProfile.Text = "UPDATE PROFILE";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAccount.FlatAppearance.BorderSize = 5;
            this.btnAccount.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(93, 295);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(917, 53);
            this.btnAccount.TabIndex = 20;
            this.btnAccount.Text = "MANAGE ACCOUNT";
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(93, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(917, 53);
            this.button1.TabIndex = 21;
            this.button1.Text = "MANAGE APPOINTMENTS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SetingsPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.label1);
            this.Name = "SetingsPatient";
            this.Size = new System.Drawing.Size(1226, 620);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button button1;
    }
}
