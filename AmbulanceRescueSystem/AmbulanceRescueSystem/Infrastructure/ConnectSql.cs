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
           //Ramjin
           //Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HeeraUber.mdf;Integrated Security=True
          // return "Data Source=.;Initial Catalog=AmbulanceRescue;Integrated Security=True";
           return @"workstation id=AmbResDatabase.mssql.somee.com;packet size=4096;user id=AmbRes_SQLLogin_1;pwd=7ixayy3tdq;data source=AmbResDatabase.mssql.somee.com;persist security info=False;initial catalog=AmbResDatabase";
       }
    }
}
