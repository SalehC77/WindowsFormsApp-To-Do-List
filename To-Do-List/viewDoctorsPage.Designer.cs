namespace To_Do_List
{
    partial class viewDoctorsPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::To_Do_List.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(242, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(589, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // viewDoctorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.navbarPanel);
            this.Name = "viewDoctorsPage";
            this.Text = "viewDoctorsPage";
            this.Controls.SetChildIndex(this.navbarPanel, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.LinkLabel viewActivities_LinkLabel;
        private System.Windows.Forms.LinkLabel viewDoctors_LinkLabel;
        private System.Windows.Forms.LinkLabel logOut_linkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}