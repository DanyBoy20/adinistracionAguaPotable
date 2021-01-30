using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Usuarios : Form
    {
        // CREACION DE OBJETOS
        Usuario usuarios = new Usuario();
        // VARIABLES GLOBALES DE LA CLASE (SERAN PRIVADAS, SOLO ACCESO PARA LA CLASE DONDE SE CREAN)
        private string identificador = null;
        private bool actualizar = false;

        // CONSTRUCTOR - INICIALIZA LOS COMPONENTES
        public Usuarios()
        {
            InitializeComponent();
        }

        // AL CARGAR EL FORMULARIO
        private void Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        // CARGA EL DATAGRIDVIEW CON LA TABLA DE LA CONSULTA SQL (CAPA DOMINIO / ACCESO A CAPA DATOS)
        private void MostrarUsuarios()
        {
            Usuario tablausuarios = new Usuario();
            DgvTablaUsuarios.DataSource = tablausuarios.MostrarDatos();
        }

        // BOTON CERRAR - CIERRA EL FORMULARIO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BOTON AYUD - MUESTRA LO QUE SE HACE EN EL FORMULARIO
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario se utiliza para gestión de usuarios", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ACTIVA LAS OPCIONES PARA AGREGAR UN NUEVO USUARIO
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            BtnActualizar.Enabled = false;
            DgvTablaUsuarios.Enabled = false;
            MostrarFormulario();
        }

        // LIMPIA EL FORMULARIO DE LOS DATOS QUE SE HAYAN AGREGADO
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiarformulario();
        }

        // PARA GUARDAR LOS DATOS DEL USUARIO Y/O ACTUALIZAR LOS DATOS DEL USUARIO
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar == false)
            {
                try
                {
                    usuarios.Nuevo(TxtNombre.Text, TxtContrasenia.Text, CmbRol.Text);
                    MessageBox.Show("USUARIO INSERTADO CORRECTAMENTE", "DATOS GUARDADOS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    MostrarUsuarios();
                    Limpiarformulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio el siguiente error: " + ex + ", no se guardaran los datos");
                }
            }
            if (actualizar == true)
            {
                try
                {
                    usuarios.Editar(TxtNombre.Text, TxtContrasenia.Text, CmbRol.Text, identificador);
                    MessageBox.Show("USUARIO ACTUALIZADO CORRECTAMENTE", "DATOS ACTUALIZADOS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    MostrarUsuarios();
                    Limpiarformulario();
                    actualizar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex + ", no se actualizaran los datos");
                }
            }

        }

        // PARA PASAR LOS DATOS DEL REGISTRO ELEGIDO A LOS CAMPOS DEL FORMULARIO Y ESTOS PUEDAN SER EDITADOS
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (DgvTablaUsuarios.SelectedRows.Count > 0)
            {
                actualizar = true;
                BtnNuevo.Enabled = false;
                BtnActualizar.Enabled = true;
                DgvTablaUsuarios.Enabled = true;
                MostrarFormulario();
                TxtNombre.Text = DgvTablaUsuarios.CurrentRow.Cells[1].Value.ToString();
                TxtContrasenia.Text = DgvTablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                CmbRol.Text = DgvTablaUsuarios.CurrentRow.Cells[3].Value.ToString();
                identificador = DgvTablaUsuarios.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FILA", "ACCION REQUERIDA", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                Limpiarformulario();

            }
        }

        // ELIMINA UN USUARIO QUE PREVIAMENTE HAYA SIDO SELECCIONADO DEL DATAGRIDVIEW
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvTablaUsuarios.SelectedRows.Count > 0)
            {
                identificador = DgvTablaUsuarios.CurrentRow.Cells[0].Value.ToString();
                usuarios.Eliminar(identificador);
                MessageBox.Show("USUARIO ELIMINADO CORRECTAMENTE", "TABLA ACTUALIZADA", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                MostrarUsuarios();
                Limpiarformulario();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FILA", "ACCION REQUERIDA", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                Limpiarformulario();

            }
        }

        // MUESTRA EL FORMULARIO
        private void MostrarFormulario()
        {
            BtnEliminar.Enabled = false;
            LblNombre.Visible = true;
            LblContrasenia.Visible = true;
            LblRol.Visible = true;
            TxtNombre.Visible = true;
            TxtContrasenia.Visible = true;
            CmbRol.Visible = true;
            BtnGuardar.Visible = true;
            BtnCancelar.Visible = true;
        }

        // LIMPIA / OCULTA EL FORMULARIO
        public void Limpiarformulario()
        {
            BtnNuevo.Enabled = true;
            BtnActualizar.Enabled = true;
            BtnEliminar.Enabled = true;
            LblNombre.Visible = false;
            LblContrasenia.Visible = false;
            LblRol.Visible = false;
            TxtNombre.Visible = false;
            TxtContrasenia.Visible = false;
            CmbRol.Visible = false;
            BtnGuardar.Visible = false;
            BtnCancelar.Visible = false;
            DgvTablaUsuarios.Enabled = true;
            TxtNombre.Text = "";
            TxtContrasenia.Text = "";
            CmbRol.Text = "";
        }
    }
}
