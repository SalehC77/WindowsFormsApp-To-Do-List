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

namespace To_Do_List
{
    public partial class DoctorSession : Form
    {
        private readonly ApplicationDbContext _db;
        private readonly int _doctorId;

        public DoctorSession()
        {
            InitializeComponent();
            _doctorId = staffId;
            _db = new ApplicationDbContext();

        }

        private void DoctorSession_Load(object sender, EventArgs e)
        {
            LoadDoctorSession();
        }

        private void LoadDoctorSession()
        {
            var data = _db.Sessions
                .Where( s => s.StaffId == _doctorId)
                .OrderBy( s => s.SessionDate)
                .Select( s => new
                {
                    s.SessionDate,
                    s.DurationMinutes,
                    s.Price,
                    s.Notes
                }).ToList();

            dgvdoctor.AutoGenerateColumns = false;
            dgvdoctor.DataSource = data;
        }

        private void dgvdoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
