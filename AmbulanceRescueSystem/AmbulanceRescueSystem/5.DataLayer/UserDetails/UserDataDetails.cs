using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmbulanceRescueSystem.Infrastructure;
using System.Web.Security;
 

namespace AmbulanceRescueSystem._5.DataLayer.UserDetails
{
  public  class UserDataDetails
    {
        public bool SaveData(RegDetails user)
        {
            string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "SHA1");
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectSql.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SpAddUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Mobile", user.Mobile);
                    cmd.Parameters.AddWithValue("@UserName", user.UserName);
                    cmd.Parameters.AddWithValue("@Password", EncryptedPassword);

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Log(ex.Message);
                return false;
            }
        }



        public void Log(string errormsg)
        {

        }
    }
}
