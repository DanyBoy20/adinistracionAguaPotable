using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class GestionClientes : ConexionMySQL
    {
        // PARA ASIGNAR LOS VALORES DEL TIPO DE CLIENTE EN UN COMBO BOX
        public DataTable ListaTipoClientes()
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT * FROM tipoclientes";
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        tabla.Load(lector);  
                        return tabla;
                    }                   
                }
            }
        }

        // MOSTRARA EN UN DATA GRID VIEW EL LISTADO DE CLIENTES
        public DataTable TablaClientes()
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT clientes.idcliente AS CONTRATO, clientes.nombre AS NOMBRE, " +
                                          "clientes.domicilio AS DOMICILIO, tipoclientes.nombre AS TIPO " +
                                          "FROM clientes INNER JOIN tipoclientes " +
                                          "ON clientes.idtipo = tipoclientes.idtipo ORDER BY clientes.idcliente";
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        tabla.Load(lector);
                        return tabla;
                    }
                }
            }
        }

        // INSERTAR NUEVO CLINTE
        public void InsertarCliente(string nombreC, string domicilioC, int tipoC)
        {
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO clientes (nombre, domicilio, idtipo) VALUES (@nom, @dom, @tipo)";
                    comando.Parameters.AddWithValue("@nom", nombreC);
                    comando.Parameters.AddWithValue("@dom", domicilioC);
                    comando.Parameters.AddWithValue("@tipo", tipoC);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // BUSCAR CLIENTES ( ESTE SERA PARA CUALQUIER CONSULTA: PARA LOS PAGOS Y REPORTES)
        public bool VerificarClientes(int clavec)
        {
            // DENTRO DE UN BLOQUE USING INSERTO LA CONEXION.
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand())
                {
                    comando.Connection = conexion;
                    comando.Parameters.AddWithValue("@id", clavec);
                    comando.CommandText = "SELECT * FROM clientes WHERE idcliente=@id";
                    comando.CommandType = CommandType.Text;
                    MySqlDataReader lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        // DATOS DEL CLIENTE PARA REPORTES       
        public DataTable DatosClientes(int clavec)
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT clientes.nombre, tipoclientes.nombre FROM clientes INNER JOIN tipoclientes " +
                                          "ON clientes.idtipo = tipoclientes.idtipo WHERE clientes.idcliente = @cvecliente";
                    comando.Parameters.AddWithValue("@cvecliente", clavec);
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        tabla.Load(lector);
                        return tabla;
                    }
                }
            }
        }
    }
}
