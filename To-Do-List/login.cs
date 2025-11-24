using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_Do_List.Data;

namespace To_Do_List
{
    public partial class login : Form
    {
        ApplicationDbContext _db = new ApplicationDbContext();   
        public login()

        {
            InitializeComponent();
        }

        private void NavBar_Click(object sender, EventArgs e)
        {

        }

        private void SideBar_Click(object sender, EventArgs e)
        {

        }

        private void EnterYouraccountandbass_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void DontHaveAccount_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            string email = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            var user = _db.Users.Include(u => u.Role)
                         .FirstOrDefault(u =>
                             u.Email == email &&
                             u.Password == password &&
                             u.IsActive == true
                         );

            if (user == null)
            {
                MessageBox.Show("Invalid email or password.");
                return;
            }

            MessageBox.Show("Login Successful!");
            this.Hide();

            string role = user.Role.Name.ToLower();

            if (role == "admin")
            {
                
                new DashBoard(user).Show();
                //*    new AdminDashboard(user).Show();   
            }
            else if (role == "student")
            {
                new Student_Home(user).Show();     
            }
            else if (role == "doctor")
            {
               new DoctorSession(user).Show();       
            }
            else if (role == "donor")
            {
                //*   new DoctorHome(user).Show();       
            }
            else
            {
                MessageBox.Show("Unknown role. Cannot assign a page.");
            }
        }
        
        private void Createansccount_Click(object sender, EventArgs e)
        {
            baseRegister baseRegister = new baseRegister();
            baseRegister.ShowDialog();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
