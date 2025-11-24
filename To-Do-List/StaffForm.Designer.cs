namespace To_Do_List
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doctor_logout = new System.Windows.Forms.Button();
            this.Staff_Management = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNationalld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassportNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtNationalld = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.Person_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Staff_HireDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtJobDescription = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_StaffType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 59);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.doctor_logout);
            this.panel1.Controls.Add(this.Staff_Management);
            this.panel1.Location = new System.Drawing.Point(1, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 964);
            this.panel1.TabIndex = 5;
            // 
            // doctor_logout
            // 
            this.doctor_logout.BackColor = System.Drawing.SystemColors.Highlight;
            this.doctor_logout.FlatAppearance.BorderSize = 0;
            this.doctor_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctor_logout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctor_logout.ForeColor = System.Drawing.Color.White;
            this.doctor_logout.Location = new System.Drawing.Point(17, 178);
            this.doctor_logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctor_logout.Name = "doctor_logout";
            this.doctor_logout.Size = new System.Drawing.Size(296, 72);
            this.doctor_logout.TabIndex = 1;
            this.doctor_logout.Text = "Logout";
            this.doctor_logout.UseVisualStyleBackColor = false;
            // 
            // Staff_Management
            // 
            this.Staff_Management.BackColor = System.Drawing.SystemColors.Highlight;
            this.Staff_Management.FlatAppearance.BorderSize = 0;
            this.Staff_Management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staff_Management.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff_Management.ForeColor = System.Drawing.Color.Yellow;
            this.Staff_Management.Location = new System.Drawing.Point(17, 87);
            this.Staff_Management.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Staff_Management.Name = "Staff_Management";
            this.Staff_Management.Size = new System.Drawing.Size(300, 58);
            this.Staff_Management.TabIndex = 0;
            this.Staff_Management.Text = "Staff Management";
            this.Staff_Management.UseVisualStyleBackColor = false;
            // 
            // dgvStaff
            // 
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFullName,
            this.ColAge,
            this.colGender,
            this.colBirthDate,
            this.colPhone,
            this.colAddress,
            this.colJobTitle,
            this.colSalary,
            this.colHireDate,
            this.colEducation,
            this.colExperience,
            this.colNationalld,
            this.colPassportNumber,
            this.colStaffId,
            this.colPersonId,
            this.colJobDescription});
            this.dgvStaff.Location = new System.Drawing.Point(365, 106);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 26;
            this.dgvStaff.Size = new System.Drawing.Size(1012, 222);
            this.dgvStaff.TabIndex = 6;
            this.dgvStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellContentClick);
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "FullName";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.Width = 125;
            // 
            // ColAge
            // 
            this.ColAge.DataPropertyName = "Age";
            this.ColAge.HeaderText = "Age";
            this.ColAge.MinimumWidth = 6;
            this.ColAge.Name = "ColAge";
            this.ColAge.Width = 125;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            this.colGender.Width = 125;
            // 
            // colBirthDate
            // 
            this.colBirthDate.DataPropertyName = "BirthDate";
            this.colBirthDate.HeaderText = "BirthDate";
            this.colBirthDate.MinimumWidth = 6;
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Width = 125;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Phone";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 125;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.Width = 125;
            // 
            // colJobTitle
            // 
            this.colJobTitle.DataPropertyName = "JobTitle";
            this.colJobTitle.HeaderText = "JobTitle";
            this.colJobTitle.MinimumWidth = 6;
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.Width = 125;
            // 
            // colSalary
            // 
            this.colSalary.DataPropertyName = "Salary";
            this.colSalary.HeaderText = "Salary";
            this.colSalary.MinimumWidth = 6;
            this.colSalary.Name = "colSalary";
            this.colSalary.Width = 125;
            // 
            // colHireDate
            // 
            this.colHireDate.DataPropertyName = "HireDate";
            this.colHireDate.HeaderText = "HireDate";
            this.colHireDate.MinimumWidth = 6;
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.Width = 125;
            // 
            // colEducation
            // 
            this.colEducation.DataPropertyName = "Education";
            this.colEducation.HeaderText = "Education";
            this.colEducation.MinimumWidth = 6;
            this.colEducation.Name = "colEducation";
            this.colEducation.Width = 125;
            // 
            // colExperience
            // 
            this.colExperience.DataPropertyName = "Experience";
            this.colExperience.HeaderText = "Experience";
            this.colExperience.MinimumWidth = 6;
            this.colExperience.Name = "colExperience";
            this.colExperience.Width = 125;
            // 
            // colNationalld
            // 
            this.colNationalld.DataPropertyName = "Nationalld";
            this.colNationalld.HeaderText = "Nationalld";
            this.colNationalld.MinimumWidth = 6;
            this.colNationalld.Name = "colNationalld";
            this.colNationalld.Width = 125;
            // 
            // colPassportNumber
            // 
            this.colPassportNumber.DataPropertyName = "PassportNumber";
            this.colPassportNumber.HeaderText = "PassportNumber";
            this.colPassportNumber.MinimumWidth = 6;
            this.colPassportNumber.Name = "colPassportNumber";
            this.colPassportNumber.Width = 125;
            // 
            // colStaffId
            // 
            this.colStaffId.DataPropertyName = "StaffId";
            this.colStaffId.HeaderText = "StaffId";
            this.colStaffId.MinimumWidth = 6;
            this.colStaffId.Name = "colStaffId";
            this.colStaffId.Visible = false;
            this.colStaffId.Width = 125;
            // 
            // colPersonId
            // 
            this.colPersonId.DataPropertyName = "PersonId";
            this.colPersonId.HeaderText = "PersonId";
            this.colPersonId.MinimumWidth = 6;
            this.colPersonId.Name = "colPersonId";
            this.colPersonId.Visible = false;
            this.colPersonId.Width = 125;
            // 
            // colJobDescription
            // 
            this.colJobDescription.DataPropertyName = "JobDescription";
            this.colJobDescription.HeaderText = "JobDescription";
            this.colJobDescription.MinimumWidth = 6;
            this.colJobDescription.Name = "colJobDescription";
            this.colJobDescription.Width = 125;
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFullName.Location = new System.Drawing.Point(345, 365);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(171, 53);
            this.txtFullName.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAge.Location = new System.Drawing.Point(760, 365);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(171, 53);
            this.txtAge.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPhone.Location = new System.Drawing.Point(1170, 365);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(171, 53);
            this.txtPhone.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAddress.Location = new System.Drawing.Point(345, 479);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 54);
            this.txtAddress.TabIndex = 10;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSalary.Location = new System.Drawing.Point(760, 479);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(171, 54);
            this.txtSalary.TabIndex = 11;
            // 
            // txtEducation
            // 
            this.txtEducation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEducation.Location = new System.Drawing.Point(1170, 479);
            this.txtEducation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEducation.Multiline = true;
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(171, 54);
            this.txtEducation.TabIndex = 12;
            // 
            // txtExperience
            // 
            this.txtExperience.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtExperience.Location = new System.Drawing.Point(345, 607);
            this.txtExperience.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExperience.Multiline = true;
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(171, 55);
            this.txtExperience.TabIndex = 13;
            // 
            // txtNationalld
            // 
            this.txtNationalld.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNationalld.Location = new System.Drawing.Point(760, 607);
            this.txtNationalld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNationalld.Multiline = true;
            this.txtNationalld.Name = "txtNationalld";
            this.txtNationalld.Size = new System.Drawing.Size(171, 55);
            this.txtNationalld.TabIndex = 14;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassportNumber.Location = new System.Drawing.Point(1170, 607);
            this.txtPassportNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassportNumber.Multiline = true;
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(171, 55);
            this.txtPassportNumber.TabIndex = 15;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(690, 832);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(212, 27);
            this.cmbGender.TabIndex = 16;
            // 
            // Person_DateOfBirth
            // 
            this.Person_DateOfBirth.Location = new System.Drawing.Point(1120, 729);
            this.Person_DateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Person_DateOfBirth.Name = "Person_DateOfBirth";
            this.Person_DateOfBirth.Size = new System.Drawing.Size(256, 27);
            this.Person_DateOfBirth.TabIndex = 18;
            // 
            // Staff_HireDate
            // 
            this.Staff_HireDate.Location = new System.Drawing.Point(345, 832);
            this.Staff_HireDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Staff_HireDate.Name = "Staff_HireDate";
            this.Staff_HireDate.Size = new System.Drawing.Size(256, 27);
            this.Staff_HireDate.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(345, 894);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 53);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(625, 894);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 53);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(908, 894);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 53);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(1142, 894);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 53);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(339, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "FullName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(755, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(1184, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(351, 450);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(755, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(1184, 450);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Education";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(351, 578);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Experience";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(755, 578);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Nationalld";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(1152, 578);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "PassportNumber";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(685, 800);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "Choose your gender";
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtJob.Location = new System.Drawing.Point(345, 729);
            this.txtJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(171, 55);
            this.txtJob.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(360, 686);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 24);
            this.label11.TabIndex = 35;
            this.label11.Text = "Job";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(1129, 686);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 24);
            this.label12.TabIndex = 36;
            this.label12.Text = "DateOfBirth";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(357, 800);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 24);
            this.label13.TabIndex = 37;
            this.label13.Text = "Hire Date";
            // 
            // txtJobDescription
            // 
            this.txtJobDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtJobDescription.Location = new System.Drawing.Point(760, 729);
            this.txtJobDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJobDescription.Multiline = true;
            this.txtJobDescription.Name = "txtJobDescription";
            this.txtJobDescription.Size = new System.Drawing.Size(171, 55);
            this.txtJobDescription.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Window;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(755, 686);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 24);
            this.label14.TabIndex = 39;
            this.label14.Text = "JobDescription ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(965, 800);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 24);
            this.label15.TabIndex = 41;
            this.label15.Text = "Choose Staff Type";
            // 
            // comboBox_StaffType
            // 
            this.comboBox_StaffType.FormattingEnabled = true;
            this.comboBox_StaffType.Location = new System.Drawing.Point(970, 832);
            this.comboBox_StaffType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_StaffType.Name = "comboBox_StaffType";
            this.comboBox_StaffType.Size = new System.Drawing.Size(212, 27);
            this.comboBox_StaffType.TabIndex = 40;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 1253);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox_StaffType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtJobDescription);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Staff_HireDate);
            this.Controls.Add(this.Person_DateOfBirth);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.txtNationalld);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffForm";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button doctor_logout;
        private System.Windows.Forms.Button Staff_Management;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.TextBox txtNationalld;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker Person_DateOfBirth;
        private System.Windows.Forms.DateTimePicker Staff_HireDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtJobDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalld;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassportNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobDescription;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_StaffType;
    }
}