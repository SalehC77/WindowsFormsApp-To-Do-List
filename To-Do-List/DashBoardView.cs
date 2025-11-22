using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_Do_List.Data;
using To_Do_List.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace To_Do_List
{
    public partial class DashBoardView : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly string _view;
        public DashBoardView(string view)
        {
            _context = new ApplicationDbContext();
            _view = view;
            InitializeComponent();
        }

        private void DashBoardView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        
        private void LoadData()
        {
            btn_AcceptStudent.Visible = false;
            if(_view == "StudentAccepted")
            {
                dataGridView1.DataSource = _context.Students.Include(s => s.Person).Include(s => s.DisabilityType)
                    .Where(s => s.IsAccept == true)
                    .Select(s => new {
                        s.Id,
                        s.Person.FullName,
                        s.Person.PhoneNumber,
                        s.Person.Age,
                        s.EducationalStage,
                        DisabilityType = s.DisabilityType.Name
                    }).ToList();
                dataGridView1.Columns[0].HeaderText = "Student_ID";
                dataGridView1.Columns[1].HeaderText = "Student_FullName";
                dataGridView1.Columns[2].HeaderText = "Student_PhoneNumber";
                dataGridView1.Columns[3].HeaderText = "Student_Age";
                dataGridView1.Columns[4].HeaderText = "Student_EducationalStage";
                dataGridView1.Columns[5].HeaderText = "DisabilityType";
            }
            else if (_view == "StudentNotAccepted")
            {
                btn_AcceptStudent.Visible = true;
                dataGridView1.DataSource = _context.Students.Include(s => s.Person).Include(s => s.DisabilityType)
                    .Where(s => s.IsAccept == false)
                    .Select(s => new {
                        s.Id,
                        s.Person.FullName,
                        s.Person.PhoneNumber,
                        s.Person.Age,
                        s.EducationalStage,
                        DisabilityType = s.DisabilityType.Name
                    }).ToList();
                dataGridView1.Columns[0].HeaderText = "Student_ID";
                dataGridView1.Columns[1].HeaderText = "Student_FullName";
                dataGridView1.Columns[2].HeaderText = "Student_PhoneNumber";
                dataGridView1.Columns[3].HeaderText = "Student_Age";
                dataGridView1.Columns[4].HeaderText = "Student_EducationalStage";
                dataGridView1.Columns[5].HeaderText = "DisabilityType";
            }
            else if (_view == "Donor")
            {
                dataGridView1.DataSource = _context.Donors.Include(s => s.Person).Include(s => s.Donations)
                    .Select(d => new {
                        d.Id,
                        d.Person.FullName,
                        d.Person.PhoneNumber,
                        d.Person.Age,
                        DonationsAmount = d.Donations.Select(don => don.Amount).Sum(),
                        d.Person.Address,
                        DonationsCount = d.Donations.Count()
                    }).ToList();
                dataGridView1.Columns[0].HeaderText = "Donor_ID";
                dataGridView1.Columns[1].HeaderText = "Donor_FullName";
                dataGridView1.Columns[2].HeaderText = "Donor_PhoneNumber";
                dataGridView1.Columns[3].HeaderText = "Donor_Age";
                dataGridView1.Columns[4].HeaderText = "Donations Amount";
                dataGridView1.Columns[5].HeaderText = "Donor_Address";
                dataGridView1.Columns[6].HeaderText = "Donations Count";
            }
            else if (_view == "Staff")
            {
                dataGridView1.DataSource = _context.Staffs.Include(s => s.Person).Include(s => s.StaffType).Include(s => s.Sessions)
                    .Select(s => new {
                        s.Id,
                        s.Person.FullName,
                        s.Person.PhoneNumber,
                        s.Person.Age,
                        NumberOfSessions = s.Sessions.Count,
                        s.Person.Address,
                        s.StaffType.JobTitle,
                        s.Experience,
                        s.Salary,
                        s.HireDate,
                        s.NationalId
                    }).ToList();
                dataGridView1.Columns[0].HeaderText = "Staff_ID";
                dataGridView1.Columns[1].HeaderText = "Staff_FullName";
                dataGridView1.Columns[2].HeaderText = "Staff_PhoneNumber";
                dataGridView1.Columns[3].HeaderText = "Staff_Age";
                dataGridView1.Columns[4].HeaderText = "Number Of Sessions";
                dataGridView1.Columns[5].HeaderText = "Staff_Address";
                dataGridView1.Columns[6].HeaderText = "Staff_JobTitle";
                dataGridView1.Columns[7].HeaderText = "Staff_Experience";
                dataGridView1.Columns[8].HeaderText = "Staff_Salary";
                dataGridView1.Columns[9].HeaderText = "Staff_HireDate";
                dataGridView1.Columns[10].HeaderText = "Staff_NationalId";
            }
            else if (_view == "Donation")
            {
                dataGridView1.DataSource = _context.Donations.Include(d => d.Donor).Include(d => d.Donor.Person)
                    .Select(d => new { d.Id, d.Donor.Person.FullName, d.Purpose, d.Amount, d.DonationDate, d.Currency, d.PaymentMethod }).ToList();
                dataGridView1.Columns[0].HeaderText = "Donation_ID";
                dataGridView1.Columns[1].HeaderText = "Donor_FullName";
                dataGridView1.Columns[2].HeaderText = "Donor_Purpose";
                dataGridView1.Columns[3].HeaderText = "Donation_Amount";
                dataGridView1.Columns[4].HeaderText = "Donation_DonationDate";
                dataGridView1.Columns[5].HeaderText = "Donation_Currency";
                dataGridView1.Columns[6].HeaderText = "Donation_PaymentMethod";



            }
            else if (_view == "Session")
            {
                dataGridView1.DataSource = _context.Sessions.Include(s => s.Staff).Include(s => s.Staff.Person).Include(s => s.Student).Include(s => s.Student.Person)
                    .Select(s => new {
                        s.Id,
                        StaffName = s.Staff.Person.FullName,
                        StudentName = s.Student.Person.FullName,
                        s.DurationMinutes,
                        s.SessionDate,
                        s.Price,
                        s.Notes
                    }).ToList();
                dataGridView1.Columns[0].HeaderText = "Session_ID";
                dataGridView1.Columns[1].HeaderText = "Staff_FullName";
                dataGridView1.Columns[2].HeaderText = "Student_FullName";
                dataGridView1.Columns[3].HeaderText = "Session_DurationMinutes";
                dataGridView1.Columns[4].HeaderText = "Session_SessionDate";
                dataGridView1.Columns[5].HeaderText = "Session_Price";
                dataGridView1.Columns[6].HeaderText = "Session_Notes";



            }
        }

        

        private void btn_AcceptStudent_Click(object sender, EventArgs e)
        {
            var studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var student = _context.Students.FirstOrDefault(s => s.Id == studentId);
            student.IsAccept = true;
            LoadData();
           
        }
    }
}
