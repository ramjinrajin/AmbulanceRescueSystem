using AmbulanceRescueSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._5.DataLayer.UserDetails
{
  public  class UserDeleteLayer
    {
      public bool DeleteUSerDetails(string Email)
      {

          using (SqlConnection con = new SqlConnection(ConnectSql.GetConnectionString()))
          {
              try
              {
                  con.Open();

                  SqlCommand cmd = new SqlCommand("DELETE FROM REGISTER  Where Email=@Email", con);
                  cmd.Parameters.AddWithValue("@Email", Email);
                  cmd.ExecuteNonQuery();
                  return true;
              }
              catch
              {

                  return false;
              }
              finally
              {
                  con.Close();
              }


          }





      }
    }
}
