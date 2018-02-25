using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using AmbulanceRescueSystem.Infrastructure;

namespace AmbulanceRescueSystem._5.DataLayer.UserDetails
{
    public class UserUpdateService
    {

        public bool UpdateUSerDetails(RegDetails ObjRegObject)
        {

            using(SqlConnection con = new SqlConnection(ConnectSql.GetConnectionString()))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE REGISTER SET FIRSTNAME=@FirstName,LASTNAME=@LastName,Email=@Email,MobileNumber=@Mobile,UserName=@UserName Where Email=@Email",con);
                    cmd.Parameters.AddWithValue("@FirstName", ObjRegObject.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", ObjRegObject.LastName);
                    cmd.Parameters.AddWithValue("@Email", ObjRegObject.Email);
                    cmd.Parameters.AddWithValue("@Mobile", ObjRegObject.Mobile);
                    cmd.Parameters.AddWithValue("@UserName", ObjRegObject.UserName);
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
