using AmbulanceRescueSystem._1.PresentationLayer;
using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbulanceRescueSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                WarningFN.Visible = true;
                WarningFN.Text = "First name is mandatory";
            }
            else
            {
                RegDetails user = new RegDetails
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Mobile = Convert.ToInt64(txtMobile.Text),
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    Confirm = txtConfirm.Text
                };

                string Response = user.ImplementBusinessLogics(user);
                if (Response != "Congrats!!! Your account is sucessfully registered")
                {

                    if (Response == "invalid name")
                    {
                        WarningFN.Visible = true;
                        WarningFN.Text = "First name is mandatory";
                    }

                }
                MessageBox.Show(Response);
                if (Response == "Congrats!!! Your account is sucessfully registered")
                {
                    this.Hide();
                    Login objLogin = new Login();
                    objLogin.Show();
                }

            }




        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login objLogin = new Login();
            objLogin.Show();
        }
    }
}
