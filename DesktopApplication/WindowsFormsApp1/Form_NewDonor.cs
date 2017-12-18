using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference1;

namespace WindowsFormsApp1
{
    public partial class Form_NewDonor : Form
    {
        public ServiceReference1.ServiceBloodCrowdClient client = new ServiceReference1.ServiceBloodCrowdClient();

        public Form_NewDonor()
        {
            InitializeComponent();

            //a linha abaixo é para ir buscar os tipos sanguíneos ao dicionário
            bloodType_cbx.Items.AddRange(client.getBloodTypes().ToArray());
            gender_cbx.Items.Add("Female");
            gender_cbx.Items.Add("Male");
            string NewGUID = System.Guid.NewGuid().ToString();
            guid_textBox.Text = NewGUID;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {


            int phone_number;
            int.TryParse(phone_tb.Text, out phone_number);
            DateTime birthDate;
            DateTime.TryParse(birthdate_dateTimePicker.Text, out birthDate);

            double kG;
            double.TryParse(kg_UpDown.Text, out kG);
            int centimetros;
            int.TryParse(cm_UpDown.Text, out centimetros);
            double longt;
            double.TryParse(longtude_UpDown.Text, out longt);
            double lat;
            double.TryParse(latitude_UpDown.Text, out lat);

            bool error = false;
            if (String.IsNullOrEmpty(givenName_tb.Text))
            {
                this.errorProvider1.SetError(givenName_tb, "Given Name is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(surname_tb.Text))
            {
                this.errorProvider1.SetError(surname_tb, "Surname is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(gender_cbx.Text))
            {
                this.errorProvider1.SetError(gender_cbx, "Gender is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(birthdate_dateTimePicker.Text))
            {
                this.errorProvider1.SetError(birthdate_dateTimePicker, "Birthdate is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(mothersMaiden_tb.Text))
            {
                this.errorProvider1.SetError(mothersMaiden_tb, "Maiden Name is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(vehicle_tb.Text))
            {
                this.errorProvider1.SetError(vehicle_tb, "Vehicle is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(bloodType_cbx.Text))
            {
                this.errorProvider1.SetError(bloodType_cbx, "BloodType is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(kg_UpDown.Text))
            {
                this.errorProvider1.SetError(kg_UpDown, "Weight is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(cm_UpDown.Text))
            {
                this.errorProvider1.SetError(cm_UpDown, "Height is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(address_tb.Text))
            {
                this.errorProvider1.SetError(address_tb, "Address is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(city_tb.Text))
            {
                this.errorProvider1.SetError(city_tb, "City is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(zipCode_tb.Text))
            {
                this.errorProvider1.SetError(zipCode_tb, "Zip Code is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(state_tb.Text))
            {
                this.errorProvider1.SetError(state_tb, "State is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(longtude_UpDown.Text))
            {
                this.errorProvider1.SetError(longtude_UpDown, "Longitude is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(latitude_UpDown.Text))
            {
                this.errorProvider1.SetError(latitude_UpDown, "Latitude is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(phone_tb.Text))
            {
                this.errorProvider1.SetError(phone_tb, "Telephone is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(email_tb.Text))
            {
                this.errorProvider1.SetError(email_tb, "Email is mandatory.");
                error = true;
            }
            else
            {
                try
                {
                    var test = new System.Net.Mail.MailAddress(email_tb.Text);
                }
                catch (FormatException ex)
                {
                    this.errorProvider1.SetError(email_tb, "Email format wrong.");
                }
            }

            if (String.IsNullOrEmpty(username_tb.Text))
            {
                this.errorProvider1.SetError(username_tb, "Username is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(password_tb.Text))
            {
                this.errorProvider1.SetError(password_tb, "Password is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(company_tb.Text))
            {
                this.errorProvider1.SetError(company_tb, "Company is mandatory.");
                error = true;
            }

            if (String.IsNullOrEmpty(occupation_tb.Text))
            {
                this.errorProvider1.SetError(occupation_tb, "Occupation is mandatory.");
                error = true;
            }

            if (error == false)
            {
                Donor newDonor = new Donor();

                newDonor.Number = 0;
                newDonor.Gender = gender_cbx.Text;
                newDonor.Birthday = birthDate;
                newDonor.BloodType = bloodType_cbx.Text;
                newDonor.Centimeters = centimetros;
                newDonor.Kilograms = kG;
                newDonor.Guid = guid_textBox.Text;
                newDonor.Latitude = longt;
                newDonor.Longitude = lat;
                newDonor.MothersMaiden = mothersMaiden_tb.Text;
                newDonor.Password = password_tb.Text;
                newDonor.StateFull = state_tb.Text;
                newDonor.StreetAddress = address_tb.Text;
                newDonor.Surname = surname_tb.Text;
                newDonor.TelephoneNumber = phone_number;
                newDonor.Vehicle = vehicle_tb.Text;
                newDonor.ZipCode = zipCode_tb.Text;
                newDonor.EmailAddress = email_tb.Text;
                newDonor.GivenName = givenName_tb.Text;
                newDonor.City = city_tb.Text;
                newDonor.Username = username_tb.Text;
                newDonor.Occupation = occupation_tb.Text;
                newDonor.Company = company_tb.Text;
                newDonor.Imc = client.CalculateIMC(kG, centimetros);
                newDonor.Age = client.CalculateAge(birthDate);

                bool valida = client.addDonor(newDonor);
                if (valida)
                {
                    MessageBox.Show("Donor saved successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Process failed!" + "\nTry again!");                    
                }                
            }
            else
            {
                MessageBox.Show("Empty fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void birthdate_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string theDate = birthdate_dateTimePicker.Value.ToString("yyyy-MM-dd");
        }

        private void phone_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void surname_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
