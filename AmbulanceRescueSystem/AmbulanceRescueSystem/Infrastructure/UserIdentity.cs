using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem.Infrastructure
{
  public static  class UserIdentity
    {
      public static string username;
    }


    public static class AppPool
    {
        public static bool IsAdmin
        {

            get
            {
                using (SqlConnection con = new SqlConnection(ConnectSql.GetConnectionString()))
                {
                    try
                    {

                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select Isadmin From OwnerRegistration Where Email=@Email", con);
                        cmd.Parameters.AddWithValue("@Email", UserIdentity.username);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                return (int)rdr["Isadmin"] == 1;
                            }
                        }
                        return false;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {

                        con.Close();
                    }
                }
            }

        }
    }
}
