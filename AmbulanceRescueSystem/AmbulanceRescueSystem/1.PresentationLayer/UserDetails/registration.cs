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
            bool Response = user.ImplementBusinessLogics(user);
            if (Response)
            {
                MessageBox.Show("Data saved sucessfully");

            }
            else
            {
                MessageBox.Show("Failed to save data");
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
