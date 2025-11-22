namespace To_Do_List
{
    partial class DoctorSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorSession));
            this.panel1 = new System.Windows.Forms.Panel();
            this.doctor_logout = new System.Windows.Forms.Button();
            this.doctor_appointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvdoctor = new System.Windows.Forms.DataGridView();
            this.SessionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.doctor_logout);
            this.panel1.Controls.Add(this.doctor_appointment);
            this.panel1.Location = new System.Drawing.Point(-7, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 812);
            this.panel1.TabIndex = 4;
            // 
            // doctor_logout
            // 
            this.doctor_logout.BackColor = System.Drawing.SystemColors.Highlight;
            this.doctor_logout.FlatAppearance.BorderSize = 0;
            this.doctor_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctor_logout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_logout.ForeColor = System.Drawing.Color.White;
            this.doctor_logout.Location = new System.Drawing.Point(13, 150);
            this.doctor_logout.Name = "doctor_logout";
            this.doctor_logout.Size = new System.Drawing.Size(230, 61);
            this.doctor_logout.TabIndex = 1;
            this.doctor_logout.Text = "Logout";
            this.doctor_logout.UseVisualStyleBackColor = false;
            // 
            // doctor_appointment
            // 
            this.doctor_appointment.BackColor = System.Drawing.SystemColors.Highlight;
            this.doctor_appointment.FlatAppearance.BorderSize = 0;
            this.doctor_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctor_appointment.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_appointment.ForeColor = System.Drawing.Color.Yellow;
            this.doctor_appointment.Location = new System.Drawing.Point(13, 73);
            this.doctor_appointment.Name = "doctor_appointment";
            this.doctor_appointment.Size = new System.Drawing.Size(233, 49);
            this.doctor_appointment.TabIndex = 0;
            this.doctor_appointment.Text = "Doctor Appointments";
            this.doctor_appointment.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(278, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor\'s Appointments List";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(279, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(607, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "This page display all appointments assigned to you";
            // 
            // dgvdoctor
            // 
            this.dgvdoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SessionDate,
            this.DurationMinutes,
            this.Price,
            this.Notes});
            this.dgvdoctor.Location = new System.Drawing.Point(312, 235);
            this.dgvdoctor.Name = "dgvdoctor";
            this.dgvdoctor.RowHeadersWidth = 51;
            this.dgvdoctor.RowTemplate.Height = 26;
            this.dgvdoctor.Size = new System.Drawing.Size(636, 239);
            this.dgvdoctor.TabIndex = 6;
            this.dgvdoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoctor_CellContentClick);
            // 
            // SessionDate
            // 
            this.SessionDate.HeaderText = "SessionDate";
            this.SessionDate.MinimumWidth = 6;
            this.SessionDate.Name = "SessionDate";
            this.SessionDate.Width = 125;
            // 
            // DurationMinutes
            // 
            this.DurationMinutes.HeaderText = "DurationMinutes";
            this.DurationMinutes.MinimumWidth = 6;
            this.DurationMinutes.Name = "DurationMinutes";
            this.DurationMinutes.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.Width = 125;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Image = global::To_Do_List.Properties.Resources.Doctors;
            this.pictureBox2.Location = new System.Drawing.Point(452, 507);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 267);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DoctorSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1083, 1055);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvdoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoctorSession";
            this.Text = "DoctorSession";
            this.Load += new System.EventHandler(this.DoctorSession_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doctor_appointment;
        private System.Windows.Forms.Button doctor_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvdoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}