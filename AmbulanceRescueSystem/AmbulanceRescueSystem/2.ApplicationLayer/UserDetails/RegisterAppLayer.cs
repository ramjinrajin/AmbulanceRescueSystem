using AmbulanceRescueSystem._5.DataLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._2.ApplicationLayer.UserDetails
{
   public class RegisterAppLayer
    {
        RegisterDataLayer objDataLayerUser = new RegisterDataLayer();
        public List<RegDetails> GetPersonDetails()
        {
            return objDataLayerUser.GetUser();
        }
    }
}
