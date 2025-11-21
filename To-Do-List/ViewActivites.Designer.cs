namespace To_Do_List
{
    partial class ViewActivites
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
            this.makeAppointment_button = new System.Windows.Forms.Button();
            this.chooseActivites_label = new System.Windows.Forms.Label();
            this.activities_dataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discription_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.viewActivities_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.viewDoctors_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.logOut_linkLabel = new System.Windows.Forms.LinkLabel();
            this.notes_richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.activities_dataGridView)).BeginInit();
            this.navbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeAppointment_button
            // 
            this.makeAppointment_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(103)))), ((int)(((byte)(186)))));
            this.makeAppointment_button.FlatAppearance.BorderSize = 0;
            this.makeAppointment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeAppointment_button.ForeColor = System.Drawing.Color.White;
            this.makeAppointment_button.Location = new System.Drawing.Point(192, 367);
            this.makeAppointment_button.Name = "makeAppointment_button";
            this.makeAppointment_button.Size = new System.Drawing.Size(121, 38);
            this.makeAppointment_button.TabIndex = 13;
            this.makeAppointment_button.Text = "Enroll";
            this.makeAppointment_button.UseVisualStyleBackColor = false;
            this.makeAppointment_button.Click += new System.EventHandler(this.makeAppointment_button_Click);
            // 
            // chooseActivites_label
            // 
            this.chooseActivites_label.AutoSize = true;
            this.chooseActivites_label.Font = new System.Drawing.Font("Tahoma", 12F);
            this.chooseActivites_label.Location = new System.Drawing.Point(386, 61);
            this.chooseActivites_label.Name = "chooseActivites_label";
            this.chooseActivites_label.Size = new System.Drawing.Size(183, 24);
            this.chooseActivites_label.TabIndex = 11;
            this.chooseActivites_label.Text = "Choose an activites";
            // 
            // activities_dataGridView
            // 
            this.activities_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activities_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activities_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nameColumn,
            this.startDate_Column,
            this.expirationDate_Column,
            this.Discription_Column});
            this.activities_dataGridView.Location = new System.Drawing.Point(192, 107);
            this.activities_dataGridView.Name = "activities_dataGridView";
            this.activities_dataGridView.RowHeadersWidth = 51;
            this.activities_dataGridView.RowTemplate.Height = 26;
            this.activities_dataGridView.Size = new System.Drawing.Size(576, 150);
            this.activities_dataGridView.TabIndex = 10;
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
            // startDate_Column
            // 
            this.startDate_Column.HeaderText = "Start Date";
            this.startDate_Column.MinimumWidth = 6;
            this.startDate_Column.Name = "startDate_Column";
            this.startDate_Column.ReadOnly = true;
            // 
            // expirationDate_Column
            // 
            this.expirationDate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expirationDate_Column.HeaderText = "Expiration Date";
            this.expirationDate_Column.MinimumWidth = 6;
            this.expirationDate_Column.Name = "expirationDate_Column";
            this.expirationDate_Column.ReadOnly = true;
            // 
            // Discription_Column
            // 
            this.Discription_Column.HeaderText = "Discription";
            this.Discription_Column.MinimumWidth = 6;
            this.Discription_Column.Name = "Discription_Column";
            this.Discription_Column.ReadOnly = true;
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(67)))), ((int)(((byte)(229)))));
            this.navbarPanel.Controls.Add(this.viewActivities_LinkLabel);
            this.navbarPanel.Controls.Add(this.viewDoctors_LinkLabel);
            this.navbarPanel.Controls.Add(this.logOut_linkLabel);
            this.navbarPanel.Location = new System.Drawing.Point(0, 50);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(154, 407);
            this.navbarPanel.TabIndex = 9;
            // 
            // viewActivities_LinkLabel
            // 
            this.viewActivities_LinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.viewActivities_LinkLabel.AutoSize = true;
            this.viewActivities_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewActivities_LinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.viewActivities_LinkLabel.Location = new System.Drawing.Point(32, 57);
            this.viewActivities_LinkLabel.Name = "viewActivities_LinkLabel";
            this.viewActivities_LinkLabel.Size = new System.Drawing.Size(91, 17);
            this.viewActivities_LinkLabel.TabIndex = 7;
            this.viewActivities_LinkLabel.TabStop = true;
            this.viewActivities_LinkLabel.Text = "View Activities";
            // 
            // viewDoctors_LinkLabel
            // 
            this.viewDoctors_LinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.viewDoctors_LinkLabel.AutoSize = true;
            this.viewDoctors_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewDoctors_LinkLabel.LinkColor = System.Drawing.Color.White;
            this.viewDoctors_LinkLabel.Location = new System.Drawing.Point(33, 18);
            this.viewDoctors_LinkLabel.Name = "viewDoctors_LinkLabel";
            this.viewDoctors_LinkLabel.Size = new System.Drawing.Size(88, 17);
            this.viewDoctors_LinkLabel.TabIndex = 5;
            this.viewDoctors_LinkLabel.TabStop = true;
            this.viewDoctors_LinkLabel.Text = "View Doctors";
            this.viewDoctors_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewDoctors_LinkLabel_LinkClicked);
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
            // notes_richTextBox
            // 
            this.notes_richTextBox.Location = new System.Drawing.Point(192, 276);
            this.notes_richTextBox.Name = "notes_richTextBox";
            this.notes_richTextBox.Size = new System.Drawing.Size(178, 68);
            this.notes_richTextBox.TabIndex = 14;
            this.notes_richTextBox.Text = "";
            // 
            // ViewActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notes_richTextBox);
            this.Controls.Add(this.makeAppointment_button);
            this.Controls.Add(this.chooseActivites_label);
            this.Controls.Add(this.activities_dataGridView);
            this.Controls.Add(this.navbarPanel);
            this.Name = "ViewActivites";
            this.Text = "ViewActivites";
            this.Controls.SetChildIndex(this.navbarPanel, 0);
            this.Controls.SetChildIndex(this.activities_dataGridView, 0);
            this.Controls.SetChildIndex(this.chooseActivites_label, 0);
            this.Controls.SetChildIndex(this.makeAppointment_button, 0);
            this.Controls.SetChildIndex(this.notes_richTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.activities_dataGridView)).EndInit();
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button makeAppointment_button;
        private System.Windows.Forms.Label chooseActivites_label;
        private System.Windows.Forms.DataGridView activities_dataGridView;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.LinkLabel viewActivities_LinkLabel;
        private System.Windows.Forms.LinkLabel viewDoctors_LinkLabel;
        private System.Windows.Forms.LinkLabel logOut_linkLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discription_Column;
        private System.Windows.Forms.RichTextBox notes_richTextBox;
    }
}