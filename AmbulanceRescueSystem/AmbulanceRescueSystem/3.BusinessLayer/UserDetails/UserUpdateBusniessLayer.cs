using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using AmbulanceRescueSystem._4.DomainLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._3.BusinessLayer.UserDetails
{
   public class UserUpdateBusniessLayer
    {
        public string UserUpdateBusinessLayer(RegDetails  ObjRegUSer)
        {
            UserUpdateDomain objUpdate = new UserUpdateDomain();
            bool IsValidationOK=true;
            string ResponseMessage = "";

            if (ObjRegUSer.Email.Length < 4)
            {
                IsValidationOK = false;
                ResponseMessage = "Email Id is less than requirent";
            }
            else if (ObjRegUSer.FirstName == null || ObjRegUSer.FirstName=="NULL")
            {
                IsValidationOK = false;
                ResponseMessage = "invalid name";
            }
            else if (ObjRegUSer.Mobile == 0 || ObjRegUSer.Mobile.ToString().Length < 10)
            {
                IsValidationOK = false;
                ResponseMessage = "MObile no is less than 10 digit";
            }
            else
            {
                IsValidationOK = true;
                ResponseMessage="Data updated successfully";
            }




            if (IsValidationOK == true)
            {
                bool Response = objUpdate.UpdateUserDetails(ObjRegUSer);
                if (Response == true)
                {
                    return ResponseMessage;
                }
                else
                {
                    return "Some thing wrong";
                }

            }
            else
            {
                return ResponseMessage;
            }
             
           
        }
    }
}
