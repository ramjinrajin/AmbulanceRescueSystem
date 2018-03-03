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
            if(txtFirstName.Text=="")
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
                if (Response != "Data updated successfully")
                {

                    if (Response == "invalid name")
                    {
                        WarningFN.Visible = true;
                        WarningFN.Text = "First name is mandatory";
                    }

                }
                MessageBox.Show(Response);
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
    }
}
