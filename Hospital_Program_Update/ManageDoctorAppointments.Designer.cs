namespace HospitalProgram
{
    partial class ManageDoctorAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnRescheduled = new System.Windows.Forms.Button();
            this.btnOnGoing = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 42);
            this.label1.TabIndex = 44;
            this.label1.Text = "MANAGE YOUR APPOINTMENTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(50, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 42);
            this.panel2.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(302, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "YOUR APPOINTMENTS";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(50, 104);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(838, 348);
            this.panel4.TabIndex = 46;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 317);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.Black;
            this.btnCompleted.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnCompleted.FlatAppearance.BorderSize = 5;
            this.btnCompleted.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompleted.ForeColor = System.Drawing.Color.White;
            this.btnCompleted.Location = new System.Drawing.Point(137, 473);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(149, 49);
            this.btnCompleted.TabIndex = 49;
            this.btnCompleted.Text = "COMPLETED";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnRescheduled
            // 
            this.btnRescheduled.BackColor = System.Drawing.Color.Black;
            this.btnRescheduled.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnRescheduled.FlatAppearance.BorderSize = 5;
            this.btnRescheduled.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRescheduled.ForeColor = System.Drawing.Color.White;
            this.btnRescheduled.Location = new System.Drawing.Point(302, 473);
            this.btnRescheduled.Margin = new System.Windows.Forms.Padding(2);
            this.btnRescheduled.Name = "btnRescheduled";
            this.btnRescheduled.Size = new System.Drawing.Size(149, 49);
            this.btnRescheduled.TabIndex = 48;
            this.btnRescheduled.Text = "RE-SCHEDULED";
            this.btnRescheduled.UseVisualStyleBackColor = false;
            this.btnRescheduled.Click += new System.EventHandler(this.btnRescheduled_Click);
            // 
            // btnOnGoing
            // 
            this.btnOnGoing.BackColor = System.Drawing.Color.Black;
            this.btnOnGoing.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnOnGoing.FlatAppearance.BorderSize = 5;
            this.btnOnGoing.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnOnGoing.ForeColor = System.Drawing.Color.White;
            this.btnOnGoing.Location = new System.Drawing.Point(464, 473);
            this.btnOnGoing.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnGoing.Name = "btnOnGoing";
            this.btnOnGoing.Size = new System.Drawing.Size(149, 49);
            this.btnOnGoing.TabIndex = 50;
            this.btnOnGoing.Text = "ON-GOING";
            this.btnOnGoing.UseVisualStyleBackColor = false;
            this.btnOnGoing.Click += new System.EventHandler(this.btnOnGoing_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnRemove.FlatAppearance.BorderSize = 5;
            this.btnRemove.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(633, 473);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 49);
            this.btnRemove.TabIndex = 51;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ManageDoctorAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnOnGoing);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRescheduled);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Name = "ManageDoctorAppointments";
            this.Size = new System.Drawing.Size(920, 538);
            this.Load += new System.EventHandler(this.ManageDoctorAppointments_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnRescheduled;
        private System.Windows.Forms.Button btnOnGoing;
        private System.Windows.Forms.Button btnRemove;
    }
}
