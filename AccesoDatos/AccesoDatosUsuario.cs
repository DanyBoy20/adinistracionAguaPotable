using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    // HERENCIA - ACCESO A DATOS HEREDA DE CONEXION MYSQL
    public class AccesoDatosUsuario : ConexionMySQL
    {
        // METODO PARA VALIDAR EL INICIO DE SESION CON DATOS DE LA BASE DE DATOS
        public bool VerificarCredenciales(string usuario, string contrasenia)
        {
            // DENTRO DE UN BLOQUE USING INSERTO LA CONEXION.
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = new MySqlCommand())
                {
                    #region
                    comando.Connection = conexion;
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contra", contrasenia);
                    comando.CommandText = "SELECT * FROM usuarios WHERE nombre=@usuario AND contrasenia=@contra";
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
                    #endregion
                }
            }
        }        
    }
}
