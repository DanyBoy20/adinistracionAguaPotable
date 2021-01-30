using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Dominio
{
    public class Consumo
    {
        GestionConsumos gestCons = new GestionConsumos();
        GestionClientes gestcln = new GestionClientes();

        // PARA VERIFICAR QUE EL CLIENTE EXISTA
        public bool VerificarCliente(string clave)
        {
            return gestcln.VerificarClientes(Convert.ToInt32(clave));
        }
                
        // PARA REGISTRAR EL PAGO DEL CONSUMO
        public void RegistrarConsumo(string clavec, string fechac, string cantidad, string estado)
        {
            gestCons.InsertarLecturaConsumo(Convert.ToInt32(clavec), Convert.ToDateTime(fechac), Convert.ToInt32(cantidad), estado);
        }

        // ACTUALIZAR LA TABLA CONSUMOS AL REALIZAR EL PAGO ("PAGADO" Y EL MONTO DE ESE MES)
        public void ActualizarConsumo(string estdo, string totalpago, string claveconsu)
        {
            gestCons.ActualizarConsumos(estdo, Convert.ToDouble(totalpago), Convert.ToInt32(claveconsu));
        }

        // PARA LLENAR EL COMBOBOX DE PAGOS SEGUN NUMERO CLIENTE
        public DataTable ListaMesesConsumo(string cvecliente)
        {
            return gestCons.TablaConsumoMeses(Convert.ToInt32(cvecliente));
        }        

        // REGRESA EL TOTAL DEL CONSUMO SEGUN EL ID DEL CLIENTE
        public DataTable TotalBusca(string consum, string clienteclave)
        {
            return gestCons.TotalConsumo(Convert.ToInt32(consum), Convert.ToInt32(clienteclave));
        }

        // --------------------------- METODOS DE CONSULTAS REPORTES CONSUMOS INDIVIDUALES -------------------
        // METODO PARA CONSULTAS POR CONTRATO INDIVIDUAL
        public DataTable ReporteConsumoIndividual(string fechainic, string fechafinl, string clavec)
        {
            return gestCons.TablaConsumosIndividuales(Convert.ToDateTime(fechainic), Convert.ToDateTime(fechafinl),Convert.ToInt32(clavec));
        }

        // METODO PARA CONSULTAS POR TIPO DE CLIENTE
        public DataTable ReporteConsumoTotal(string fechainic, string fechafinl, string clavecl)
        {
            return gestCons.TablaConsumosTotales(Convert.ToDateTime(fechainic), Convert.ToDateTime(fechafinl), Convert.ToInt32(clavecl));
        }
        // --------------------------------------  FIN DE METODOS PARA CONSULTAS  -----------------------------------------------

    }
}
