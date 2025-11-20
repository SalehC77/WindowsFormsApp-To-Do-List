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
            this.logOut_linkLabel = new System.Windows.Forms.LinkLabel();
            this.viewActivities_LinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::To_Do_List.Properties.Resources.StudentHome;
            this.pictureBox1.Location = new System.Drawing.Point(262, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(174, 64);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(210, 21);
            this.welcome_label.TabIndex = 3;
            this.welcome_label.Text = "Welcome, mohammed !";
            // 
            // intro_label
            // 
            this.intro_label.AutoSize = true;
            this.intro_label.Font = new System.Drawing.Font("Tahoma", 10F);
            this.intro_label.Location = new System.Drawing.Point(174, 88);
            this.intro_label.Name = "intro_label";
            this.intro_label.Size = new System.Drawing.Size(529, 21);
            this.intro_label.TabIndex = 4;
            this.intro_label.Text = "Manage your appointments, explore activities, and view doctors easily";
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
            this.navbarPanel.TabIndex = 1;
            this.navbarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navbarPanel_Paint);
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
            // 
            // Student_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.intro_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.pictureBox1);
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