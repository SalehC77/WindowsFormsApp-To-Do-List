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
            this.Load += viewDoctors_Load;
            this.FormClosed += viewDoctors_FormClosed;
            duration_comboBox.SelectedIndex = 0; // Set default selection

            // initialize notes placeholder behavior
            InitializeNotesPlaceholder();
        }

        private void viewDoctors_Load(object sender, EventArgs e)
        {
            LoadDoctorData();
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

            notes_richTextBox.Enter += Notes_richTextBox_Enter;
            notes_richTextBox.Leave += Notes_richTextBox_Leave;
        }

        private void Notes_richTextBox_Enter(object sender, EventArgs e)
        {
            if (notes_richTextBox.Text == notesPlaceholder)
            {
                notes_richTextBox.Text = "";
                notes_richTextBox.ForeColor = Color.Black;
            }
        }

        private void Notes_richTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(notes_richTextBox.Text))
            {
                notes_richTextBox.Text = notesPlaceholder;
                notes_richTextBox.ForeColor = Color.Gray;
            }
        }

        private bool IsNotesValid()
        {
            return !string.IsNullOrWhiteSpace(notes_richTextBox.Text)
                   && notes_richTextBox.Text != notesPlaceholder;
        }

        // Reset the appointment form controls to their default/empty state
        private void ResetAppointmentForm()
        {
            // Clear doctor selection
            if (doctors_dataGridView != null)
            {
                doctors_dataGridView.ClearSelection();
            }

            // Reset duration to placeholder index (0)
            if (duration_comboBox != null && duration_comboBox.Items.Count > 0)
            {
                duration_comboBox.SelectedIndex = 0;
            }

            // Reset session date to today
            if (session_dateTimePicker != null)
            {
                session_dateTimePicker.Value = DateTime.Today;
            }

            // Reset notes to placeholder
            if (notes_richTextBox != null)
            {
                notes_richTextBox.Text = notesPlaceholder;
                notes_richTextBox.ForeColor = Color.Gray;
            }
        }

        private void viewDoctors_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        // Validation method with error counter similar to Student_Register
        private bool ValidateAppointmentForm(out string combinedErrors)
        {
            var errors = new List<string>();

            // Ensure exactly one doctor row is selected
            if (doctors_dataGridView == null)
            {
                errors.Add("Doctors grid is missing.");
            }
            else if (doctors_dataGridView.SelectedRows == null || doctors_dataGridView.SelectedRows.Count == 0)
            {
                errors.Add("Please select a doctor.");
            }
            else if (doctors_dataGridView.SelectedRows.Count > 1)
            {
                errors.Add("Please select only one doctor.");
            }

            // Duration must be selected and cannot be the placeholder (index 0)

            if (duration_comboBox.SelectedIndex < 0 && string.IsNullOrWhiteSpace(duration_comboBox.Text))
            {
                errors.Add("Duration must be selected.");
            }
            else if (duration_comboBox.SelectedIndex == 0)
            {
                errors.Add("Please select a valid duration (do not choose the placeholder).");
            }

            // Session date must not be in the past
            if (session_dateTimePicker == null)
                errors.Add("Session date control is missing.");
            else
            {
                var selectedDate = session_dateTimePicker.Value.Date;
                if (selectedDate < DateTime.Today)
                    errors.Add("Session date cannot be in the past.");
                if (selectedDate > DateTime.Today.AddYears(1))
                    errors.Add("Session date is too far in the future.");
            }

            combinedErrors = errors.Count == 0 ? null : string.Join(Environment.NewLine, errors);
            return errors.Count == 0;
        }

        private void makeAppointment_button_Click(object sender, EventArgs e)
        {
            if (!ValidateAppointmentForm(out var errors))
            {
                MessageBox.Show(errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = doctors_dataGridView.SelectedRows[0];

            if (!int.TryParse(selectedRow.Cells[0].Value?.ToString(), out int staffId))
            {
                MessageBox.Show("Invalid Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var staff = db.Staffs.FirstOrDefault(s => s.Id == staffId);
            if (staff == null)
            {
                MessageBox.Show("Staff not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var student = db.Students.FirstOrDefault(s => s.PersonId == currentPerson.Id);
            if (student == null)
            {
                MessageBox.Show("Student record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double[] durations = { 0.5, 1, 1.5, 2 }; // in hours
            // SelectedIndex is validated to be >= 1, so subtract 1 to index durations array
            double durationHours = durations[duration_comboBox.SelectedIndex - 1];
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

            // Reset form to defaults after successful creation
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
            //new LoginForm().Show();
        }
    }
}
