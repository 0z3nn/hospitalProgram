namespace HospitalProgram
{
    partial class DoctorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.btnManage);
            this.panel1.Controls.Add(this.btnPatients);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 576);
            this.panel1.TabIndex = 0;
            // 
            // btnManage
            // 
            this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Location = new System.Drawing.Point(2, 342);
            this.btnManage.Margin = new System.Windows.Forms.Padding(2);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(156, 90);
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "MANAGE YOUR APPOINTMENTS";
            this.btnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPatients.FlatAppearance.BorderSize = 0;
            this.btnPatients.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatients.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatients.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.Location = new System.Drawing.Point(2, 218);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(156, 90);
            this.btnPatients.TabIndex = 4;
            this.btnPatients.Text = "PATIENTS";
            this.btnPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(28, 517);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 23);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SIGN OUT";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(2, 94);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(156, 90);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Bahnschrift", 8F, System.Drawing.FontStyle.Bold);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(12, 29);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(25, 13);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "null";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Location = new System.Drawing.Point(158, -2);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(963, 564);
            this.panelMain.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(853, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1054, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 559);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPatients;
        public System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManage;
    }
}