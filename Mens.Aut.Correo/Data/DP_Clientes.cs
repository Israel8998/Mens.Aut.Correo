using Dapper;
using Mens.Aut.Correo.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mens.Aut.Correo.Data
{
    public class DP_Clientes
    {
        public List<Clientes> BuscarContratosPorIdCliente()
        {
            List<Clientes> clientes;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena2()))
            {
                string query = @"select * FROM Usuarios";
                clientes = con.Query<Clientes>(query).ToList();
            }
            return clientes;
        }
        public void Dispose()
        {

        }
    }

}

