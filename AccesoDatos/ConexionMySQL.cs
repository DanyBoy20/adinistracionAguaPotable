using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    // CLASE ABSTRACTA, PARA QUE NO PUEDA INSTANCIARSE, SOLO SERA CLASE BASE
    public abstract class ConexionMySQL
    {
        // VARIABLE PRIVADA (ACCESIBLE SOLO DESDE LA CLASE) Y DE SOLO LECTURA PARA LA CADENA DE CONEXIÓN
        private readonly string cadenaconexion;

        // CONSTRUCTOR PARA INICIALIZAR LA CADENA DE CONEXIÓN
        public ConexionMySQL()
        {
            cadenaconexion = "Server=localhost;Database=aguapotable;Uid=root;Pwd=123456789;";
        }

        // METODO PARA LA CONEXION CON VARIABLE DE TIPO MYSQLCONNECTION 
        protected MySqlConnection CrearConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaconexion);
            return conexion;
        }
    }
}
