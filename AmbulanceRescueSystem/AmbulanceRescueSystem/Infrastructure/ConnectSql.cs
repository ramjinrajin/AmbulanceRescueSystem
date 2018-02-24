using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbulanceRescueSystem.Infrastructure
{
   public static class ConnectSql
    {
       public static string GetConnectionString()
       {
           //Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HeeraUber.mdf;Integrated Security=True
           return "Data Source=.;Initial Catalog=AmbulanceRescue;Integrated Security=True";
       }
    }
}
