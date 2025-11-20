using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace To_Do_List
{
    public partial class Donation_Page : Form
    {
        public Donation_Page()
        {
            InitializeComponent();
        }
        private void Donation_Page_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void textBox_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_donate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_amount.Text))
            {
                MessageBox.Show("Please enter the donation amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_amount.Focus(); // يرجع التركيز على الحقل
                return;
            }

            if (comboBox_currency.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the currency type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_currency.Focus();
                return;
            }

            if (comboBox_payment_method.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the payment method type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_payment_method.Focus();
                return;
            }

            int amount = int.Parse(textBox_amount.Text);
            string category1 = comboBox_currency.SelectedItem.ToString();
            string category2 = comboBox_payment_method.SelectedItem.ToString();
            string purpose =  richTextBox_purpose.Text;
            DateTime donationTime = dateTimePicker1.Value;

            MessageBox.Show($"Thanks for your donation!",
                    "Donation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox_currency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_payment_method_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_amount.Clear();
            comboBox_currency.SelectedIndex = -1;
            comboBox_payment_method.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            richTextBox_purpose.Clear();
        }

        private void label_make_donation_Click(object sender, EventArgs e)
        {
          
        }

        private void label_donor_home_Click(object sender, EventArgs e)
        {
            // Donor_Home HomeForm = new Donor_Home();

            //// عرض الفورم Home
            //HomeForm.Show();

            //// إغلاق الفورم الحالي (DonationPage)
            //this.Close();

        }
    }
}
