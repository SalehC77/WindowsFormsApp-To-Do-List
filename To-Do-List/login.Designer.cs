namespace To_Do_List
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.NavBar = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.PictureBox();
            this.EnterYouraccountandbass = new System.Windows.Forms.Label();
            this.picturefordesgin = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.WelcomeBack = new System.Windows.Forms.Label();
            this.DontHaveAccount = new System.Windows.Forms.Label();
            this.Createansccount = new System.Windows.Forms.Label();
            this.BlueRectangleForDesgin = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturefordesgin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRectangleForDesgin)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.Image = ((System.Drawing.Image)(resources.GetObject("NavBar.Image")));
            this.NavBar.Location = new System.Drawing.Point(1, -1);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1136, 77);
            this.NavBar.TabIndex = 0;
            this.NavBar.TabStop = false;
            this.NavBar.Click += new System.EventHandler(this.NavBar_Click);
            // 
            // SideBar
            // 
            this.SideBar.Image = ((System.Drawing.Image)(resources.GetObject("SideBar.Image")));
            this.SideBar.Location = new System.Drawing.Point(1, 73);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(327, 980);
            this.SideBar.TabIndex = 1;
            this.SideBar.TabStop = false;
            this.SideBar.Click += new System.EventHandler(this.SideBar_Click);
            // 
            // EnterYouraccountandbass
            // 
            this.EnterYouraccountandbass.AutoSize = true;
            this.EnterYouraccountandbass.Location = new System.Drawing.Point(509, 164);
            this.EnterYouraccountandbass.Name = "EnterYouraccountandbass";
            this.EnterYouraccountandbass.Size = new System.Drawing.Size(336, 16);
            this.EnterYouraccountandbass.TabIndex = 2;
            this.EnterYouraccountandbass.Text = "Enter Your email and password to access your account ";
            this.EnterYouraccountandbass.Click += new System.EventHandler(this.EnterYouraccountandbass_Click);
            // 
            // picturefordesgin
            // 
            this.picturefordesgin.Image = ((System.Drawing.Image)(resources.GetObject("picturefordesgin.Image")));
            this.picturefordesgin.Location = new System.Drawing.Point(401, 356);
            this.picturefordesgin.Name = "picturefordesgin";
            this.picturefordesgin.Size = new System.Drawing.Size(472, 287);
            this.picturefordesgin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturefordesgin.TabIndex = 3;
            this.picturefordesgin.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(469, 208);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(41, 16);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "Email";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(469, 246);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxUsername.Location = new System.Drawing.Point(548, 208);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(252, 22);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPassword.Location = new System.Drawing.Point(548, 246);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(252, 22);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // WelcomeBack
            // 
            this.WelcomeBack.AutoSize = true;
            this.WelcomeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBack.Location = new System.Drawing.Point(580, 122);
            this.WelcomeBack.Name = "WelcomeBack";
            this.WelcomeBack.Size = new System.Drawing.Size(186, 29);
            this.WelcomeBack.TabIndex = 8;
            this.WelcomeBack.Text = "Welcome Back";
            // 
            // DontHaveAccount
            // 
            this.DontHaveAccount.AutoSize = true;
            this.DontHaveAccount.Location = new System.Drawing.Point(536, 326);
            this.DontHaveAccount.Name = "DontHaveAccount";
            this.DontHaveAccount.Size = new System.Drawing.Size(152, 16);
            this.DontHaveAccount.TabIndex = 9;
            this.DontHaveAccount.Text = "Don’t have an account ? ";
            this.DontHaveAccount.Click += new System.EventHandler(this.DontHaveAccount_Click);
            // 
            // Createansccount
            // 
            this.Createansccount.AutoSize = true;
            this.Createansccount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Createansccount.Location = new System.Drawing.Point(694, 326);
            this.Createansccount.Name = "Createansccount";
            this.Createansccount.Size = new System.Drawing.Size(115, 16);
            this.Createansccount.TabIndex = 10;
            this.Createansccount.Text = "Create an account";
            this.Createansccount.Click += new System.EventHandler(this.Createansccount_Click);
            // 
            // BlueRectangleForDesgin
            // 
            this.BlueRectangleForDesgin.Image = ((System.Drawing.Image)(resources.GetObject("BlueRectangleForDesgin.Image")));
            this.BlueRectangleForDesgin.Location = new System.Drawing.Point(725, 276);
            this.BlueRectangleForDesgin.Name = "BlueRectangleForDesgin";
            this.BlueRectangleForDesgin.Size = new System.Drawing.Size(84, 43);
            this.BlueRectangleForDesgin.TabIndex = 11;
            this.BlueRectangleForDesgin.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginButton.Location = new System.Drawing.Point(732, 285);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(68, 25);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click_1);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1099, 1055);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.BlueRectangleForDesgin);
            this.Controls.Add(this.Createansccount);
            this.Controls.Add(this.DontHaveAccount);
            this.Controls.Add(this.WelcomeBack);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.picturefordesgin);
            this.Controls.Add(this.EnterYouraccountandbass);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.NavBar);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturefordesgin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueRectangleForDesgin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NavBar;
        private System.Windows.Forms.PictureBox SideBar;
        private System.Windows.Forms.Label EnterYouraccountandbass;
        private System.Windows.Forms.PictureBox picturefordesgin;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label WelcomeBack;
        private System.Windows.Forms.Label DontHaveAccount;
        private System.Windows.Forms.Label Createansccount;
        private System.Windows.Forms.PictureBox BlueRectangleForDesgin;
        private System.Windows.Forms.Button LoginButton;
    }
}