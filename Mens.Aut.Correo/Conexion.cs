using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mens.Aut.Correo
{
    class Conexion
    {
        public static string Cadena2()
        {
            SqlConnectionStringBuilder csql = new SqlConnectionStringBuilder();
            csql.DataSource = "localhost";
            csql.InitialCatalog = "EnviarCorreos";
            csql.UserID = "sa";
            csql.Password = "CUENA";
            csql.ConnectTimeout = 1000;
            return csql.ConnectionString;
        }
    }
}
