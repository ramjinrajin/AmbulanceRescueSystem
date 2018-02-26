using AmbulanceRescueSystem._3.BusinessLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._2.ApplicationLayer.UserDetails
{
  public  class AddClientAppLayer
    {
      
          public string HospitalName { get; set; }
          public string Location { get; set; }
          public string Type { get; set; }
          public string AmbulanceNo { get; set; }
        


          public bool ImplementBusinessLogics(AddClientAppLayer user)
          {
              AddClientBusinessLayer Business = new AddClientBusinessLayer();
              return Business.UserVerifyUserDetails(user);
          }

      
    }
}
