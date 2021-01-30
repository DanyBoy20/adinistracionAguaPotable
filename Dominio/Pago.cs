using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Dominio
{
    public class Pago
    {
        readonly GestionPagos gestpago = new GestionPagos();
        readonly GestionClientes verifcliente = new GestionClientes();

        // PARA VERIFICAR QUE EL CLIENTE EXISTA 
        public bool VerificarCliente(string clave)
        {
            return verifcliente.VerificarClientes(Convert.ToInt32(clave));
        }

        // PARA GUARDAR LOS PAGOS
        public void InsertarPago(string cveconsmo, string fechapag)
        {
            gestpago.InsertarPagos(Convert.ToInt32(cveconsmo), Convert.ToDateTime(fechapag));            
        }

    }
}
