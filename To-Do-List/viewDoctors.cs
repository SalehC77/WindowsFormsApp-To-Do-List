using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using To_Do_List.Data;
using To_Do_List.Entities;

namespace To_Do_List
{
    internal partial class viewDoctors : ParentForm
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Person currentPerson;
        public viewDoctors(Person currentPerson)
        {
            this.currentPerson = currentPerson;
            InitializeComponent();
            LoadDoctorData();
            this.FormClosed += viewDoctors_FormClosed;
            duration_comboBox.SelectedIndex = 0;
            InitializeNotesPlaceholder();
        }
        private void LoadDoctorData()
        {
            doctors_dataGridView.Rows.Clear();
            var doctorStaff = db.Staffs
                .Where(s => s.Person.User.Role.Name.ToLower() == "doctor")
                .Select(s => new
                {
                    s.Id,
                    s.Person.FullName,
                    s.Person.PhoneNumber,
                    s.Person.Address,
                    s.Experience,
                    s.StaffType.JobTitle
                })
                .ToList();

            foreach (var d in doctorStaff)
            {
                doctors_dataGridView.Rows.Add(
                    d.Id, d.FullName, d.JobTitle, d.PhoneNumber, d.Address, d.Experience
                );
            }
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
            return !string.IsNullOrWhiteSpace(notes_richTextBox.Text) && notes_richTextBox.Text != notesPlaceholder;
        }
        private void ResetAppointmentForm()
        {
            doctors_dataGridView.ClearSelection();
            duration_comboBox.SelectedIndex = 0;
            session_dateTimePicker.Value = DateTime.Today;
            notes_richTextBox.Text = notesPlaceholder;
            notes_richTextBox.ForeColor = Color.Gray;
        }
        private void viewDoctors_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }
        private bool ValidateAppointmentForm(out string combinedErrors)
        {
            var errors = new List<string>();

            if (doctors_dataGridView.SelectedRows.Count == 0)
            {
                errors.Add("Please select a doctor.");
            }
            else if (doctors_dataGridView.SelectedRows.Count > 1)
            {
                errors.Add("Please select only one doctor.");
            }

            if (duration_comboBox.SelectedIndex <= 0)
            {
                errors.Add("Duration must be selected.");
            }

            var selectedDate = session_dateTimePicker.Value.Date;
            if (selectedDate < DateTime.Today)
                errors.Add("Session date cannot be in the past.");
            if (selectedDate > DateTime.Today.AddYears(1))
                errors.Add("Session date is too far in the future.");

            combinedErrors = errors.Count == 0 ? null : string.Join(Environment.NewLine, errors);
            return errors.Count == 0;
        }
        double[] durations = {0, 0.5, 1, 1.5, 2 };
        internal void makeAppointment_button_Click(object sender, EventArgs e)
        {
            var selectedRow = doctors_dataGridView.SelectedRows[0];
            int staffId = Convert.ToInt32(selectedRow.Cells[0].Value);

            var staff = db.Staffs.First(s => s.Id == staffId);
            var student = db.Students.First(s => s.PersonId == currentPerson.Id);
  
            double durationHours = durations[duration_comboBox.SelectedIndex];
            int durationMinutes = (int)(durationHours * 60);
            var price = durationMinutes * 2; // $2 per minute
            var notes = IsNotesValid() ? notes_richTextBox.Text : "";

            Session newSession = new Session
            {
                StaffId = staffId,
                StudentId = student.Id,
                DurationMinutes = durationMinutes,
                SessionDate = session_dateTimePicker.Value,
                Price = price,
                Notes = notes
            };

            db.Sessions.Add(newSession);
            db.SaveChanges();

            MessageBox.Show("Session successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetAppointmentForm();
        }
        private void viewActivities_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new ViewActivites(currentPerson).Show();
        }
        private void logOut_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new Login().Show();
        }
        private void duration_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price_label.Text = $" Price : {durations[duration_comboBox.SelectedIndex] * 2 * 60}";
        }
    }
}
