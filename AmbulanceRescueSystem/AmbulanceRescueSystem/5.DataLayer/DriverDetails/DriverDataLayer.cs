using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AmbulanceRescueSystem.Infrastructure;
using AmbulanceRescueSystem._2.ApplicationLayer.UserDetails;

namespace AmbulanceRescueSystem._5.DataLayer.DriverDetails
{
    public class DriverDataLayer
    {
        internal string SaveVehicleDetails(VehicleDetailsModel objVehicleModel)
        {
            using (SqlConnection con = new SqlConnection(ConnectSql.GetConnectionString()))
           {
               try
               {
                   con.Open();
                   SqlCommand cmd = new SqlCommand("SpAddVehicle",con);
                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.AddWithValue("@VehicleNo", objVehicleModel.VehicleNo);
                   cmd.Parameters.AddWithValue("@DriverName", objVehicleModel.DriverName);
                   cmd.Parameters.AddWithValue("@LisenceNo", objVehicleModel.LisenceNo);
                   cmd.Parameters.AddWithValue("@GPSId", objVehicleModel.GPSId);
                   cmd.Parameters.AddWithValue("@Hospital", objVehicleModel.Hospital);
                   cmd.Parameters.AddWithValue("@Address", objVehicleModel.Address);
                   cmd.Parameters.AddWithValue("@Password", objVehicleModel.Password);
                   return (string)cmd.ExecuteScalar();
         
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
        }
    }
}
