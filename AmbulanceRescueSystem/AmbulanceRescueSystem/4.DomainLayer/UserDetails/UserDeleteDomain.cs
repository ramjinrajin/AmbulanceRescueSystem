using AmbulanceRescueSystem._5.DataLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._4.DomainLayer.UserDetails
{
    public class UserDeleteDomain
    {
        UserDeleteLayer deleteUser = new UserDeleteLayer();
        public bool UserDeleteDomainLayer(string Email)
        {
            return deleteUser.DeleteUSerDetails(Email);
        }
    }
}
