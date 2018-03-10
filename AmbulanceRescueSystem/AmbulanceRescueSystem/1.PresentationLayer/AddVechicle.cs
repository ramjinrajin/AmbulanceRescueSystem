using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using AmbulanceRescueSystem._3.BusinessLayer.UserDetails;
using AmbulanceRescueSystem._5.DataLayer.DriverDetails;
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
    public partial class AddVechicle : Form
    {
        public AddVechicle()
        {
            InitializeComponent();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            bool IsEmptySpace = false;
            if (string.IsNullOrWhiteSpace(combAddress.Text)|| 
                string.IsNullOrWhiteSpace(txtDriverName.Text)|| 
                string.IsNullOrWhiteSpace(txtGpsId.Text)|| 
                    string.IsNullOrWhiteSpace(combHospital.Text)|| 
                        string.IsNullOrWhiteSpace(txtLicenseNo.Text)|| 
                            string.IsNullOrWhiteSpace(txtPassword.Text ))
            {
                MessageBox.Show("Mandatory fields cannot be empty");
                IsEmptySpace = true;
            }
           
            if(!IsEmptySpace)
            {

                VehicleDetailsModel objVehicleModel = new VehicleDetailsModel
                {
                    Address=combAddress.SelectedText,
                    DriverName=txtDriverName.Text,
                    GPSId=txtGpsId.Text,
                    Hospital=combHospital.SelectedText,
                    LisenceNo=txtLicenseNo.Text,
                    Password=txtPassword.Text,
                    VehicleNo=txtVehicleNo.Text
                };

                DriverBusinessLayer objDriverBusinessLayer = new DriverBusinessLayer();
                string ValidationErrors = objDriverBusinessLayer.Validate(objVehicleModel,txtCnfPassword.Text);

                if(ValidationErrors=="NIL")
                {
                    DriverDataLayer objDataLayer = new DriverDataLayer();
                  string Response= objDataLayer.SaveVehicleDetails(objVehicleModel);
                  MessageBox.Show(Response);

                }
                else
                {
                    MessageBox.Show(ValidationErrors);
                }


            }
         
 


        }

        private void AddVechicle_Load(object sender, EventArgs e)
        {

        }
    }
}
