namespace To_Do_List
{
    partial class Student_Register
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.stage_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.DateOfBirth_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.disability_comboBox = new System.Windows.Forms.ComboBox();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.logOut_linkLabel = new System.Windows.Forms.LinkLabel();
            this.navbarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textBox.Location = new System.Drawing.Point(386, 91);
            this.name_textBox.Multiline = true;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(182, 30);
            this.name_textBox.TabIndex = 3;
            // 
            // stage_textBox
            // 
            this.stage_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.stage_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stage_textBox.Location = new System.Drawing.Point(386, 273);
            this.stage_textBox.Multiline = true;
            this.stage_textBox.Name = "stage_textBox";
            this.stage_textBox.Size = new System.Drawing.Size(182, 30);
            this.stage_textBox.TabIndex = 5;
            // 
            // phone_textBox
            // 
            this.phone_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.phone_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone_textBox.Location = new System.Drawing.Point(386, 179);
            this.phone_textBox.Multiline = true;
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(182, 30);
            this.phone_textBox.TabIndex = 6;
            // 
            // Address_textBox
            // 
            this.Address_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.Address_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Address_textBox.Location = new System.Drawing.Point(386, 226);
            this.Address_textBox.Multiline = true;
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(182, 30);
            this.Address_textBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(370, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Register As A Student :";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(103)))), ((int)(((byte)(186)))));
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(473, 405);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(95, 30);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click_1);
            // 
            // genderComboBox
            // 
            this.genderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "choose your gender",
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(386, 138);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(182, 24);
            this.genderComboBox.TabIndex = 12;
            // 
            // DateOfBirth_DateTimePicker
            // 
            this.DateOfBirth_DateTimePicker.Location = new System.Drawing.Point(386, 365);
            this.DateOfBirth_DateTimePicker.Name = "DateOfBirth_DateTimePicker";
            this.DateOfBirth_DateTimePicker.Size = new System.Drawing.Size(182, 24);
            this.DateOfBirth_DateTimePicker.TabIndex = 13;
            // 
            // disability_comboBox
            // 
            this.disability_comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.disability_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disability_comboBox.FormattingEnabled = true;
            this.disability_comboBox.Items.AddRange(new object[] {
            ""});
            this.disability_comboBox.Location = new System.Drawing.Point(386, 320);
            this.disability_comboBox.Name = "disability_comboBox";
            this.disability_comboBox.Size = new System.Drawing.Size(182, 24);
            this.disability_comboBox.TabIndex = 14;
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(67)))), ((int)(((byte)(229)))));
            this.navbarPanel.Controls.Add(this.logOut_linkLabel);
            this.navbarPanel.Location = new System.Drawing.Point(0, 50);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(154, 407);
            this.navbarPanel.TabIndex = 15;
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
            // Student_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navbarPanel);
            this.Controls.Add(this.disability_comboBox);
            this.Controls.Add(this.DateOfBirth_DateTimePicker);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.stage_textBox);
            this.Controls.Add(this.name_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Student_Register";
            this.Text = "Student_Register";
            this.Controls.SetChildIndex(this.name_textBox, 0);
            this.Controls.SetChildIndex(this.stage_textBox, 0);
            this.Controls.SetChildIndex(this.phone_textBox, 0);
            this.Controls.SetChildIndex(this.Address_textBox, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.RegisterButton, 0);
            this.Controls.SetChildIndex(this.genderComboBox, 0);
            this.Controls.SetChildIndex(this.DateOfBirth_DateTimePicker, 0);
            this.Controls.SetChildIndex(this.disability_comboBox, 0);
            this.Controls.SetChildIndex(this.navbarPanel, 0);
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox stage_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker DateOfBirth_DateTimePicker;
        private System.Windows.Forms.ComboBox disability_comboBox;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.LinkLabel logOut_linkLabel;
    }
}