using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Dominio
{
    public class Cliente
    {       
        // ES LA FUENTE DE DATOS PARA EL COMBOBOX (TIPO DE CLIENTE)
        public DataTable MostrarTipoClientes()
        {
            GestionClientes cliente = new GestionClientes();
            DataTable tablaTipoCliente = new DataTable();
            tablaTipoCliente = cliente.ListaTipoClientes();
            return tablaTipoCliente;
        }

        // ES LA FUENTE DE DATOS PARA EL DATAGRIDVIEW (LISTA CLIENTES)
        public DataTable MostrarClientes()
        {
            GestionClientes cliente = new GestionClientes();
            DataTable tablaCliente = new DataTable();
            tablaCliente = cliente.TablaClientes();
            return tablaCliente;
        }
        
        // PARA INSERTAR/GUARDAR CLIENTES EN LA BD
        public void InsertaCliente(string nmbr, string domi, Object tipoclnt)
        {
            GestionClientes cliente = new GestionClientes();
            cliente.InsertarCliente(nmbr, domi, Convert.ToInt32(tipoclnt));
        }

        // ES LA FUENTE DE DATOS PARA EL COMBOBOX (TIPO DE CLIENTE)
        public DataTable DatoCliente(string claveC)
        {
            GestionClientes cliente = new GestionClientes();
            DataTable tablaTipoCliente = new DataTable();
            tablaTipoCliente = cliente.DatosClientes(Convert.ToInt32(claveC));
            return tablaTipoCliente;
        }
    }
}
