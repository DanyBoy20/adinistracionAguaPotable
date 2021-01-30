using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Dominio
{
    public class Usuario
    {    
        // INSANCIAS PARA ACCESO A METODOS
        AccesoDatosUsuario AccesoUsuario = new AccesoDatosUsuario();
        GestionUsuarios gu = new GestionUsuarios();

        // PARA VALIDAR EL INICIO DE SESION AL SISTEMA
        public bool IniciarSesion(string usuario, string contrasenia)
        {
            return AccesoUsuario.VerificarCredenciales(usuario, contrasenia);
        }

        // DEVUELVE TABLA QUE SERA LA FUENTE DE DATOS PARA EL DATAGRIDVIEW
        public DataTable MostrarDatos()
        {
            DataTable tablausuario = new DataTable();
            tablausuario = gu.MostrarDatosUsuario();
            return tablausuario;

        }

        // AGREGARA/GUARDARA/INSERTARA EL NUEVO USUARIO
        public void Nuevo(string nombre, string contra, string rol)
        {
            gu.InsertarUsuario(nombre, contra, rol);

        }

        // EDITARA LOS DATOS DE UN USUARIO ELEGIDO
        public void Editar(string nombre, string contra, string rol, string id)
        {
            gu.ActualizarUuario(nombre, contra, rol, Convert.ToInt32(id));
        }

        // ELIMINARA UN USUARIO
        public void Eliminar(string ide)
        {
            gu.EliminarUsuario(Convert.ToInt32(ide));
        }
    }
}
