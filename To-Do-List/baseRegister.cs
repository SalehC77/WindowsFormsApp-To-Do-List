using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            role_comboBox.Items.AddRange(db.Roles.Select(r => r.Name).ToArray());
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
    }
}
