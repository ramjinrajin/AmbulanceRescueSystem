using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using AmbulanceRescueSystem._4.DomainLayer.UserDetails;
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
            else
            {
                IsValidationOK = true;
                ResponseMessage = "Data updated successfully";
            }




            if (IsValidationOK == true)
            {
                UserRegDomain domain = new UserRegDomain();
                bool response = domain.SavetoDatabase(user);
                 

            }

            return ResponseMessage;
              
        }
    }
}
