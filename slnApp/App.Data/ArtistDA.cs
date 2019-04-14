using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class ArtistDA:BaseConnection
    {
        /// <summary>
        /// Permite Obtener la cantidad de registros
        /// que existen en la tabla de artista
        /// </summary>
        /// <returns>Retorna el número de registros</returns>
        public int GetCound()
        {
            var result = 0;

            var sql = "SELECT COUNT(1) FROM Artist";
            /*1.- Creando la instancia del objeto connection*/
            using (IDbConnection cn = new SqlConnection(this.ConnectionString))
            {
                /*2.- Creando el objeto command */
                IDbCommand cmd = new SqlCommand(sql);
                cmd.Connection = cn;

                cn.Open(); // Abriendo la conexión a la base de datos

                result = (int)cmd.ExecuteScalar();

            }


            return result;
        }

    }
}
