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

        //private ComboBox genderComboBox; // Added field for gender ComboBox
        //private ComboBox disability_comboBox; // Add this field to the class to fix CS0103
        //private DateTimePicker DateOfBirth_DateTimePicker; // Add this field to the class to fix CS0103

        internal Student_Register(User userModel)
        {
            this.userModel = userModel;
            InitializeComponent();
            SetPlaceholders();
            LoadDisabilities();

            // Initialize genderComboBox if not already done by designer
            //genderComboBox = this.Controls.OfType<ComboBox>().FirstOrDefault(cb => cb.Name == "GenderComboBox");
            //disability_comboBox = this.Controls.OfType<ComboBox>().FirstOrDefault(cb => cb.Name == "DisabilityComboBox");
            //DateOfBirth_DateTimePicker = this.Controls.OfType<DateTimePicker>().FirstOrDefault(dt => dt.Name == "DateOfBirth_DateTimePicker");
            // If not found, you may need to add it to the designer or create it programmatically

            // Only run database code at runtime, not in designer
            //if (!IsInDesignMode())
            //{ 
            //}
            
        }

        //private bool IsInDesignMode()
        //{
        //    return LicenseManager.UsageMode == LicenseUsageMode.Designtime || this.DesignMode;
        //}

        private void LoadDisabilities()
        {
            var disabilityTypes = db.DisabilityTypes.Select(d => d.Name).ToArray();
            disability_comboBox.Items.Clear();
            disability_comboBox.Items.Add("choose disability type"); // Option for no disability
            disability_comboBox.Items.AddRange(disabilityTypes);
            genderComboBox.SelectedIndex = 0;
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

        // Simplified validation: checks for blanks/placeholders and phone format
        private bool ValidateForm(out string combinedErrors)
        {
            var errors = new System.Collections.Generic.List<string>();

            bool IsBlank(TextBox tb, string placeholder) =>
                tb == null || string.IsNullOrWhiteSpace(tb.Text) || tb.ForeColor == Color.Gray || tb.Text.Trim() == placeholder;

            if (IsBlank(name_textBox, "Full Name"))
                errors.Add("Full Name is required.");

            if (IsBlank(stage_textBox, "Educational Stage"))
                errors.Add("Educational Stage is required.");

            if (IsBlank(phone_textBox, "Phone Number"))
                errors.Add("Phone Number is required.");
            else
            {
                // Phone validation added: allow optional leading '+' and 7-15 digits
                var phone = phone_textBox.Text.Trim();
                if (!Regex.IsMatch(phone, @"^\+?\d{7,15}$"))
                    errors.Add("Phone Number is invalid. Use digits only, optionally starting with + (7-15 digits).");
            }

            if (IsBlank(Address_textBox, "Address"))
                errors.Add("Address is required.");

            // Gender combo must have a selection (blank check)
            if (genderComboBox == null || string.IsNullOrWhiteSpace(genderComboBox.Text) || genderComboBox.Text == "choose your gender")
                errors.Add("Gender must be selected.");

            // Disability combo: check that an item is selected and SelectedIndex is not 0 (placeholder)
            if (disability_comboBox == null || disability_comboBox.SelectedIndex <= 0)
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
            // Set Person
            personModel.FullName = name_textBox.Text;
            personModel.Gender = genderComboBox != null && genderComboBox.Text == "Male";
            personModel.Age = DateTime.Today.Year - DateOfBirth_DateTimePicker.Value.Year;
            personModel.DateOfBirth = DateOfBirth_DateTimePicker.Value.Date;
            personModel.PhoneNumber = phone_textBox.Text;
            personModel.Address = Address_textBox.Text;

            // Set foreign key if required
            personModel.UserId = userModel.Id;
            personModel.User = userModel;

            db.People.Add(personModel);
            db.SaveChanges(); // Save to get the generated Person ID

            // Set Student
            studentModel.Person = personModel;
            studentModel.PersonId = personModel.Id;
            studentModel.EducationalStage = stage_textBox.Text;

            var disability = db.DisabilityTypes.FirstOrDefault(d => d.Name == disability_comboBox.Text);

            studentModel.DisabilityType = disability;
            studentModel.DisabilityTypeId = disability.Id;
            

            studentModel.IsAccept = true;


            db.Students.Add(studentModel);

            try
            {
                db.SaveChanges();
                //if (check > 0)
                //    MessageBox.Show("Record has been saved successfully.", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //    MessageBox.Show("Failed to save record.", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record:\n" + ex.Message, "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
            new Student_Home(personModel).Show();
        }

    }
}
