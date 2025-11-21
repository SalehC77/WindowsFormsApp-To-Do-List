namespace To_Do_List
{
    partial class viewDoctors
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
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.viewActivities_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.viewDoctors_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.logOut_linkLabel = new System.Windows.Forms.LinkLabel();
            this.doctors_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chooseDoctor_label = new System.Windows.Forms.Label();
            this.session_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.makeAppointment_button = new System.Windows.Forms.Button();
            this.duration_comboBox = new System.Windows.Forms.ComboBox();
            this.notes_richTextBox = new System.Windows.Forms.RichTextBox();
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctors_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(67)))), ((int)(((byte)(229)))));
            this.navbarPanel.Controls.Add(this.viewActivities_LinkLabel);
            this.navbarPanel.Controls.Add(this.viewDoctors_LinkLabel);
            this.navbarPanel.Controls.Add(this.logOut_linkLabel);
            this.navbarPanel.Location = new System.Drawing.Point(0, 51);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(154, 407);
            this.navbarPanel.TabIndex = 2;
            // 
            // viewActivities_LinkLabel
            // 
            this.viewActivities_LinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.viewActivities_LinkLabel.AutoSize = true;
            this.viewActivities_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewActivities_LinkLabel.LinkColor = System.Drawing.Color.White;
            this.viewActivities_LinkLabel.Location = new System.Drawing.Point(32, 57);
            this.viewActivities_LinkLabel.Name = "viewActivities_LinkLabel";
            this.viewActivities_LinkLabel.Size = new System.Drawing.Size(91, 17);
            this.viewActivities_LinkLabel.TabIndex = 7;
            this.viewActivities_LinkLabel.TabStop = true;
            this.viewActivities_LinkLabel.Text = "View Activities";
            this.viewActivities_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewActivities_LinkLabel_LinkClicked);
            // 
            // viewDoctors_LinkLabel
            // 
            this.viewDoctors_LinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.viewDoctors_LinkLabel.AutoSize = true;
            this.viewDoctors_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewDoctors_LinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.viewDoctors_LinkLabel.Location = new System.Drawing.Point(33, 18);
            this.viewDoctors_LinkLabel.Name = "viewDoctors_LinkLabel";
            this.viewDoctors_LinkLabel.Size = new System.Drawing.Size(88, 17);
            this.viewDoctors_LinkLabel.TabIndex = 5;
            this.viewDoctors_LinkLabel.TabStop = true;
            this.viewDoctors_LinkLabel.Text = "View Doctors";
            // 
            // logOut_linkLabel
            // 
            this.logOut_linkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.logOut_linkLabel.AutoSize = true;
            this.logOut_linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logOut_linkLabel.LinkColor = System.Drawing.Color.White;
            this.logOut_linkLabel.Location = new System.Drawing.Point(48, 96);
            this.logOut_linkLabel.Name = "logOut_linkLabel";
            this.logOut_linkLabel.Size = new System.Drawing.Size(58, 17);
            this.logOut_linkLabel.TabIndex = 6;
            this.logOut_linkLabel.TabStop = true;
            this.logOut_linkLabel.Text = "Log Out";
            this.logOut_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOut_linkLabel_LinkClicked);
            // 
            // doctors_dataGridView
            // 
            this.doctors_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctors_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctors_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nameColumn,
            this.staffType,
            this.phoneColumn,
            this.addressColumn,
            this.experienceColumn});
            this.doctors_dataGridView.Location = new System.Drawing.Point(191, 108);
            this.doctors_dataGridView.Name = "doctors_dataGridView";
            this.doctors_dataGridView.RowHeadersWidth = 51;
            this.doctors_dataGridView.RowTemplate.Height = 26;
            this.doctors_dataGridView.Size = new System.Drawing.Size(576, 150);
            this.doctors_dataGridView.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // staffType
            // 
            this.staffType.HeaderText = "specialty";
            this.staffType.MinimumWidth = 6;
            this.staffType.Name = "staffType";
            // 
            // phoneColumn
            // 
            this.phoneColumn.HeaderText = "Phone Number";
            this.phoneColumn.MinimumWidth = 6;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // addressColumn
            // 
            this.addressColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.MinimumWidth = 6;
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            // 
            // experienceColumn
            // 
            this.experienceColumn.HeaderText = "Experience";
            this.experienceColumn.MinimumWidth = 6;
            this.experienceColumn.Name = "experienceColumn";
            this.experienceColumn.ReadOnly = true;
            // 
            // chooseDoctor_label
            // 
            this.chooseDoctor_label.AutoSize = true;
            this.chooseDoctor_label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chooseDoctor_label.Location = new System.Drawing.Point(401, 62);
            this.chooseDoctor_label.Name = "chooseDoctor_label";
            this.chooseDoctor_label.Size = new System.Drawing.Size(157, 24);
            this.chooseDoctor_label.TabIndex = 4;
            this.chooseDoctor_label.Text = "Choose a Doctor";
            // 
            // session_dateTimePicker
            // 
            this.session_dateTimePicker.Location = new System.Drawing.Point(191, 276);
            this.session_dateTimePicker.Name = "session_dateTimePicker";
            this.session_dateTimePicker.Size = new System.Drawing.Size(171, 24);
            this.session_dateTimePicker.TabIndex = 5;
            this.session_dateTimePicker.Value = new System.DateTime(2025, 11, 20, 21, 2, 9, 0);
            // 
            // makeAppointment_button
            // 
            this.makeAppointment_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(103)))), ((int)(((byte)(186)))));
            this.makeAppointment_button.FlatAppearance.BorderSize = 0;
            this.makeAppointment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeAppointment_button.ForeColor = System.Drawing.Color.White;
            this.makeAppointment_button.Location = new System.Drawing.Point(191, 372);
            this.makeAppointment_button.Name = "makeAppointment_button";
            this.makeAppointment_button.Size = new System.Drawing.Size(121, 38);
            this.makeAppointment_button.TabIndex = 7;
            this.makeAppointment_button.Text = "Create a session";
            this.makeAppointment_button.UseVisualStyleBackColor = false;
            this.makeAppointment_button.Click += new System.EventHandler(this.makeAppointment_button_Click);
            // 
            // duration_comboBox
            // 
            this.duration_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.duration_comboBox.FormattingEnabled = true;
            this.duration_comboBox.Items.AddRange(new object[] {
            "Session Duration : ",
            "0.5 hour",
            "1 hour",
            "1.5 hours",
            "2 hours"});
            this.duration_comboBox.Location = new System.Drawing.Point(191, 321);
            this.duration_comboBox.Name = "duration_comboBox";
            this.duration_comboBox.Size = new System.Drawing.Size(171, 24);
            this.duration_comboBox.TabIndex = 8;
            // 
            // notes_richTextBox
            // 
            this.notes_richTextBox.Location = new System.Drawing.Point(388, 276);
            this.notes_richTextBox.Name = "notes_richTextBox";
            this.notes_richTextBox.Size = new System.Drawing.Size(229, 69);
            this.notes_richTextBox.TabIndex = 9;
            this.notes_richTextBox.Text = "";
            // 
            // viewDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notes_richTextBox);
            this.Controls.Add(this.duration_comboBox);
            this.Controls.Add(this.makeAppointment_button);
            this.Controls.Add(this.session_dateTimePicker);
            this.Controls.Add(this.chooseDoctor_label);
            this.Controls.Add(this.doctors_dataGridView);
            this.Controls.Add(this.navbarPanel);
            this.Name = "viewDoctors";
            this.Text = "viewDoctors";
            this.Controls.SetChildIndex(this.navbarPanel, 0);
            this.Controls.SetChildIndex(this.doctors_dataGridView, 0);
            this.Controls.SetChildIndex(this.chooseDoctor_label, 0);
            this.Controls.SetChildIndex(this.session_dateTimePicker, 0);
            this.Controls.SetChildIndex(this.makeAppointment_button, 0);
            this.Controls.SetChildIndex(this.duration_comboBox, 0);
            this.Controls.SetChildIndex(this.notes_richTextBox, 0);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctors_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.LinkLabel viewActivities_LinkLabel;
        private System.Windows.Forms.LinkLabel viewDoctors_LinkLabel;
        private System.Windows.Forms.LinkLabel logOut_linkLabel;
        private System.Windows.Forms.DataGridView doctors_dataGridView;
        private System.Windows.Forms.Label chooseDoctor_label;
        private System.Windows.Forms.DateTimePicker session_dateTimePicker;
        private System.Windows.Forms.Button makeAppointment_button;
        private System.Windows.Forms.ComboBox duration_comboBox;
        private System.Windows.Forms.RichTextBox notes_richTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffType;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceColumn;
    }
}