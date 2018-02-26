using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DriverLocationPlotter.Infrastructure;

namespace DriverLocationPlotter.Models
{
    public class GetAccidentLocation
    {
        public string Get()
        {
            string Location = "NIL";
            int AccidentId = 0;

            using (SqlConnection con = new SqlConnection(SqlConnect.GetConnectionString()))
            {

                try
                {
                    con.Open();
                    //currently we are taking top 1 but later we will take particular driver location accidents only
                    SqlCommand cmd = new SqlCommand("select TOP 1 Location,Accident from Accident order by 1 desc", con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            Location = rdr["Location"].ToString();
                            AccidentId = Convert.ToInt32(rdr["Accident"]);
                        }
                    }
                    rdr.Close();
                    rdr.Dispose();
                    //Delete once we plot the location
                    var cmdDelete = new SqlCommand("Delete from Accident Where Accident=@Accident ", con);
                    cmdDelete.Parameters.AddWithValue("@Accident", AccidentId);
                    cmdDelete.ExecuteNonQuery();
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

            return Location;
        }

        internal string ReportAccident(string AccLoc)
        {
            string Response = "Failed";
         

            using (SqlConnection con = new SqlConnection(SqlConnect.GetConnectionString()))
            {

                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT Into Accident (Location,DriverName,DriverId,VehicleId,VehicleNO) Values (@Location,'Varun',1,1,'KL-0167')", con);
                    cmd.Parameters.AddWithValue("@Location",AccLoc);
                    cmd.ExecuteNonQuery();
                    Response = "Accident reported successfully";
                }
                catch (Exception ex)
                {

                    Response = ex.Message;
                }
                finally
                {
                    con.Close();
                }



            }

            return Response;
        }
    }
}