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
    public partial class Precios : Form
    {
        // INSTANCIA GLOBAL DE LA CLASE COSTO - CREACION DE OBJETO
        Costo precio = new Costo(); 
        // VARIABLES DE LA CLASE
        private string identificador = null;
        private bool actualizar = false;

        // CONSTRUCTOR
        public Precios()
        {
            InitializeComponent();
        }

        // AL CARGAR EL FORMULARIO, CARGAMOS LA TABLA CON LOS DATOS DE LOS COSTOS DE LOS TIPOS DE CLIENTES
        // TAMBIEN CARGAMOS EL COMBOBOX PARA MOSTRAR LOS TIPOS DE CLIENTES EXISTENTES
        private void Precios_Load(object sender, EventArgs e)
        {
            TipoCLientes();
            MostrarTablaPrecios();
        }

        // METODO PARA CARGAR EL COMBOBOX CON LOS TIPOS DE CLIENTES
        public void TipoCLientes()
        {
            Cliente tablaClientes = new Cliente();
            CmbTipo.DataSource = tablaClientes.MostrarTipoClientes();
            CmbTipo.DisplayMember = "nombre";
            CmbTipo.ValueMember = "idtipo";
        }

        // METODO PARA CARGAR EL DATAGRIDVIEW DESDE LA FUENTE DE DATOS (BASE DE DATOS)
        private void MostrarTablaPrecios()
        {
            Costo precioCliente = new Costo();
            DgvTablaPrecios.DataSource = precioCliente.MostrarPrecios();
        }

        // CIERRA EL FORMULARIO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BOTON QUE MUESTRA UNA DESCRIPCION DE LO QUE SE HACE EN ESTE FORMULARIO
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario se utiliza para registro de precios", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // BOTON PARA INSERTAR/GUARDAR/ACTUALIZAR PRECIOS
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar == false)
            {
                try
                {
                    precio.AsignarPrecio(CmbTipo.SelectedValue, TxtPrecio.Text);
                    MessageBox.Show("PRECIO INSERTADO CORRECTAMENTE", "DATOS GUARDADOS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    MostrarTablaPrecios();
                    LimpiarFormulario();
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
                    precio.ActualizarPrecio(TxtPrecio.Text, identificador);
                    MessageBox.Show("PRECIO ACTUALIZADO CORRECTAMENTE", "DATOS ACTUALIZADOS", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    MostrarTablaPrecios();
                    LimpiarFormulario();
                    actualizar = false;
                    CmbTipo.Enabled = true;                    
                    TxtPrecio.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex + ", no se actualizaran los datos");
                }
            }
        }

        // PERMITE EDITAR/ACTUALIZAR/CAMBIAR PRECIO SEGUN EL REGISTRO SELECCIONADO DEL DATAGRIDVIEW
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvTablaPrecios.SelectedRows.Count > 0)
            {
                actualizar = true;
                CmbTipo.Text = DgvTablaPrecios.CurrentRow.Cells[2].Value.ToString();
                CmbTipo.SelectedValue = DgvTablaPrecios.CurrentRow.Cells[1].Value;
                CmbTipo.Enabled = false;
                TxtPrecio.Text = DgvTablaPrecios.CurrentRow.Cells[3].Value.ToString();
                identificador = DgvTablaPrecios.CurrentRow.Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UNA FILA", "ACCION REQUERIDA", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                LimpiarFormulario();

            }
        }

        // CIERRA EL FORMULARIO
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // PERMITE LIMPIAR LOS CAMPOS DEL FORMULARIO
        public void LimpiarFormulario()
        {
            TxtPrecio.Text = "";
            TipoCLientes();
        }
    }
}
