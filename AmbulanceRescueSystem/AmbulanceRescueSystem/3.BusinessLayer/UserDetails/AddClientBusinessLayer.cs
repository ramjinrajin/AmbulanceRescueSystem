using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using AmbulanceRescueSystem._4.DomainLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._3.BusinessLayer.UserDetails
{
  public  class AddClientBusinessLayer
    {
      public bool UserVerifyUserDetails(AddClientAppLayer user)
      {
          if (user.AmbulanceNo.Length > 4 )
          {
              AddClientDomainLayer domain = new AddClientDomainLayer();
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
