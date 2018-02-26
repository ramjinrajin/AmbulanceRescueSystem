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
    public partial class UpdateDetails : Form
    {
        RegDetails _ObjRegObject;

        public UpdateDetails(RegDetails ObjRegObject)
        {
            _ObjRegObject = ObjRegObject;
            InitializeComponent();
        }

        private void UpdateDetails_Load(object sender, EventArgs e)
        {
            if (_ObjRegObject != null)
            {
                txtFirstName.Text = _ObjRegObject.FirstName;
                txtLastName.Text = _ObjRegObject.LastName;
                txtMobile.Text = _ObjRegObject.Mobile.ToString();
                txtEmail.Text = _ObjRegObject.Email;
                txtUserName.Text = _ObjRegObject.UserName;
            }
            else
            {
                MessageBox.Show("NO item is selected to view");
            }
         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUserDetailsAppLayer objAppLayer = new UpdateUserDetailsAppLayer();

            RegDetails objRegUSer = new RegDetails
            {
                FirstName = string.IsNullOrWhiteSpace(txtFirstName.Text) ? "NULL" : txtFirstName.Text,
                LastName=txtLastName.Text ,
                Mobile = string.IsNullOrWhiteSpace(Convert.ToInt64(txtMobile.Text).ToString()) ? 0 : Convert.ToInt64(txtMobile.Text),
                Email=txtEmail.Text,
                UserName=txtUserName.Text
            };
           string Result= objAppLayer.UpdateUser(objRegUSer);
           MessageBox.Show(Result);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
    }
}
