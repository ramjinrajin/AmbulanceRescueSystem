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
        public bool UserVerifyUserDetails(RegDetails user)
        {
            if (user.FirstName.Length > 4 && user.LastName.Length > 4)
            {
                UserRegDomain domain = new UserRegDomain();
                bool response = domain.SavetoDatabase(user);
                return response;
            }
            else
            {
                return false;
            }
        }
    }
}
