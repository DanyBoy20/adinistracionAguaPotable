using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Clientes : Form
    {
        // INSTANCIAMOS A LA CLASE CREANDO OBJETO
        Cliente clientes = new Cliente();

        public Clientes()
        {
            InitializeComponent();
        }

        // AL CARGAR EL FORMULARIO, CARGAMOS EL COMBOBOX CON TIPO DE CLIENTES Y EL DATAGRIDVIEW CON LOS CLIENTES
        private void Clientes_Load(object sender, EventArgs e)
        {
            TipoDeClientes();
            MostrarTablaCLientes();
        }

        // METODO PARA CARGAR EL COMBOBOX CON LOS TIPOS DE CLIENTES
        public void TipoDeClientes()
        {
            Cliente tablaClientes = new Cliente();
            CmbTipo.DataSource = tablaClientes.MostrarTipoClientes();
            CmbTipo.DisplayMember = "nombre";
            CmbTipo.ValueMember = "idtipo"; 
        }

        // METODO PARA CARGAR EL DATAGRIDVIEW CON LA LISTA DE CLIENTES
        public void MostrarTablaCLientes()
        {
            Cliente tablaCln = new Cliente();
            DgvTablaClientes.DataSource = tablaCln.MostrarClientes();
        }

        // BOTON PARA CERRAR EL FORMULARIO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BOTON QUE MUESTRA UNA VENTANA INDICANDO LO QUE SE HACE EN ESTE FORMULARIO
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario se utiliza para registro de clientes", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //BOTON PARA INSERTAR/GUARDAR LOS DATOS DEL NUEVO CLIENTE
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clientes.InsertaCliente(TxtNombre.Text, TxtDomicilio.Text, CmbTipo.SelectedValue);
                MessageBox.Show("CLIENTE INSERTADO CORRECTAMENTE", "DATOS GUARDADOS", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                MostrarTablaCLientes();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente error: " + ex + ", no se guardaran los datos");
                LimpiarFormulario();
            }
        }        

        // CIERRA LA VENTANA
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // LIMPIA LOS CAMPOS DEL FORMULARIO
        private void LimpiarFormulario()
        {
            TxtNombre.Text = "";
            TxtDomicilio.Text = "";
            TipoDeClientes();
        }
    }
}
