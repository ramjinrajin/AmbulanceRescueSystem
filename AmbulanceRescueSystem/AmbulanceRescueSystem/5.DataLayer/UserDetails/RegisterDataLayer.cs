using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using AmbulanceRescueSystem.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem._5.DataLayer.UserDetails
{
    public class RegisterDataLayer
    {
        internal List<RegDetails> GetUser()
        {
            List<RegDetails> listUser = new List<RegDetails>();
            using (SqlConnection con = new SqlConnection(ConnectSql.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from OwnerRegistration", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        RegDetails User = new RegDetails();
                        User.FirstName = rdr["FirstName"].ToString();
                        User.LastName = rdr["LastName"].ToString();
                        User.Email = rdr["Email"].ToString();
                        User.Mobile = Convert.ToInt64(rdr["Mobile"].ToString());
                        User.UserName = rdr["UserName"].ToString();
                        listUser.Add(User);


                    }
                }
            }
            return listUser;
        }


        public bool UserExistingCheck(string EmailId)
        {
            using(SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from OwnerRegistration Where Email=@Email", con);
                    cmd.Parameters.AddWithValue("@Email", EmailId);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    return rdr.HasRows;
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
