using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using AmbulanceRescueSystem._4.DomainLayer.UserDetails;
using AmbulanceRescueSystem._5.DataLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._3.BusinessLayer.UserDetails
{
    public class UserBusinessLayer
    {
        public string UserVerifyUserDetails(RegDetails user)
        {

            string ResponseMessage = "";
            bool IsValidationOK = false;
            if (!user.Email.Contains("@"))
            {
                IsValidationOK = false;
                ResponseMessage = "Email Id is not valid";
            }
            else if (user.FirstName == null || user.FirstName == "NULL")
            {
                IsValidationOK = false;
                ResponseMessage = "invalid name";
            }
            else if (user.Mobile == 0 || user.Mobile.ToString().Length < 10)
            {
                IsValidationOK = false;
                ResponseMessage = "MObile no is less than 10 digit";
            }
            else if (UserAlreadyExists(user.Email))
            {
                IsValidationOK = false;
                ResponseMessage = "User already exists";
            }
            else
            {
                IsValidationOK = true;
                ResponseMessage = "Congrats!!! Your account is sucessfully registered";
            }




            if (IsValidationOK == true)
            {
                UserRegDomain domain = new UserRegDomain();
                bool response = domain.SavetoDatabase(user);


            }

            return ResponseMessage;

        }

        private bool UserAlreadyExists(string Email)
        {
            RegisterDataLayer ObjDataLayer = new RegisterDataLayer();
            return ObjDataLayer.UserExistingCheck(Email);
        }


    }
}
