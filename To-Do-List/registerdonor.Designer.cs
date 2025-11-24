namespace To_Do_List
{
    partial class registerdonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerdonor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.Genderlable = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DOB = new System.Windows.Forms.Label();
            this.PhoneNumberLable = new System.Windows.Forms.Label();
            this.LableAddress = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.phonenumbertextbox = new System.Windows.Forms.TextBox();
            this.Rectangle = new System.Windows.Forms.PictureBox();
            this.btnRegsiter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(425, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SideBar
            // 
            this.SideBar.Image = ((System.Drawing.Image)(resources.GetObject("SideBar.Image")));
            this.SideBar.Location = new System.Drawing.Point(1, 68);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(369, 974);
            this.SideBar.TabIndex = 1;
            this.SideBar.TabStop = false;
            this.SideBar.Click += new System.EventHandler(this.SideBar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1080, 73);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxFullName.Location = new System.Drawing.Point(453, 151);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(348, 22);
            this.textBoxFullName.TabIndex = 3;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(453, 195);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(348, 24);
            this.comboBoxGender.TabIndex = 5;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // Genderlable
            // 
            this.Genderlable.AutoSize = true;
            this.Genderlable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Genderlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlable.Location = new System.Drawing.Point(450, 176);
            this.Genderlable.Name = "Genderlable";
            this.Genderlable.Size = new System.Drawing.Size(147, 16);
            this.Genderlable.TabIndex = 6;
            this.Genderlable.Text = "Choose your gender";
            this.Genderlable.Click += new System.EventHandler(this.Genderlable_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(348, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(450, 226);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(100, 16);
            this.DOB.TabIndex = 8;
            this.DOB.Text = "Date of Birth :";
            this.DOB.Click += new System.EventHandler(this.DOB_Click);
            // 
            // PhoneNumberLable
            // 
            this.PhoneNumberLable.AutoSize = true;
            this.PhoneNumberLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLable.Location = new System.Drawing.Point(450, 280);
            this.PhoneNumberLable.Name = "PhoneNumberLable";
            this.PhoneNumberLable.Size = new System.Drawing.Size(117, 16);
            this.PhoneNumberLable.TabIndex = 9;
            this.PhoneNumberLable.Text = "Phone Number :";
            this.PhoneNumberLable.Click += new System.EventHandler(this.PhoneNumberLable_Click);
            // 
            // LableAddress
            // 
            this.LableAddress.AutoSize = true;
            this.LableAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LableAddress.Location = new System.Drawing.Point(450, 340);
            this.LableAddress.Name = "LableAddress";
            this.LableAddress.Size = new System.Drawing.Size(73, 16);
            this.LableAddress.TabIndex = 11;
            this.LableAddress.Text = "Address :";
            this.LableAddress.Click += new System.EventHandler(this.LableAddress_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AddressTextBox.Location = new System.Drawing.Point(453, 359);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(343, 22);
            this.AddressTextBox.TabIndex = 12;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(453, 132);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(82, 16);
            this.FullNameLabel.TabIndex = 13;
            this.FullNameLabel.Text = "Full name :";
            // 
            // phonenumbertextbox
            // 
            this.phonenumbertextbox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.phonenumbertextbox.Location = new System.Drawing.Point(453, 301);
            this.phonenumbertextbox.Name = "phonenumbertextbox";
            this.phonenumbertextbox.Size = new System.Drawing.Size(342, 22);
            this.phonenumbertextbox.TabIndex = 14;
            this.phonenumbertextbox.TextChanged += new System.EventHandler(this.phonenumbertextbox_TextChanged);
            // 
            // Rectangle
            // 
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.Location = new System.Drawing.Point(718, 399);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(93, 52);
            this.Rectangle.TabIndex = 15;
            this.Rectangle.TabStop = false;
            this.Rectangle.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnRegsiter
            // 
            this.btnRegsiter.Location = new System.Drawing.Point(727, 408);
            this.btnRegsiter.Name = "btnRegsiter";
            this.btnRegsiter.Size = new System.Drawing.Size(74, 28);
            this.btnRegsiter.TabIndex = 16;
            this.btnRegsiter.Text = "Regsiter";
            this.btnRegsiter.UseVisualStyleBackColor = true;
            this.btnRegsiter.Click += new System.EventHandler(this.btnRegsiter_Click);
            // 
            // registerdonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1083, 772);
            this.Controls.Add(this.btnRegsiter);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.phonenumbertextbox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.LableAddress);
            this.Controls.Add(this.PhoneNumberLable);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Genderlable);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "registerdonor";
            this.Text = "registerdonor";
            this.Load += new System.EventHandler(this.registerasdonor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SideBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label Genderlable;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label PhoneNumberLable;
        private System.Windows.Forms.Label LableAddress;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox phonenumbertextbox;
        private System.Windows.Forms.PictureBox Rectangle;
        private System.Windows.Forms.Button btnRegsiter;
    }
}