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
using To_Do_List.Data;

namespace To_Do_List
{
    internal partial class ViewActivites : ParentForm
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        Person _currentPerson;
        private readonly User _User;

        public ViewActivites(User user)
        {
            _User = user;
            _currentPerson = _db.People.FirstOrDefault(p => p.UserId == _User.Id);
            
            InitializeComponent();
            InitializeNotesPlaceholder();
            this.FormClosed += ViewActivites_FormClosed;
            var currentDisability = _db.Students.Where(s => s.PersonId == _currentPerson.Id)
                                       .Select(s => s.DisabilityType.Id)
                                       .FirstOrDefault();
           
            var activities = _db.Activities.Where(a => a.DisabilityTypeId == currentDisability)
                .Select(a => new
                {
                    a.Id,
                    a.Name,
                    a.StartDate,
                    a.ExpirationDate,
                    a.Description
                })
                .ToList();
            foreach (var activity in activities)
            {
                activities_dataGridView.Rows.Add(
                    activity.Id,
                    activity.Name,
                    activity.StartDate.ToShortDateString(),
                    activity.ExpirationDate.ToShortDateString(),
                    activity.Description
                );
            }
        }
        private void makeAppointment_button_Click(object sender, EventArgs e)
        {
            if(activities_dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an activity to register.");
                return;
            }

            foreach(DataGridViewRow row in activities_dataGridView.SelectedRows)
            {
                
                var actId = Convert.ToInt32(row.Cells[0].Value);
                var currentActivity = _db.Activities.FirstOrDefault(a => a.Id == actId);
                var studentCount = _db.ActivityStudents.Count(s => s.ActivityId == currentActivity.Id);
                var accept = studentCount < currentActivity.NumberOfPeopleAllowed ;

                var currentStudent = _db.Students.FirstOrDefault(s => s.PersonId == _currentPerson.Id);

                bool isRegistered = _db.ActivityStudents
                      .Any(a => a.StudentId == currentStudent.Id && a.ActivityId == actId);
                if (isRegistered)
                {
                    MessageBox.Show($"You have already registered for activity {currentActivity.Name}.");
                    continue;
                }
                _db.ActivityStudents.Add(new ActivityStudent
                {
                    StudentId = currentStudent.Id,
                    Student = currentStudent,
                    ActivityId = currentActivity.Id,
                    Activity = currentActivity,
                    IsAccept = accept,
                    RegistrationDate = DateTime.Now,
                    Notes = IsNotesValid() ? notes_richTextBox.Text : ""
                });
                _db.SaveChanges();
                MessageBox.Show(accept ? "Registration successful!" : $"You have been added to the {currentActivity.Name} activity list.");
            }
            notes_richTextBox.Text = notesPlaceholder;
        }
        private void viewDoctors_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new viewDoctors(_User).Show();
        }

        private void logOut_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new login().Show();
        }

        private string notesPlaceholder = "Enter your notes here...";
        private void InitializeNotesPlaceholder()
        {
            notes_richTextBox.Text = notesPlaceholder;
            notes_richTextBox.ForeColor = Color.Gray;

            notes_richTextBox.Enter += (s, e) =>
            {
                if (notes_richTextBox.Text == notesPlaceholder)
                {
                    notes_richTextBox.Text = "";
                    notes_richTextBox.ForeColor = Color.Black;
                }
            };

            notes_richTextBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(notes_richTextBox.Text))
                {
                    notes_richTextBox.Text = notesPlaceholder;
                    notes_richTextBox.ForeColor = Color.Gray;
                }
            };
        }
        private bool IsNotesValid()
        {
            return !string.IsNullOrWhiteSpace(notes_richTextBox.Text)
                   && notes_richTextBox.Text != notesPlaceholder;
        }
        private void ViewActivites_FormClosed(object sender, FormClosedEventArgs e)
        {
            _db.Dispose();
        }
    }
}
