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
        ApplicationDbContext db = new ApplicationDbContext();
        Staff Staff_model = new Staff();
        Person Person_model = new Person();
        StaffType StaffType_model = new StaffType();


        int rowindex;
        public StaffForm()
        {
            InitializeComponent();
            db = new ApplicationDbContext();
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
            cmbGender.SelectedIndex = -1;
        }



        private void LoadStaffGrid()
        {
            var data = db.Staffs
                .Select(s => new
                {
                    s.Person_model.FullName,
                    s.Person_model.Age,
                    s.Person_model.Gender,
                    s.Person_model.DateOfBirth,
                    s.Person_model.PhoneNumber,
                    s.Person_model.Address,
                    s.StaffType_model.JobTitle,
                    s.Staff_model.Salary,
                    s.Staff_model.HireDate,
                    s.Staff_model.Education,
                    s.Staff_model.Experience,
                    s.Staff_model.NationalId,
                    s.Staff_model.PassportNumber,
                    s.StaffType_model.JobDescription
                });
               
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            {
                Person_model.FullName = txtFullName.Text.Trim();
                Person_model.Age = Convert.ToInt32(txtAge.Text.Trim());
                Person_model.Gender = cmbGender != null && cmbGender.Text == "Male";
                Person_model.DateOfBirth = Person_DateOfBirth.Value.Date;
                Person_model.PhoneNumber = txtPhone.Text.Trim();
                Person_model.Address = txtAddress.Text.Trim();
                Staff_model.Salary = Convert.ToInt32(txtSalary.Text.Trim());
                Staff_model.Education = txtEducation.Text.Trim();
                Staff_model.HireDate = Staff_HireDate.Value.Date;
                Staff_model.Experience = txtExperience.Text.Trim();
                Staff_model.NationalId = txtNationalld.Text.Trim();
                Staff_model.PassportNumber = txtPassportNumber.Text.Trim();
                StaffType_model.JobTitle = txtJob.Text.Trim(); 
                StaffType_model.JobDescription = txtJobDescription.Text.Trim();
                
            }

            db.People.Add(Person_model);
            db.SaveChanges();
            db.Staffs.Add(Person_model);
            db.StaffType.Add(StaffType_model);

            
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person_model.Id = rowindex;
            Staff_model.Id = rowindex;
            StaffType_model.Id = rowindex;
            Person_model.FullName = txtFullName.Text.Trim();
            Person_model.Age = Convert.ToInt32(txtAge.Text.Trim());
            Person_model.Gender = cmbGender != null && cmbGender.Text == "Male";
            Person_model.DateOfBirth = Person_DateOfBirth.Value.Date;
            Person_model.PhoneNumber = txtPhone.Text.Trim();
            Person_model.Address = txtAddress.Text.Trim();
            Staff_model.Salary = Convert.ToInt32(txtSalary.Text.Trim());
            Staff_model.Education = txtEducation.Text.Trim();
            Staff_model.HireDate = Staff_HireDate.Value.Date;
            Staff_model.Experience = txtExperience.Text.Trim();
            Staff_model.NationalId = txtNationalld.Text.Trim();
            Staff_model.PassportNumber = txtPassportNumber.Text.Trim();
            StaffType_model.JobTitle = txtJob.Text.Trim();
            StaffType_model.JobDescription = txtJob.Text.Trim();

            db.Entry(Person_model).State = EntityState.Modified;
            db.Entry(Staff_model).State = EntityState.Modified;
            db.Entry(StaffType_model).State = EntityState.Modified;

            int ckeck = db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person_model.Id = rowindex;
            Staff_model.Id = rowindex;
            StaffType_model.Id= rowindex;
            Person_model.FullName = txtFullName.Text.Trim();
            Person_model.Age = Convert.ToInt32(txtAge.Text.Trim());
            Person_model.Gender = cmbGender != null && cmbGender.Text == "Male";
            Person_model.DateOfBirth = Person_DateOfBirth.Value.Date;
            Person_model.PhoneNumber = txtPhone.Text.Trim();
            Person_model.Address = txtAddress.Text.Trim();
            Staff_model.Salary = Convert.ToInt32(txtSalary.Text.Trim());
            Staff_model.Education = txtEducation.Text.Trim();
            Staff_model.HireDate = Staff_HireDate.Value.Date;
            Staff_model.Experience = txtExperience.Text.Trim();
            Staff_model.NationalId = txtNationalld.Text.Trim();
            Staff_model.PassportNumber = txtPassportNumber.Text.Trim();
            StaffType_model.JobTitle = txtJob.Text.Trim();
            StaffType_model.JobDescription = txtJobDescription.Text.Trim();

            db.Entry(Person_model).State = EntityState.Deleted;
            db.Entry(Staff_model).State = EntityState.Deleted;
            db.Entry(StaffType_model).State = EntityState.Deleted;

            int ckeck = db.SaveChanges();
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

            Person_DateOfBirth.Value = DateTime.Today;
            Staff_HireDate.Value = DateTime.Today;
        }
    }
}
