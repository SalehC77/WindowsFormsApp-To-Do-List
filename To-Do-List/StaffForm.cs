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
using System.Data.Entity;
using To_Do_List.Entities;

namespace To_Do_List
{
    public partial class StaffForm : Form
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        User _user_model = new User();
        Person _person_model = new Person();
        Staff _staff_model = new Staff();
        int _staffId;
        public StaffForm()
        {
            InitializeComponent();
            _db = new ApplicationDbContext();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            LoadStaffGrid();
        }

        private void GenderCombo()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
           
        }



        private void LoadStaffGrid()
        {
            dgvStaff.DataSource = _db.Staffs.Include(s => s.Person).Include(s => s.StaffType)
                .Select(s => new
                {
                    s.Person.FullName,
                    s.Person.Age,
                    s.Person.Gender,
                    s.Person.DateOfBirth,
                    s.Person.PhoneNumber,
                    s.Person.Address,
                    s.StaffType.JobTitle,
                    s.Salary,
                    s.HireDate,
                    s.Education,
                    s.Experience,
                    s.NationalId,
                    s.PassportNumber,
                    s.StaffType.JobDescription
                });
            comboBox_StaffType.DataSource = _db.StaffTypes.Select(s => s.JobTitle).ToList();
            GenderCombo();

        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _staffId = Convert.ToInt32(dgvStaff.CurrentRow.Cells[0].Value);
            var model = _db.Staffs.Include(s=> s.Person).Include(s => s.StaffType)
                .FirstOrDefault(s => s.Id == _staffId);

            txtFullName.Text = model.Person.FullName;
            txtAge.Text = model.Person.Age.ToString();
            cmbGender.SelectedItem = model.Person.Gender == true ? "Male":"False";
            Person_DateOfBirth.Value = model.Person.DateOfBirth;
            txtPhone.Text = model.Person.PhoneNumber;
            txtAddress.Text = model.Person.Address;

            txtSalary.Text = model.Salary.ToString();
            txtEducation.Text = model.Education;
            Staff_HireDate.Value = model.HireDate;
            txtExperience.Text = model.Experience;
            txtNationalld.Text = model.NationalId;
            txtPassportNumber.Text = model.PassportNumber;
            comboBox_StaffType.SelectedItem = model.StaffType.JobTitle;




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            _person_model.FullName = txtFullName.Text.Trim();
            _person_model.Age = Convert.ToInt32(txtAge.Text.Trim());
            _person_model.Gender = cmbGender.SelectedItem.ToString() == "Male" ? true : false;
            _person_model.DateOfBirth = Person_DateOfBirth.Value;
            _person_model.PhoneNumber = txtPhone.Text.Trim();
            _person_model.Address = txtAddress.Text.Trim();

            _staff_model.Salary = Convert.ToInt32(txtSalary.Text.Trim());
            _staff_model.Education = txtEducation.Text.Trim();
            _staff_model.HireDate = Staff_HireDate.Value.Date;
            _staff_model.Experience = txtExperience.Text.Trim();
            _staff_model.NationalId = txtNationalld.Text.Trim();
            _staff_model.PassportNumber = txtPassportNumber.Text.Trim();
            _staff_model.StaffTypeId = _db.StaffTypes.FirstOrDefault(s => s.JobTitle == comboBox_StaffType.SelectedItem.ToString()).Id;

            _user_model.RoleId = _db.Roles.FirstOrDefault(r => r.Name == "Staff").Id;
            _user_model.Username = _person_model.FullName;
            _user_model.Password = _person_model.PhoneNumber;
            _user_model.Email = $"{_person_model.FullName}@Gmail.com";

            _db.Users.Add(_user_model);
            _db.SaveChanges();
            _person_model.UserId = _user_model.Id;
            
            _db.People.Add(_person_model);
            _db.SaveChanges();
            _staff_model.PersonId = _person_model.Id;
            
            _db.Staffs.Add(_staff_model);
            _db.SaveChanges();

            int ckeck = _db.SaveChanges();
            if (ckeck > 0)
            {
                MessageBox.Show("Record Added successfully ", "Add Record",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffGrid();

            }
            else
            {
                MessageBox.Show("Fail to Add a record ", "Add Error",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadStaffGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _person_model.FullName = txtFullName.Text.Trim();
            _person_model.Age = Convert.ToInt32(txtAge.Text.Trim());
            _person_model.Gender = cmbGender.SelectedItem.ToString() == "Male" ? true : false;
            _person_model.DateOfBirth = Person_DateOfBirth.Value;
            _person_model.PhoneNumber = txtPhone.Text.Trim();
            _person_model.Address = txtAddress.Text.Trim();

            _staff_model.Salary = Convert.ToInt32(txtSalary.Text.Trim());
            _staff_model.Education = txtEducation.Text.Trim();
            _staff_model.HireDate = Staff_HireDate.Value.Date;
            _staff_model.Experience = txtExperience.Text.Trim();
            _staff_model.NationalId = txtNationalld.Text.Trim();
            _staff_model.PassportNumber = txtPassportNumber.Text.Trim();
            _staff_model.StaffTypeId = _db.StaffTypes.FirstOrDefault(s => s.JobTitle == comboBox_StaffType.SelectedItem.ToString()).Id;

            _user_model.RoleId = _db.Roles.FirstOrDefault(r => r.Name == "Staff").Id;
            _user_model.Username = _person_model.FullName;
            _user_model.Password = _person_model.PhoneNumber;
            _user_model.Email = $"{_person_model.FullName}@Gmail.com";

            _db.Entry(_user_model).State = EntityState.Modified;
            _db.Entry(_person_model).State = EntityState.Modified;
            _db.Entry(_staff_model).State = EntityState.Modified;

            int ckeck = _db.SaveChanges();
            if (ckeck > 0)
            {
                MessageBox.Show("Record Updated successfully ", "Update Record",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffGrid();
                
            }
            else
            {
                MessageBox.Show("Fail to Update a record ", "Update Error",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadStaffGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var model = _db.Staffs.Include(s => s.Person.User).Include(s => s.Person).Include(s => s.StaffType)
               .FirstOrDefault(s => s.Id == _staffId);

            _db.Entry(model.Person.User).State = EntityState.Deleted;
            _db.Entry(model.Person).State = EntityState.Deleted;
            _db.Entry(model).State = EntityState.Deleted;

            int ckeck = _db.SaveChanges();
            if (ckeck > 0)
            {
                MessageBox.Show("Record Deleted successfully ", "Delete Record",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffGrid();

            }
            else
            {
                MessageBox.Show("Fail to Delete a record ", "Delete Error",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadStaffGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAge.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtSalary.Clear();
            txtEducation.Clear();
            txtExperience.Clear();
            txtNationalld.Clear();
            txtPassportNumber.Clear();
            txtJob.Clear();
            txtJobDescription.Clear();

            cmbGender.SelectedIndex = -1;
            comboBox_StaffType.SelectedIndex = -1;
            Person_DateOfBirth.Value = DateTime.Today;
            Staff_HireDate.Value = DateTime.Today;
        }
    }
}
