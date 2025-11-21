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
        Person currentPerson;
        public Student_Home(Person currentPerson)
        {
            this.currentPerson = currentPerson;
            InitializeComponent();
        }

        private void Student_Home_Load(object sender, EventArgs e)
        {

        }

        private void navbarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewDoctors_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new viewDoctors(currentPerson).Show();
        }

        private void viewActivities_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new ViewActivites(currentPerson).Show();
        }
    }
}
