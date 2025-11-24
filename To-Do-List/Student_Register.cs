using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using To_Do_List.Data;
using To_Do_List.Entities;


namespace To_Do_List
{
    public partial class Student_Register : ParentForm
    {
        User userModel;
        Person personModel = new Person();
        Student studentModel = new Student();
        ApplicationDbContext db = new ApplicationDbContext();
        internal Student_Register(User userModel)
        {
            this.userModel = userModel;
            InitializeComponent();
            SetPlaceholders();
            LoadDisabilities();
            genderComboBox.SelectedIndex = 0;
        }
        private void LoadDisabilities()
        {
            var disabilityTypes = db.DisabilityTypes.Select(d => d.Name).ToArray();
            disability_comboBox.Items.Clear();
            disability_comboBox.Items.Add("choose disability type");
            disability_comboBox.Items.AddRange(disabilityTypes);
            disability_comboBox.SelectedIndex = 0;
        }
        private void SetPlaceholders()
        {
            SetPlaceholder(name_textBox, "Full Name");
            SetPlaceholder(stage_textBox, "Educational Stage");
            SetPlaceholder(phone_textBox, "Phone Number");
            SetPlaceholder(Address_textBox, "Address");
        }
        private void SetPlaceholder(TextBox tb, string placeholder)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                }
            };
        }
        private bool ValidateForm(out string combinedErrors)
        {
            var errors = new System.Collections.Generic.List<string>();

            bool IsBlank(TextBox tb, string placeholder) 
            { return string.IsNullOrWhiteSpace(tb.Text) || tb.Text.Trim() == placeholder; }

            if (IsBlank(name_textBox, "Full Name"))
                errors.Add("Full Name is required.");

            if (IsBlank(stage_textBox, "Educational Stage"))
                errors.Add("Educational Stage is required.");

            if (IsBlank(phone_textBox, "Phone Number"))
                errors.Add("Phone Number is required.");
            else
            {
                var phone = phone_textBox.Text.Trim();
                if (!Regex.IsMatch(phone, @"^\+?\d{7,15}$"))
                    errors.Add("Phone Number is invalid. Use digits only, optionally starting with + (7-15 digits).");
            }

            if (IsBlank(Address_textBox, "Address"))
                errors.Add("Address is required.");

            if ( genderComboBox.SelectedIndex <= 0)
                errors.Add("Gender must be selected.");

            if ( disability_comboBox.SelectedIndex <= 0)
                errors.Add("Disability must be selected.");

            combinedErrors = errors.Count == 0 ? null : string.Join(Environment.NewLine, errors);
            return errors.Count == 0;
        }
        private void RegisterButton_Click_1(object sender, EventArgs e)
        {

            if (!ValidateForm(out var errors))
            {
                MessageBox.Show(errors, "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            personModel.FullName = name_textBox.Text;
            personModel.Gender = genderComboBox.Text == "Male";
            personModel.Age = DateTime.Today.Year - DateOfBirth_DateTimePicker.Value.Year;
            personModel.DateOfBirth = DateOfBirth_DateTimePicker.Value.Date;
            personModel.PhoneNumber = phone_textBox.Text;
            personModel.Address = Address_textBox.Text;

            personModel.UserId = userModel.Id;
            personModel.User = userModel;

            db.People.Add(personModel);
            db.SaveChanges();


            studentModel.Person = personModel;
            studentModel.PersonId = personModel.Id;
            studentModel.EducationalStage = stage_textBox.Text;

            var disability = db.DisabilityTypes.FirstOrDefault(d => d.Name == disability_comboBox.Text);

            studentModel.DisabilityType = disability;
            studentModel.DisabilityTypeId = disability.Id;
            studentModel.IsAccept = false;

            db.Students.Add(studentModel);

            db.SaveChanges();
            MessageBox.Show("Registration Successful! Awaiting To Accept Your Request From Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            //new Student_Home(personModel).Show();
        }

        private void Student_Register_Load(object sender, EventArgs e)
        {

        }
    }
}
