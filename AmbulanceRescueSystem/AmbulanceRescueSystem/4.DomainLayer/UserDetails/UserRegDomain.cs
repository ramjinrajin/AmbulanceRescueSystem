using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using AmbulanceRescueSystem._5.DataLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._4.DomainLayer.UserDetails
{
    public class UserRegDomain
    {
        public bool SavetoDatabase(RegDetails user)
        {
            UserDataDetails data2 = new UserDataDetails();
            return data2.SaveData(user);
        }


    }
}
