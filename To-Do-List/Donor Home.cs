using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_Do_List.Entities;

namespace To_Do_List
{
    internal partial class Donor_Home : Form
    {
        Donor _Donor;
        public Donor_Home(Donor donor)
        {
            InitializeComponent();
            _Donor = donor;
        }

        private void label_gender_Click(object sender, EventArgs e)
        {

        }

        private void label_make_donation_Click(object sender, EventArgs e)
        {
            Donation_Page donationForm = new Donation_Page(_Donor);
            donationForm.Show();

            this.Hide();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void title_Click_1(object sender, EventArgs e)
        {

        }

        private void Donor_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
