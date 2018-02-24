using AmbulanceRescueSystem._3.BusinessLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._2.ApplicationLayer.UserDetails
{
   public class UpdateUserDetailsAppLayer
    {
       public string UpdateUser(RegDetails userDetails)
       {
           UserUpdateBusniessLayer objBUslayerObj = new UserUpdateBusniessLayer();
            return objBUslayerObj.UserUpdateBusinessLayer(userDetails);
       
       }
    }
}
