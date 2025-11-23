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

namespace To_Do_List
{
    public partial class DoctorSession : Form
    {
        private readonly ApplicationDbContext _db;
        private readonly int _StaffId;

        public DoctorSession(int staffId)
        {
            InitializeComponent();
            _StaffId = staffId;
            _db = new ApplicationDbContext();

        }

        private void DoctorSession_Load(object sender, EventArgs e)
        {
            LoadDoctorSession();
        }

        private void LoadDoctorSession()
        {
            var data = _db.Sessions
                .Where( s => s.StaffId == _StaffId)
                .Include(s => s.Student)
                .OrderBy( s => s.SessionDate)
                .Select( s => new
                {
                    s.SessionDate,
                    s.DurationMinutes,
                    s.Price,
                    s.Notes,
                    StudentName = s.Student.Person.FullName 
                }).ToList();

            dgvdoctor.AutoGenerateColumns = true;
            dgvdoctor.DataSource = data;
        }

        private void dgvdoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
