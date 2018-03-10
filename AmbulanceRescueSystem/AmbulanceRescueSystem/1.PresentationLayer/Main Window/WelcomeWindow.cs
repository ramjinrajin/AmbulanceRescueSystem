using AmbulanceRescueSystem._1.PresentationLayer.UserDetails;
using AmbulanceRescueSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbulanceRescueSystem._1.PresentationLayer.Main_Window
{
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void WelcomeWindow_Load(object sender, EventArgs e)
        {
            btnAddVehicle.Enabled = true;
            btnManageVehicle.Enabled = true;
            if (AppPool.IsAdmin)
            {
                btnAddClient.Enabled = true;
                btnManageClient.Enabled = true;
            }
            else
            {
                btnAddClient.Enabled = false;
                btnManageClient.Enabled = false;
            }

        }



        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddVechicle veh = new AddVechicle();
            veh.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddClient objClient = new AddClient();
            objClient.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            loadUpdate UserManage = new loadUpdate();
            UserManage.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login objLogin = new Login();
            objLogin.Show();
        }


    }
}
