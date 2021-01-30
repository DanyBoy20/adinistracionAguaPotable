using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class GestionConsumos : ConexionMySQL
    {
        // REGISTRA LAS LECTURAS DEL CONSUMO PARA QUE MAS ADELANTE (FORMULARIO DE PAGO) PUEDAN SER CONSULTADAS Y PAGADAS 
        public void InsertarLecturaConsumo(int clavecliente, DateTime fechac, int cantidadc, string estado)
        {
            // conexion
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "INSERT INTO consumos (idcliente, fechalectura, cantidad, estatus) VALUES (@idC, @fechaC, @cantidadC, @estadoC)";
                    comando.Parameters.AddWithValue("@idC", clavecliente);
                    comando.Parameters.AddWithValue("@fechaC", fechac);
                    comando.Parameters.AddWithValue("@cantidadC", cantidadc);
                    comando.Parameters.AddWithValue("@estadoC", estado);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // OBTENER EL TOTAL SEGUN EL ID DEL CONSUMO
        public DataTable TotalConsumo(int consum, int clienteclave)
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT (consumos.cantidad * costos.costo) AS totales " +
                                            "FROM consumos INNER JOIN clientes " +
                                            "ON consumos.idcliente = clientes.idcliente " +
                                            "INNER JOIN tipoclientes " +
                                            "ON clientes.idtipo = tipoclientes.idtipo " +
                                            "INNER JOIN costos " +
                                            "ON tipoclientes.idtipo = costos.idtipo WHERE consumos.idconsumo = @clavecnsm AND consumos.idcliente = @claveclnt";
                    comando.Parameters.AddWithValue("@clavecnsm", consum);
                    comando.Parameters.AddWithValue("@claveclnt", clienteclave);
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        tabla.Load(lector);
                        return tabla;
                    }
                }
            }
        }

        // TRAER TODOS LOS DATOS DEL CONSUMO SEGUN EL CLIENTE Y LLENAR LOS ELEMENTOS DEL FORMULARIO (DATAGRID, COMBOBOX, TEXTBOX)
        public DataTable TablaConsumoMeses(int clavec)
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    string statusf = "pendiente";
                    comando.CommandText = "SELECT  consumos.idconsumo, consumos.fechalectura AS FECHA, consumos.estatus AS ESTADO, consumos.cantidad AS CONSUMO, " +
                                          "clientes.nombre, tipoclientes.nombre, " +
                                          "costos.costo AS PRECIOxM3, consumos.cantidad * costos.costo AS TOTAL " +
                                          "FROM consumos INNER JOIN clientes " +
                                          "ON consumos.idcliente = clientes.idcliente " +
                                          "INNER JOIN tipoclientes " +
                                          "ON clientes.idtipo = tipoclientes.idtipo " +
                                          "INNER JOIN costos " +
                                          "ON tipoclientes.idtipo = costos.idtipo WHERE consumos.idcliente = @clavecliente " +
                                          " AND consumos.estatus=@estadofact";
                    comando.Parameters.AddWithValue("@estadofact", statusf);
                    comando.Parameters.AddWithValue("@clavecliente", clavec);
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        tabla.Load(lector);
                        return tabla;
                    }
                }
            }
        }        

        // ACTUALIZAR CONSUMO (EN EL FORMULARIO DE PAGOS - SE ACTUALIZA A "PAGADO" Y SE ACTUALIZA EL MONTO QUE SE VA A PAGAR)
        public void ActualizarConsumos(string estdo, double totalpago, int claveconsu)
        {
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "UPDATE consumos SET estatus=@est, total=@totl WHERE idconsumo=@cveconsumo";
                    comando.Parameters.AddWithValue("@est", estdo);
                    comando.Parameters.AddWithValue("@totl", totalpago);
                    comando.Parameters.AddWithValue("@cveconsumo", claveconsu);
                    comando.ExecuteNonQuery();
                }
            }
        }

        // --------------------------------------- METODOS PARA CONSULTAS ------------------------------------------
        // TRAER TODOS LOS DATOS DEL CONSUMO SEGUN EL CLIENTE Y LLENAR LOS ELEMENTOS DEL FORMULARIO (DATAGRID, COMBOBOX, TEXTBOX)
        public DataTable TablaConsumosIndividuales(DateTime fechaini, DateTime fechafin, int clavec)
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT fechalectura AS FECHAS, cantidad AS CANTIDADxM3, total AS PAGADO, " +
                                          "estatus AS ESTADO FROM consumos WHERE fechalectura BETWEEN @fecha1 AND @fecha2 " +
                                          "AND idcliente = @clavecliente";
                    comando.Parameters.AddWithValue("@fecha1", fechaini);
                    comando.Parameters.AddWithValue("@fecha2", fechafin);
                    comando.Parameters.AddWithValue("@clavecliente", clavec);
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        tabla.Load(lector);
                        return tabla;
                    }
                }
            }
        }

        // TRAER TODOS LOS DATOS DEL CLIENTE (SEGUN SU TIPO) Y LLENAR LOS ELEMENTOS DEL FORMULARIO (DATAGRID)
        public DataTable TablaConsumosTotales(DateTime fechaini, DateTime fechafin, int tipoc)
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = CrearConexion())
            {
                conexion.Open();
                using (MySqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = "SELECT clientes.nombre AS CLIENTE, consumos.fechalectura AS FECHA, " +
                                          "consumos.cantidad AS CANTIDAD, consumos.total AS TOTAL, consumos.estatus AS ESTADO " +
                                          "FROM tipoclientes " +
                                          "INNER JOIN clientes ON tipoclientes.idtipo = clientes.idtipo " +
                                          "INNER JOIN consumos ON clientes.idcliente = consumos.idcliente " +
                                          "WHERE consumos.fechalectura BETWEEN @fecha1 AND @fecha2 " +
                                          "AND tipoclientes.idtipo = @cveclientes";
                    comando.Parameters.AddWithValue("@fecha1", fechaini);
                    comando.Parameters.AddWithValue("@fecha2", fechafin);
                    comando.Parameters.AddWithValue("@cveclientes", tipoc);
                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        tabla.Load(lector);
                        return tabla;
                    }
                }
            }
        }
        // --------------------------------------  FIN DE METODOS PARA CONSULTAS  -----------------------------------------------

    }
}
