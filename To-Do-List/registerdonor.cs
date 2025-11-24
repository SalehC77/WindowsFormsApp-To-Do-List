using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using To_Do_List.Data;
using To_Do_List.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace To_Do_List
{
    public partial class registerdonor : Form
    {

        public registerdonor()
        {
            InitializeComponent();
        }




        private void registerasdonor_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SideBar_Click(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void DOB_Click(object sender, EventArgs e)
        {

        }

        private void PhoneNumberLable_Click(object sender, EventArgs e)
        {

        }

        private void LableAddress_Click(object sender, EventArgs e)
        {

        }

        private void Genderlable_Click(object sender, EventArgs e)
        {

        }

        private void phonenumbertextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm(out string combinedErrors)
        {
            var errors = new List<string>();

            // Full Name
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
                errors.Add("Full Name is required.");

            // Gender
            if (comboBoxGender.SelectedIndex < 0)
                errors.Add("Gender must be selected.");

            // Phone Number
            if (string.IsNullOrWhiteSpace(phonenumbertextbox.Text))
                errors.Add("Phone Number is required.");
            else if (!System.Text.RegularExpressions.Regex.IsMatch(phonenumbertextbox.Text.Trim(), @"^\+?\d{7,15}$"))
                errors.Add("Phone Number is invalid.");

            // Address
            if (string.IsNullOrWhiteSpace(AddressTextBox.Text))
                errors.Add("Address is required.");

            combinedErrors = errors.Count == 0 ? null : string.Join(Environment.NewLine, errors);
            return errors.Count == 0;
        }


        private void btnRegsiter_Click(object sender, EventArgs e)
        {
      
          
        }

    }
}

