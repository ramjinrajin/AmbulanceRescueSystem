using AmbulanceRescueSystem._4.DomainLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._3.BusinessLayer.UserDetails
{
    public class UserDeleteBusniessLayer
    {
        public string UserDeleteBusLogics(string Email)
        {
            if(Email==null)
            {
                return "Email id is mandatory";
            }
            else
            {
                UserDeleteDomain domainUserDelete = new UserDeleteDomain();
                if (domainUserDelete.UserDeleteDomainLayer(Email))
                {
                    return "User deleted successfully";
                }
                else
                {
                    return "Some thing went wrong";
                }
            }
        }
    }
}
