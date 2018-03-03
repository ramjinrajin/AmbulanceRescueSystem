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

namespace AmbulanceRescueSystem._1.PresentationLayer.UserDetails
{
    public partial class loadUpdate : Form
    {
        public loadUpdate()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            RegDetails objRegObject = new RegDetails();

            objRegObject.FirstName = UserGridView.SelectedRows[0].Cells["ColFirstName"].Value.ToString();
            objRegObject.LastName = UserGridView.SelectedRows[0].Cells["ColLastName"].Value.ToString();
            objRegObject.Email = UserGridView.SelectedRows[0].Cells["ColEmail"].Value.ToString();
            objRegObject.Mobile = Convert.ToInt64(UserGridView.SelectedRows[0].Cells["ColMobile"].Value);
            objRegObject.UserName = UserGridView.SelectedRows[0].Cells["ColUserName"].Value.ToString();


            UpdateDetails upobj = new UpdateDetails(objRegObject);
            upobj.Show();
            this.Hide();
        }

        private void LoadData()
        {
            RegisterAppLayer ObjAppLayer = new RegisterAppLayer();
            List<RegDetails> listUser = ObjAppLayer.GetPersonDetails();
            if (listUser.Count > 0)
            {
                UserGridView.Rows.Clear();
                DataGridViewRow row;
                int i = 0;
                foreach (var RegDetails in listUser)
                {
                    row = new DataGridViewRow();
                    UserGridView.Rows.Add();
                    row = UserGridView.Rows[i];
                    row.Cells["ColFirstName"].Value = RegDetails.FirstName;
                    row.Cells["ColLastName"].Value = RegDetails.LastName;
                    row.Cells["ColEmail"].Value = RegDetails.Email;
                    row.Cells["ColMobile"].Value = RegDetails.Mobile;
                    row.Cells["ColUserName"].Value = RegDetails.UserName;
                    i++;
                }

                UserGridView.ClearSelection();

            }
            else
            {
                UserGridView.Rows.Clear();
            }
        }

        private void loadUpdate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = UserGridView.SelectedRows[0].Cells["ColEmail"].Value.ToString();
            UserDeleteApplication applicationDeleteUser = new UserDeleteApplication();
            string Response = applicationDeleteUser.UserDeleteApp(Email);
            MessageBox.Show(Response);
            LoadData();

        }
    }
}
