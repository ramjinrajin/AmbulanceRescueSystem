using AmbulanceRescueSystem._3.BusinessLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._2.ApplicationLayer.UserDetails
{
   public class RegDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Mobile{ get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Confirm { get; set; }


        public string ImplementBusinessLogics(RegDetails user)
        {
            UserBusinessLayer Business = new UserBusinessLayer();
            return Business.UserVerifyUserDetails(user);
        }

    }
}
