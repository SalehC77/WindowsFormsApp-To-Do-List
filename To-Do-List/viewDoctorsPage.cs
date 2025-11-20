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
using To_Do_List.Entities;

namespace To_Do_List
{
    public partial class viewDoctorsPage : ParentForm
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Person personModel = new Person();
        public viewDoctorsPage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
