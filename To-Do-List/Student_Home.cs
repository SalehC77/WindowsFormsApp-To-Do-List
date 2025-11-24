using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_Do_List.Entities;

namespace To_Do_List
{
    internal partial class Student_Home : ParentForm
    {
        private readonly User _User;
        public Student_Home(User user)
        {
            this._User = user;
            InitializeComponent();
        }
        private void viewDoctors_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new viewDoctors(_User).Show();
        }
        private void viewActivities_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new ViewActivites(_User).Show();
        }
        private void logOut_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private void Student_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
