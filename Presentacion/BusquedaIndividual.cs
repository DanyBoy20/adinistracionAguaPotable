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
    public partial class BusquedaIndividual : Form
    {
        public BusquedaIndividual()
        {
            InitializeComponent();
        }

        // BOTON PARA CERRAR EL FORMULARIO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BOTON DE AYUDA, SOLO MUESTRA UN MENSAJE PARA DESCRIBIR LO QUE SE HACE EN EL FORMULARIO
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario se utiliza para buscar consumos por clientes", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // MUESTRA LOS ELEMENTOS DEL FORMULARIO
        private void MostrarFormulario()
        {
            DgvDatoCliente.Visible = true;
            DgvConsumoIndividual.Visible = true;
            LblTotalM3Periodo.Visible = true;
            LblTotPag.Visible = true;
            LblTotalCon.Visible = true;
            LblTotalgastado.Visible = true;
            LblLineaDivBottom.Visible = true;
            BtnNuevaBusqueda.Visible = true;
            LblNombreCliente.Visible = true;
            LblTipo.Visible = true;
            LblNota.Visible = true;
            TxtNombreCliente.Visible = true;
            TxtNombreCliente.Enabled = false;
            TxtTipo.Visible = true;
            TxtTipo.Enabled = false;
        }
        // OCULTA LOS ELEMENTOS DEL FORMULARIO
        private void OcultarFormulario()
        {            
            DgvConsumoIndividual.Visible = false;
            LblTotalM3Periodo.Visible = false;
            LblTotalgastado.Visible = false;
            LblLineaDivBottom.Visible = false;
            BtnNuevaBusqueda.Visible = false;
            LblNombreCliente.Visible = false;
            LblTipo.Visible = false;
            TxtNombreCliente.Visible = false;
            TxtTipo.Visible = false;
            TxtNombreCliente.Text = "";
            TxtTipo.Text = "";
            LblNota.Visible = false;
            TxtContrato.Text = "";
            LblTotPag.Visible = false;
            LblTotalCon.Visible = false;
            LblTotalCon.Text = "";
            LblTotPag.Text = "";
        }

        // AL CARGAR EL FORMULARIO, OCULTA LOS ELEMENTOS DEL FORMULARIO
        private void BusquedaIndividual_Load(object sender, EventArgs e)
        {
            OcultarFormulario();
        }

        // OCULTA LOS ELEMENTOS DEL FORMULARIO Y HABILITA OTROS PARA UNA NUEVA BUSQUEDA
        private void BtnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            OcultarFormulario();
            TxtContrato.Enabled = true;
            DtpFechaFinal.Enabled = true;
            DtpFechaInicial.Enabled = true;
            BtnBuscar.Enabled = true;
            DgvDatoCliente.Visible = false;
        }

        // BUSCA Y DESPLIEGA LOS RESULTADOS EN EL FORMULARIO
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtContrato.Text != "")
            {
                Pago pago = new Pago();
                bool validar = pago.VerificarCliente(TxtContrato.Text);
                if (validar == true)
                {
                    try
                    {
                        MostrarFormulario();
                        MostrarConsumoIndividual();
                        DgvDatoCliente.Visible = false;
                        TxtContrato.Enabled = false;
                        DtpFechaFinal.Enabled = false;
                        DtpFechaInicial.Enabled = false;
                        BtnBuscar.Enabled = false;
                        TotalConsumoMetro();
                        TotalConsumoFacturado();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("ERROR AL CARGAR LAS LECTURAS DE CONSUMOS\n\n" + ex);
                        OcultarFormulario();
                    }
                }
                else
                {
                    MessageBox.Show("No existe el contrato en la base de datos,\nintente nuevamente", "DATOS INCORRECTOS", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                    TxtContrato.Text = "";
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN CONTRATO VALIDO", "DATOS INCORRECTOS", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
            }
        }

        // PARA POBLAR EL DATAGRIDVIEW MOSTRANDO LOS MESES ADEUDADOS SEGUN EL CLIENTE
        public void MostrarConsumoIndividual()
        {
            Consumo listacons = new Consumo();
            Cliente clientedatos = new Cliente();
            string fechainicial = DateTime.Parse(DtpFechaInicial.Text).ToString("yyyy-MM-dd");
            string fechafinal = DateTime.Parse(DtpFechaFinal.Text).ToString("yyyy-MM-dd");
            DgvConsumoIndividual.DataSource = listacons.ReporteConsumoIndividual(fechainicial, fechafinal, TxtContrato.Text);
            DgvDatoCliente.DataSource = clientedatos.DatoCliente(TxtContrato.Text);
            TxtNombreCliente.Text = DgvDatoCliente.CurrentRow.Cells[0].Value.ToString();
            TxtTipo.Text = DgvDatoCliente.CurrentRow.Cells[1].Value.ToString();
        }

        // MOSTRAR EL TOTAL DEL CONSUMO
        public void TotalConsumoMetro()
        {
            int tconsumo = 0;
            for (int i = 0; i < DgvConsumoIndividual.Rows.Count; ++i)
            {
                tconsumo += Convert.ToInt32(DgvConsumoIndividual.Rows[i].Cells[1].Value);
            }
            LblTotalCon.Text = tconsumo.ToString() +"m3";
        }

        // MOSTRAR EL TOTAL FACTURADO
        public void TotalConsumoFacturado()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in DgvConsumoIndividual.Rows)
            {
                if (fila.Cells[2] != null && fila.Cells[2].Value != null && fila.Cells[2].Value != System.DBNull.Value)
                    total += Convert.ToDecimal(fila.Cells[2].Value);
            }
            LblTotPag.Text = "$ " + total.ToString();
        }

        // CIERRA EL FORMULARIO
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
