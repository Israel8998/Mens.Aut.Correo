using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mens.Aut.Correo.Modelo
{
    public class DP_Beneficios : IDisposable
    {
        public List<Beneficios> BuscarBeneficios()
        {
            List<Beneficios> beneficios;

            using (MySqlConnection con = new MySqlConnection(Conexion.Cadena2()))
            {
                string query = @"SELECT * FROM Archica_Productos_Especiales as ape " +
                                "where " +
                                "ape.Estado=1";
                beneficios = con.Query<Beneficios>(query).ToList();
            }
            return beneficios;
        }
        public Beneficios BuscarBeneficioId(string IdBeneficio)
        {
            Beneficios beneficios;
            using (MySqlConnection con = new MySqlConnection(Conexion.Cadena2()))
            {
                string query = @"SELECT * FROM Archica_Productos_Especiales as ape " +
                                "where " +
                                "ape.Estado=1 and Id=" + IdBeneficio + "";
                beneficios = con.Query<Beneficios>(query).FirstOrDefault();
            }
            return beneficios;
        }
        public void Dispose()
        {

        }
    }
}
