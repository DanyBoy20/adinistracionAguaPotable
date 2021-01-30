using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public class GestionUsuarios : ConexionMySQL
    {        
        // TABLA PARA MOSTRAR LOS USUARIOS EN UN DATAGRIDVIEW
        public DataTable MostrarDatosUsuario()
        {
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();    
                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        string cadenaSelect = "SELECT idusuario AS CLAVE, nombre AS NOMBRE, contrasenia AS CONTRASEÑA, rol AS ROL FROM usuarios";
                        da.SelectCommand = new MySqlCommand(cadenaSelect, conexion);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "usuarios");
                        DataTable dt = ds.Tables["usuarios"];                        
                        dt.Columns[0].ReadOnly = true;
                        dt.Columns[1].ReadOnly = true;
                        dt.Columns[2].ReadOnly = true;
                        dt.Columns[3].ReadOnly = true;
                        return dt;
                    }
            }
        }

        // CREAR/INSERTAR/GUARDAR USUARIO NUEVO
        public void InsertarUsuario(string nomb, string clave, string tipo)
        {
            using(MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using(MySqlDataAdapter da = new MySqlDataAdapter())
                {
                    string cadenaInsert = "INSERT INTO usuarios (nombre, contrasenia, rol) VALUES (@nom, @clave, @tipo)";
                    da.InsertCommand = new MySqlCommand(cadenaInsert, conexion);
                    da.InsertCommand.Parameters.AddWithValue("@nom", nomb);
                    da.InsertCommand.Parameters.AddWithValue("@clave", clave);
                    da.InsertCommand.Parameters.AddWithValue("@tipo", tipo);
                    da.InsertCommand.ExecuteNonQuery();
                }
            }
        }

        #region
        // ACTUALIZAR UN USUARIO
        public void ActualizarUuario(string nomb, string clave, string tipo, int identificador)
        {
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlDataAdapter da = new MySqlDataAdapter())
                {
                    string cadenaUpdate = "UPDATE usuarios SET nombre=@nom, contrasenia=@clave, rol=@tipo WHERE idusuario=@id";
                    da.UpdateCommand = new MySqlCommand(cadenaUpdate, conexion);
                    da.UpdateCommand.Parameters.AddWithValue("@nom", nomb);
                    da.UpdateCommand.Parameters.AddWithValue("@clave", clave);
                    da.UpdateCommand.Parameters.AddWithValue("@tipo", tipo);
                    da.UpdateCommand.Parameters.AddWithValue("@id", identificador);
                    da.UpdateCommand.ExecuteNonQuery();
                }
            }
        }
        #endregion

        // ELIMINAR UN USUARIO
        public void EliminarUsuario(int identifica)
        {
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlDataAdapter da = new MySqlDataAdapter())
                {
                    string cadenaDelete = "DELETE FROM usuarios WHERE idusuario=@id";
                    da.DeleteCommand = new MySqlCommand(cadenaDelete, conexion);
                    da.DeleteCommand.Parameters.AddWithValue("@id", identifica);
                    da.DeleteCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
