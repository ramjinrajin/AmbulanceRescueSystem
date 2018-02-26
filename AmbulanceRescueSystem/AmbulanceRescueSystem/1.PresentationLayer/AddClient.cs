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

namespace AmbulanceRescueSystem._1.PresentationLayer
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void btnAddHospital_Click(object sender, EventArgs e)
        {
            AddClientAppLayer user = new AddClientAppLayer
            {
                HospitalName = txtHospitalName.Text,
                Location = txtLocation.Text,
                Type = txtType.Text,
                AmbulanceNo = txtAmbulanceNo.Text,
               
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
    }
}
