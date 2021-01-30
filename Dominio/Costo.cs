using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Dominio
{
    public class Costo
    {
        // INSTANCIAMOS LA CLASE, CREAMOS OBJETO
        GestionCostos gc = new GestionCostos();

        // PARA LLENAR EL DATAGRIDVIEW
        public DataTable MostrarPrecios()
        {
            DataTable tablacosto = new DataTable();
            tablacosto = gc.MostrarTablaPrecios();
            return tablacosto;
        }

        // PARA INSERTAR PRECIOS A LOS REGISTROS EXISTENTES EN LA BASE DE DATOS
        public void AsignarPrecio(object tipo, string precio)
        {
            gc.InsertarPrecio(Convert.ToInt32(tipo), Convert.ToDouble(precio));
        }

        // PARA ACTUALIZAR UN PRECIO
        public void ActualizarPrecio(string precio, string idprecio)
        {
            gc.ActualizarPrecio(Convert.ToDouble(precio),Convert.ToInt32(idprecio));
        }


    }
}
