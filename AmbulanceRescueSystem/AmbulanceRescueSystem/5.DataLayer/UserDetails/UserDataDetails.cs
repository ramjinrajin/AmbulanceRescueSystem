using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmbulanceRescueSystem.Infrastructure;

namespace AmbulanceRescueSystem._5.DataLayer.UserDetails
{
  public  class UserDataDetails
    {
        public bool SaveData(RegDetails user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectSql.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO OwnerRegistration (FirstName,LastName,Email,Mobile,UserName,Password) Values (@FirstName,@LastName,@Email,@Mobile,@UserName,@Password)", con);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Mobile", user.Mobile);
                    cmd.Parameters.AddWithValue("@UserName", user.UserName);
                    cmd.Parameters.AddWithValue("@Password", user.Password);

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
