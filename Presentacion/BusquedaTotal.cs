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
    public partial class BusquedaTotal : Form
    {
        public BusquedaTotal()
        {
            InitializeComponent();
        }

        // BOTON PARA CERRAR EL FORMULARIO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MUESTRA UN MENSAJE INDICANDO LO QUE AQUI SE HACE
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario se utiliza para buscar consumos por tipo de clientes", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // PARA LLENAR EL DATAGRIDVIEW CON LOS DATOS DE LA CONSULTA
        public void MostrarConsumoTotal()
        {
            Consumo consumototal = new Consumo();
            Cliente clientedatos = new Cliente();
            string fechainicial = DateTime.Parse(DtpFechaInicial.Text).ToString("yyyy-MM-dd");
            string fechafinal = DateTime.Parse(DtpFechaFinal.Text).ToString("yyyy-MM-dd");
            DgvConsumoTipoC.DataSource = consumototal.ReporteConsumoTotal(fechainicial, fechafinal, CmbTipoCliente.SelectedValue.ToString());
            try
            {
                if (DgvConsumoTipoC != null || DgvConsumoTipoC.Rows.Count > 0)
                {
                    MostrarFormulario();
                    TotalConsumoFacturado();
                    TotalConsumoMetro();
                }
                else
                {
                    MessageBox.Show("NO HAY REGISTROS A MOSTRAR PARA ESE TIPO DE CLIENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("OCURRIO UN ERROR, INTENTELO MAS TARDE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        //BUSCA Y MUESTRA LOS RESULTADOS SI EXISTEN
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                MostrarConsumoTotal();
                MostrarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PRBLEMA:\n\n " + ex);
            }

        }        

        // AL CARGAR EL FORMULARIO, CARGAMOS EL COMBOBOX
        private void BusquedaTotal_Load(object sender, EventArgs e)
        {
            TipoCLientes();
        }

        // MUESTRA EL FORMULARIO AL PRESIONAR EL BOTON DE BUSCAR
        void MostrarFormulario()
        {
            DgvConsumoTipoC.Visible = true;
            LblResutadoM3.Visible = true;
            LblTotalgastado.Visible = true;
            LblMuestraM3.Visible = true;
            LblMuestraTotGasta.Visible = true;
            BtnNuevaBusqueda.Visible = true;
            CmbTipoCliente.Enabled = false;
            DtpFechaFinal.Enabled = false;
            DtpFechaInicial.Enabled = false;
            BtnBuscar.Enabled = false;
            BtnCancelar.Visible = true;
            LblNota.Visible = true;
        }

        // OCULTAR FORMULARIO
        void OcultarFormulario()
        {
            DgvConsumoTipoC.Visible = false;
            LblResutadoM3.Visible = false;
            LblTotalgastado.Visible = false;
            LblMuestraM3.Visible = false;
            LblMuestraTotGasta.Visible = false;
            BtnNuevaBusqueda.Visible = false;
            CmbTipoCliente.Enabled = true;
            DtpFechaFinal.Enabled = true;
            DtpFechaInicial.Enabled = true;
            BtnBuscar.Enabled = true;
            BtnCancelar.Visible = false;
            LblNota.Visible = false;
        }

        // METODO PARA CARGAR EL COMBOBOX CON LOS TIPOS DE CLIENTES
        public void TipoCLientes()
        {
            Cliente tablaClientes = new Cliente();
            CmbTipoCliente.DataSource = tablaClientes.MostrarTipoClientes();
            CmbTipoCliente.DisplayMember = "nombre";
            CmbTipoCliente.ValueMember = "idtipo";
        }

        // MOSTRAR EL TOTAL DEL CONSUMO
        public void TotalConsumoMetro()
        {
            int tconsumo = 0;
            for (int i = 0; i < DgvConsumoTipoC.Rows.Count; ++i)
            {
                tconsumo += Convert.ToInt32(DgvConsumoTipoC.Rows[i].Cells[2].Value);
            }
            LblMuestraM3.Text = tconsumo.ToString() + "m3";
        }

        // MOSTRAR EL TOTAL FACTURADO
        public void TotalConsumoFacturado()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in DgvConsumoTipoC.Rows)
            {
                if (fila.Cells[3] != null && fila.Cells[3].Value != null && fila.Cells[3].Value != System.DBNull.Value)
                    total += Convert.ToDecimal(fila.Cells[3].Value);
            }

            LblMuestraTotGasta.Text = "$ " + total.ToString();            
        }

        // OCULTA EL FORMULARIO PARA REALIZAR UNA NUEVA BUSQUEDA
        private void BtnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            OcultarFormulario();
        }

        // BOTON CANCELAR: CIERRA EL FORMULARIO
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
