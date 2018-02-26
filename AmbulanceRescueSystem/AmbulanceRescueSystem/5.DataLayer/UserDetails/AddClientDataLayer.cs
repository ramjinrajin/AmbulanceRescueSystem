using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AmbulanceRescueSystem.Infrastructure;

namespace AmbulanceRescueSystem._5.DataLayer.UserDetails
{
 public   class AddClientDataLayer
    {
     public bool SaveData(AddClientAppLayer user)
     {
         try
         {
             using (SqlConnection con = new SqlConnection(ConnectSql.GetConnectionString()))
             {
                 con.Open();
                 SqlCommand cmd = new SqlCommand("INSERT INTO AddHospital (HospitalName,Location,Type,AmbulanceNo) Values (@HospitalName,@Location,@Type,@AmbulanceNo)", con);
                 cmd.Parameters.AddWithValue("@HospitalName", user.HospitalName);
                 cmd.Parameters.AddWithValue("@Location", user.Location);
                 cmd.Parameters.AddWithValue("@Type", user.Type);
                 cmd.Parameters.AddWithValue("@AmbulanceNo", user.AmbulanceNo);
                 

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

     private void Log(string p)
     {
         throw new NotImplementedException();
     }
    }
}
