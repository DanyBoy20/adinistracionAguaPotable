using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class GestionCostos : ConexionMySQL
    {
        // PARA MOSTRAR LOS PRECIOS EN EL DATAGRID VIEW
        public DataTable MostrarTablaPrecios()
        {
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlDataAdapter da = new MySqlDataAdapter())
                {
                    string cadenaSelect = "SELECT costos.idcosto AS CLAVE, costos.idtipo AS ID, " +
                                          "tipoclientes.nombre AS TIPO, costos.costo AS PRECIO " +
                                          "FROM costos INNER JOIN tipoclientes " +
                                          "ON costos.idtipo = tipoclientes.idtipo";
                    da.SelectCommand = new MySqlCommand(cadenaSelect, conexion);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "costos");
                    DataTable dt = ds.Tables["costos"];
                    dt.Columns[0].ReadOnly = true;
                    dt.Columns[1].ReadOnly = true;
                    dt.Columns[2].ReadOnly = true;
                    dt.Columns[3].ReadOnly = true;
                    return dt;
                }
            }
        }

        // INSERTAR PRECIOS A CLIENTES SEGUN SU TIPO
        public void InsertarPrecio(int tipo, double precio)
        {
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO costos (idtipo, costo) VALUES (@tipoC, @precioC)";                    
                    comando.Parameters.AddWithValue("@tipoC", tipo);
                    comando.Parameters.AddWithValue("@precioC", precio);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // ACTUALIZAR PRECIOS
        public void ActualizarPrecio(double precio, int idprecio)
        {
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "UPDATE costos SET costo=@precioC WHERE idcosto=@tipoC";
                    comando.Parameters.AddWithValue("@precioC", precio);
                    comando.Parameters.AddWithValue("@tipoC", idprecio);
                    comando.ExecuteNonQuery();
                }
            }
        }

    }
}
