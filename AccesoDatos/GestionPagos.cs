using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class GestionPagos : ConexionMySQL
    {
        // INSERTAR EL PAGO EN LA TABLA PAGOS
        public void InsertarPagos(int cveconsum, DateTime fechapa)
        {
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO pagos (idconsumo, fechapago) VALUES (@claveconsumo, @fechaact)";
                    comando.Parameters.AddWithValue("@claveconsumo", cveconsum);
                    comando.Parameters.AddWithValue("@fechaact", fechapa);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
