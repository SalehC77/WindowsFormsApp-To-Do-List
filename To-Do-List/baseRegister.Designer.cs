namespace To_Do_List
{
    partial class baseRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Designer controls

        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox password_textBox;

        #endregion

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
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.logOut_linkLabel = new System.Windows.Forms.LinkLabel();
            this.role_comboBox = new System.Windows.Forms.ComboBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.navbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_textBox
            // 
            this.username_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.username_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_textBox.Location = new System.Drawing.Point(381, 100);
            this.username_textBox.Multiline = true;
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(182, 30);
            this.username_textBox.TabIndex = 0;
            this.username_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // email_textBox
            // 
            this.email_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.email_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_textBox.Location = new System.Drawing.Point(381, 150);
            this.email_textBox.Multiline = true;
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(182, 30);
            this.email_textBox.TabIndex = 1;
            this.email_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textBox.Location = new System.Drawing.Point(381, 200);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(182, 30);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Register";
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(67)))), ((int)(((byte)(229)))));
            this.navbarPanel.Controls.Add(this.logOut_linkLabel);
            this.navbarPanel.Location = new System.Drawing.Point(0, 50);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(154, 407);
            this.navbarPanel.TabIndex = 4;
            // 
            // logOut_linkLabel
            // 
            this.logOut_linkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(161)))), ((int)(((byte)(0)))));
            this.logOut_linkLabel.AutoSize = true;
            this.logOut_linkLabel.Font = new System.Drawing.Font("Tahoma", 16F);
            this.logOut_linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logOut_linkLabel.LinkColor = System.Drawing.Color.White;
            this.logOut_linkLabel.Location = new System.Drawing.Point(8, 36);
            this.logOut_linkLabel.Name = "logOut_linkLabel";
            this.logOut_linkLabel.Size = new System.Drawing.Size(139, 132);
            this.logOut_linkLabel.TabIndex = 6;
            this.logOut_linkLabel.TabStop = true;
            this.logOut_linkLabel.Text = "Welcome\r\nto Center\r\nfor Special\r\nNeeds !";
            // 
            // role_comboBox
            // 
            this.role_comboBox.FormattingEnabled = true;
            this.role_comboBox.Location = new System.Drawing.Point(381, 256);
            this.role_comboBox.Name = "role_comboBox";
            this.role_comboBox.Size = new System.Drawing.Size(182, 24);
            this.role_comboBox.TabIndex = 5;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(103)))), ((int)(((byte)(186)))));
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(468, 302);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(95, 30);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Continue";
            this.RegisterButton.UseVisualStyleBackColor = false;
            // 
            // baseRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.role_comboBox);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.password_textBox);
            this.Name = "baseRegister";
            this.Text = "baseRegister";
            this.Controls.SetChildIndex(this.password_textBox, 0);
            this.Controls.SetChildIndex(this.email_textBox, 0);
            this.Controls.SetChildIndex(this.username_textBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.navbarPanel, 0);
            this.Controls.SetChildIndex(this.role_comboBox, 0);
            this.Controls.SetChildIndex(this.RegisterButton, 0);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.LinkLabel logOut_linkLabel;
        private System.Windows.Forms.ComboBox role_comboBox;
        private System.Windows.Forms.Button RegisterButton;
    }
}