using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AmbulanceRescueSystem.Infrastructure;
using System.Web.Security;

namespace AmbulanceRescueSystem._5.DataLayer.UserDetails
{
    public enum UserAuthResponse
    {
        USER_INACTIVE = 1,
        USER_DELETED = 2,
        USER_BLOCKED = 3,
        USER_VALID = 4,
        USER_INVALID = 5,
    }
    public class SecurityProtocol
    {
        public string AuthenticateUser(string Username, string Password)
        {
            string Resonse = "NIL";
            using (SqlConnection con = new SqlConnection(ConnectSql.GetConnectionString()))
            {
                try
                {
                    string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(Password, "SHA1");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SpAuthenticateUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", Username);
                    cmd.Parameters.AddWithValue("@Password", EncryptedPassword);
                    string Response = (string)cmd.ExecuteScalar();
                    if (Response == UserAuthResponse.USER_INACTIVE.ToString())
                    {
                        return "User is not active";
                    }
                    if (Response == UserAuthResponse.USER_DELETED.ToString())
                    {
                        return "User is deleted";
                    }
                    if (Response == UserAuthResponse.USER_BLOCKED.ToString())
                    {
                        return "User is blocked";
                    }
                    if (Response == UserAuthResponse.USER_VALID.ToString())
                    {
                        UserIdentity.username = Username;
                        return "true";
                     
                    }
                    if (Response == UserAuthResponse.USER_INVALID.ToString())
                    {
                        return "invalid credentails";
                    }
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
                finally
                {
                    con.Close();
                }
            }

            return Resonse;
        }
    }
}
