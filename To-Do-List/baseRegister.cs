using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using To_Do_List.Data;
using To_Do_List.Entities;

namespace To_Do_List
{
    public partial class baseRegister : ParentForm
    {

        ApplicationDbContext db = new ApplicationDbContext();
        User userModel = new User();
        public baseRegister()
        {
            InitializeComponent();
            SetPlaceholders();
            role_comboBox.Items.Clear();
            role_comboBox.Items.AddRange(
               db.Roles
                   .Where(r =>
                       !r.Name.Equals("doctor", StringComparison.OrdinalIgnoreCase) &&
                       !r.Name.Equals("admin", StringComparison.OrdinalIgnoreCase)
                   )
                   .Select(r => r.Name)
                   .ToArray()
           );

        }

        private void SetPlaceholders()
        {
            SetPlaceholder(username_textBox, "Username");
            SetPlaceholder(email_textBox, "Email address");
            SetPlaceholder(password_textBox, "Password", isPassword: true);
        }

        private void SetPlaceholder(TextBox tb, string placeholder, bool isPassword = false)
        {
            if (tb == null)
                return;

            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            // For password textbox show placeholder in plain text
            if (isPassword)
                tb.UseSystemPasswordChar = false;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                    if (isPassword)
                        tb.UseSystemPasswordChar = true;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                    if (isPassword)
                        tb.UseSystemPasswordChar = false;
                }
            };
        }

        public bool ValidateForm(out string errors)
        {
            errors = "";
            if (string.IsNullOrWhiteSpace(username_textBox.Text) || username_textBox.Text == "Username")
                errors += "- Username is required.\n";
            if (string.IsNullOrWhiteSpace(email_textBox.Text) || email_textBox.Text == "Email address" ||
                !Regex.IsMatch(email_textBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                errors += "- A valid email address is required.\n";
            if (string.IsNullOrWhiteSpace(password_textBox.Text) || password_textBox.Text == "Password" ||
                password_textBox.Text.Length < 6)
                errors += "- Password must be at least 6 characters long.\n";
            if (string.IsNullOrWhiteSpace(role_comboBox.Text))
                errors += "- Role selection is required.\n";
            return string.IsNullOrEmpty(errors);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(out string errors))
            {
                userModel.Username = username_textBox.Text.Trim();
                userModel.Email = email_textBox.Text.Trim();
                userModel.Password = password_textBox.Text; // In real app, hash the password
                userModel.Role = db.Roles.FirstOrDefault(r => r.Name == role_comboBox.Text);
                userModel.IsActive = true;
                db.Users.Add(userModel);
                db.SaveChanges();
                //MessageBox.Show("Registration successful!");
                if (userModel.Role.Name == "student")
                {
                    this.Hide();
                    new Student_Register(userModel).Show();
                }

            }
            else
            {
                MessageBox.Show("Please fix the following errors:\n" + errors);
            }
        }

        private void logOut_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
