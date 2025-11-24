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
    internal partial class DashBoard : Form
    {
        private readonly ApplicationDbContext _context;
       
        private readonly User _User;
        internal DashBoard(User User)
        {
            _context = new ApplicationDbContext();
            _User = User;
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData() 
        {
            Label_UserName.Text = "Hello " + _User.Username;
            StudentsCount.Text = _context.Students.Count(s => s.IsAccept == true).ToString();
            DonorsCount.Text = _context.Donors.Count().ToString();
            StaffsCount.Text = _context.Staffs.Count().ToString();
            SeetionsAmount.Text = "$ "+_context.Sessions.Sum(s => s.Price).ToString();
            DonationsAmounts.Text = "$ "+ _context.Donations.Sum(d => d.Amount).ToString();
            StaffsSalaries.Text = "$ "+ _context.Staffs.Sum(s => s.Salary).ToString();
            ActivitiesDone.Text = _context.Activities.Count(a => a.ExpirationDate < DateTime.UtcNow).ToString();
            CurrentActivities.Text = _context.Activities.Count(a => a.ExpirationDate > DateTime.UtcNow).ToString();
            StudentRequest.Text = _context.Students.Count(s => s.IsAccept == false).ToString();

        }

        private void viewRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoardView view = new DashBoardView("StudentNotAccepted");
            view.ShowDialog();
        }

        private void viewAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoardView view = new DashBoardView("StudentAccepted");
            view.ShowDialog();
        }

        private void viewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoardView view = new DashBoardView("Donor");
            view.ShowDialog();
        }

        private void displayAllStaffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoardView view = new DashBoardView("Staff");
            view.ShowDialog();
        }

        private void viewDontaionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoardView view = new DashBoardView("Donation");
            view.ShowDialog();
        }

        private void viewSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashBoardView view = new DashBoardView("Session");
            view.ShowDialog();
        }

        private void createStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.ShowDialog();
        }
    }
}
