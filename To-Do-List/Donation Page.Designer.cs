namespace To_Do_List
{
    partial class Donation_Page
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_log_out = new System.Windows.Forms.Label();
            this.label_make_donation = new System.Windows.Forms.Label();
            this.label_donor_home = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_amount = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label_currency = new System.Windows.Forms.Label();
            this.label_payment_method = new System.Windows.Forms.Label();
            this.comboBox_currency = new System.Windows.Forms.ComboBox();
            this.comboBox_payment_method = new System.Windows.Forms.ComboBox();
            this.button_donate = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.label_donation = new System.Windows.Forms.Label();
            this.label_purpose = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_donation_date = new System.Windows.Forms.Label();
            this.richTextBox_purpose = new System.Windows.Forms.RichTextBox();
            this.title = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label_log_out);
            this.panel2.Controls.Add(this.label_make_donation);
            this.panel2.Controls.Add(this.label_donor_home);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 822);
            this.panel2.TabIndex = 2;
            // 
            // label_log_out
            // 
            this.label_log_out.AutoSize = true;
            this.label_log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_log_out.ForeColor = System.Drawing.SystemColors.Control;
            this.label_log_out.Location = new System.Drawing.Point(54, 118);
            this.label_log_out.Name = "label_log_out";
            this.label_log_out.Size = new System.Drawing.Size(89, 25);
            this.label_log_out.TabIndex = 2;
            this.label_log_out.Text = "Log Out";
            // 
            // label_make_donation
            // 
            this.label_make_donation.AutoSize = true;
            this.label_make_donation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_make_donation.ForeColor = System.Drawing.SystemColors.Control;
            this.label_make_donation.Location = new System.Drawing.Point(14, 73);
            this.label_make_donation.Name = "label_make_donation";
            this.label_make_donation.Size = new System.Drawing.Size(175, 25);
            this.label_make_donation.TabIndex = 1;
            this.label_make_donation.Text = "Make a Donation";
            this.label_make_donation.Click += new System.EventHandler(this.label_make_donation_Click);
            // 
            // label_donor_home
            // 
            this.label_donor_home.AutoSize = true;
            this.label_donor_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_donor_home.ForeColor = System.Drawing.SystemColors.Control;
            this.label_donor_home.Location = new System.Drawing.Point(35, 27);
            this.label_donor_home.Name = "label_donor_home";
            this.label_donor_home.Size = new System.Drawing.Size(132, 25);
            this.label_donor_home.TabIndex = 0;
            this.label_donor_home.Text = "Donor Home";
            this.label_donor_home.Click += new System.EventHandler(this.label_donor_home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 47);
            this.panel1.TabIndex = 3;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(295, 131);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(93, 25);
            this.label_amount.TabIndex = 4;
            this.label_amount.Text = "Amount:";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(403, 125);
            this.textBox_amount.Multiline = true;
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(180, 35);
            this.textBox_amount.TabIndex = 5;
            this.textBox_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_amount_KeyPress);
            // 
            // label_currency
            // 
            this.label_currency.AutoSize = true;
            this.label_currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currency.Location = new System.Drawing.Point(290, 175);
            this.label_currency.Name = "label_currency";
            this.label_currency.Size = new System.Drawing.Size(107, 25);
            this.label_currency.TabIndex = 6;
            this.label_currency.Text = "Currency:";
            // 
            // label_payment_method
            // 
            this.label_payment_method.AutoSize = true;
            this.label_payment_method.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payment_method.Location = new System.Drawing.Point(256, 226);
            this.label_payment_method.Name = "label_payment_method";
            this.label_payment_method.Size = new System.Drawing.Size(181, 25);
            this.label_payment_method.TabIndex = 8;
            this.label_payment_method.Text = "Payment Method:";
            // 
            // comboBox_currency
            // 
            this.comboBox_currency.FormattingEnabled = true;
            this.comboBox_currency.Items.AddRange(new object[] {
            "US",
            "SAR",
            "YE"});
            this.comboBox_currency.Location = new System.Drawing.Point(406, 178);
            this.comboBox_currency.Name = "comboBox_currency";
            this.comboBox_currency.Size = new System.Drawing.Size(156, 24);
            this.comboBox_currency.TabIndex = 10;
            this.comboBox_currency.SelectedIndexChanged += new System.EventHandler(this.comboBox_currency_SelectedIndexChanged);
            // 
            // comboBox_payment_method
            // 
            this.comboBox_payment_method.FormattingEnabled = true;
            this.comboBox_payment_method.Items.AddRange(new object[] {
            "Visa",
            "Master Card"});
            this.comboBox_payment_method.Location = new System.Drawing.Point(454, 228);
            this.comboBox_payment_method.Name = "comboBox_payment_method";
            this.comboBox_payment_method.Size = new System.Drawing.Size(156, 24);
            this.comboBox_payment_method.TabIndex = 12;
            this.comboBox_payment_method.SelectedIndexChanged += new System.EventHandler(this.comboBox_payment_method_SelectedIndexChanged);
            // 
            // button_donate
            // 
            this.button_donate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_donate.Location = new System.Drawing.Point(471, 422);
            this.button_donate.Name = "button_donate";
            this.button_donate.Size = new System.Drawing.Size(112, 39);
            this.button_donate.TabIndex = 13;
            this.button_donate.Text = "Donate";
            this.button_donate.UseVisualStyleBackColor = true;
            this.button_donate.Click += new System.EventHandler(this.button_donate_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(624, 422);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(112, 39);
            this.button_clear.TabIndex = 14;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // picture1
            // 
            this.picture1.Image = global::To_Do_List.Properties.Resources.Donate;
            this.picture1.Location = new System.Drawing.Point(431, 477);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(398, 357);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 15;
            this.picture1.TabStop = false;
            // 
            // label_donation
            // 
            this.label_donation.AutoSize = true;
            this.label_donation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_donation.Location = new System.Drawing.Point(480, 74);
            this.label_donation.Name = "label_donation";
            this.label_donation.Size = new System.Drawing.Size(279, 29);
            this.label_donation.TabIndex = 16;
            this.label_donation.Text = "Your Donation Details";
            // 
            // label_purpose
            // 
            this.label_purpose.AutoSize = true;
            this.label_purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purpose.Location = new System.Drawing.Point(295, 316);
            this.label_purpose.Name = "label_purpose";
            this.label_purpose.Size = new System.Drawing.Size(99, 25);
            this.label_purpose.TabIndex = 17;
            this.label_purpose.Text = "Purpose:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(432, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label_donation_date
            // 
            this.label_donation_date.AutoSize = true;
            this.label_donation_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_donation_date.Location = new System.Drawing.Point(256, 275);
            this.label_donation_date.Name = "label_donation_date";
            this.label_donation_date.Size = new System.Drawing.Size(156, 25);
            this.label_donation_date.TabIndex = 20;
            this.label_donation_date.Text = "Donation Date:";
            // 
            // richTextBox_purpose
            // 
            this.richTextBox_purpose.Location = new System.Drawing.Point(412, 320);
            this.richTextBox_purpose.Name = "richTextBox_purpose";
            this.richTextBox_purpose.Size = new System.Drawing.Size(417, 90);
            this.richTextBox_purpose.TabIndex = 21;
            this.richTextBox_purpose.Text = "";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.title.Location = new System.Drawing.Point(35, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 29);
            this.title.TabIndex = 14;
            this.title.Text = "Tamkken";
            // 
            // Donation_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 855);
            this.Controls.Add(this.richTextBox_purpose);
            this.Controls.Add(this.label_donation_date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_purpose);
            this.Controls.Add(this.label_donation);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_donate);
            this.Controls.Add(this.comboBox_payment_method);
            this.Controls.Add(this.comboBox_currency);
            this.Controls.Add(this.label_payment_method);
            this.Controls.Add(this.label_currency);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Donation_Page";
            this.Text = "Donation Page";
            this.Load += new System.EventHandler(this.Donation_Page_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_log_out;
        private System.Windows.Forms.Label label_make_donation;
        private System.Windows.Forms.Label label_donor_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label_currency;
        private System.Windows.Forms.Label label_payment_method;
        private System.Windows.Forms.ComboBox comboBox_currency;
        private System.Windows.Forms.ComboBox comboBox_payment_method;
        private System.Windows.Forms.Button button_donate;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Label label_donation;
        private System.Windows.Forms.Label label_purpose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_donation_date;
        private System.Windows.Forms.RichTextBox richTextBox_purpose;
        private System.Windows.Forms.Label title;
    }
}