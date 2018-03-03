using AmbulanceRescueSystem._3.BusinessLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._2.ApplicationLayer.UserDetails
{
   public  class UserDeleteApplication
    {
       public string UserDeleteApp(string Email)
       {
           UserDeleteBusniessLayer userBusDele = new UserDeleteBusniessLayer();
          return userBusDele.UserDeleteBusLogics(Email);
       }
       
    }
}
