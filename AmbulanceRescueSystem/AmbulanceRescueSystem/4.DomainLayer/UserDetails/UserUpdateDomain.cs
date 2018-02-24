using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using AmbulanceRescueSystem._5.DataLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._4.DomainLayer.UserDetails
{
    public class UserUpdateDomain
    {
        public bool UpdateUserDetails(RegDetails ObjRegObject)
        {
            UserUpdateService objService = new UserUpdateService();
           return objService.UpdateUSerDetails(ObjRegObject);
        }
    }
}
