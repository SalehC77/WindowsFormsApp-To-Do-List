namespace To_Do_List
{
    partial class Student_Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcome_label = new System.Windows.Forms.Label();
            this.intro_label = new System.Windows.Forms.Label();
            this.viewDoctors_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.viewActivities_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.logOut_linkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::To_Do_List.Properties.Resources.StudentHome;
            this.pictureBox1.Location = new System.Drawing.Point(337, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(224, 76);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(258, 25);
            this.welcome_label.TabIndex = 3;
            this.welcome_label.Text = "Welcome, mohammed !";
            // 
            // intro_label
            // 
            this.intro_label.AutoSize = true;
            this.intro_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.intro_label.Location = new System.Drawing.Point(224, 104);
            this.intro_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intro_label.Name = "intro_label";
            this.intro_label.Size = new System.Drawing.Size(636, 24);
            this.intro_label.TabIndex = 4;
            this.intro_label.Text = "Manage your appointments, explore activities, and view doctors easily";
            // 
            // viewDoctors_LinkLabel
            // 
            this.viewDoctors_LinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.viewDoctors_LinkLabel.AutoSize = true;
            this.viewDoctors_LinkLabel.ForeColor = System.Drawing.Color.White;
            this.viewDoctors_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewDoctors_LinkLabel.LinkColor = System.Drawing.Color.White;
            this.viewDoctors_LinkLabel.Location = new System.Drawing.Point(42, 21);
            this.viewDoctors_LinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewDoctors_LinkLabel.Name = "viewDoctors_LinkLabel";
            this.viewDoctors_LinkLabel.Size = new System.Drawing.Size(102, 19);
            this.viewDoctors_LinkLabel.TabIndex = 5;
            this.viewDoctors_LinkLabel.TabStop = true;
            this.viewDoctors_LinkLabel.Text = "View Doctors";
            this.viewDoctors_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewDoctors_LinkLabel_LinkClicked);
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(67)))), ((int)(((byte)(229)))));
            this.navbarPanel.Controls.Add(this.viewActivities_LinkLabel);
            this.navbarPanel.Controls.Add(this.viewDoctors_LinkLabel);
            this.navbarPanel.Controls.Add(this.logOut_linkLabel);
            this.navbarPanel.Location = new System.Drawing.Point(0, 59);
            this.navbarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(198, 483);
            this.navbarPanel.TabIndex = 1;
            // 
            // viewActivities_LinkLabel
            // 
            this.viewActivities_LinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.viewActivities_LinkLabel.AutoSize = true;
            this.viewActivities_LinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.viewActivities_LinkLabel.LinkColor = System.Drawing.Color.White;
            this.viewActivities_LinkLabel.Location = new System.Drawing.Point(41, 68);
            this.viewActivities_LinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewActivities_LinkLabel.Name = "viewActivities_LinkLabel";
            this.viewActivities_LinkLabel.Size = new System.Drawing.Size(111, 19);
            this.viewActivities_LinkLabel.TabIndex = 7;
            this.viewActivities_LinkLabel.TabStop = true;
            this.viewActivities_LinkLabel.Text = "View Activities";
            this.viewActivities_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewActivities_LinkLabel_LinkClicked);
            // 
            // logOut_linkLabel
            // 
            this.logOut_linkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.logOut_linkLabel.AutoSize = true;
            this.logOut_linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logOut_linkLabel.LinkColor = System.Drawing.Color.White;
            this.logOut_linkLabel.Location = new System.Drawing.Point(62, 114);
            this.logOut_linkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logOut_linkLabel.Name = "logOut_linkLabel";
            this.logOut_linkLabel.Size = new System.Drawing.Size(66, 19);
            this.logOut_linkLabel.TabIndex = 6;
            this.logOut_linkLabel.TabStop = true;
            this.logOut_linkLabel.Text = "Log Out";
            this.logOut_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOut_linkLabel_LinkClicked);
            // 
            // Student_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1029, 534);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.intro_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Student_Home";
            this.Text = "Student_Home";
            this.Load += new System.EventHandler(this.Student_Home_Load);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.welcome_label, 0);
            this.Controls.SetChildIndex(this.intro_label, 0);
            this.Controls.SetChildIndex(this.navbarPanel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label intro_label;
        private System.Windows.Forms.LinkLabel viewDoctors_LinkLabel;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.LinkLabel logOut_linkLabel;
        private System.Windows.Forms.LinkLabel viewActivities_LinkLabel;
    }
}