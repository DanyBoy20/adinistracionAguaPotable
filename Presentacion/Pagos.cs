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
    public partial class Pagos : Form
    {
        private string identificador = null;
        public Pagos()
        {
            InitializeComponent();
        }        

        // CERRAR EL FORMULARIO DE PAGOS
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BOTON CON MENSAJE DE AYUDA/INFORMACION DEL FORMULARIO
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario se utiliza para registro de pagos", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // BUSCA EL CLIENTE, SI EXISTE LO MUESTRO, SI NO MENSAJE DE ERROR
        private void BtnBuscaContrato_Click(object sender, EventArgs e)
        {
            if (TxtContrato.Text != "")
            {                
                Pago pago = new Pago();
                bool validar = pago.VerificarCliente(TxtContrato.Text);
                if (validar == true)
                {
                    try
                    {
                        // Consumo listacons = new Consumo();
                        MostrarCampos();
                        ListarMesesConsumosCliente();
                    }
                    catch
                    {
                        MessageBox.Show("EL CONTRATO NO TIENE ADEUDOS");
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

        // EFECTUAR EL PAGO Y LA INSERCION DEL MISMO Y ACTUALIZAR LA TABLA CONSUMOS A "PAGADO"
        private void BtnMesPagar_Click(object sender, EventArgs e)
        {
            try
            {
                PagarConsumo();
                MessageBox.Show("PAGO REALIZADO", "ACTUALIZACION EXITOSA", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                ListarMesesConsumosCliente();
                //this.Close();
            }
            catch
            {
                MessageBox.Show("NO SE PUDO GUARDAR LOS DATOS", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                this.Close();
            }        
        }

        // ACTUALIZA EL MONTO DEL PAGO SEGUN EL MES ELEGIDO
        private void CmbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TotalPagoIdConsumo();
        }

        // CANCELA EL PAGO Y CIERRA LA VENTANA
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // CORREGIR LA BUSQUEDA
        private void BtnCorregir_Click(object sender, EventArgs e)
        {
            OcultarFormulario();
        }

        // PARA CONSEGUIR EL VALOR A PAGAR
        public void TotalPagoIdConsumo()
        {
            Consumo muestratotal = new Consumo();
            CmbTotales.DataSource = muestratotal.TotalBusca(CmbMes.SelectedValue.ToString(), TxtContrato.Text);
            CmbTotales.DisplayMember = "totales";
            CmbTotales.ValueMember = "totales";
        }

        // PARA POBLAR EL DATAGRIDVIEW MOSTRANDO LOS MESES ADEUDADOS SEGUN EL CLIENTE
        public void ListarMesesConsumosCliente()
        {
            Consumo listacons = new Consumo();
            CmbMes.DataSource = listacons.ListaMesesConsumo(TxtContrato.Text);
            CmbMes.DisplayMember = "FECHA";
            CmbMes.ValueMember = "idconsumo";
            CmbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            DgvMes.DataSource = listacons.ListaMesesConsumo(TxtContrato.Text);
            TxtNombreCliente.Text = DgvMes.CurrentRow.Cells[4].Value.ToString();
            TxtTipo.Text = DgvMes.CurrentRow.Cells[5].Value.ToString();
            identificador = DgvMes.CurrentRow.Cells[0].Value.ToString();
            DgvMes.Columns[0].Visible = false;
            DgvMes.Columns[4].Visible = false;
            DgvMes.Columns[5].Visible = false;
        }

        // ACTUALIZAR CONSUMOS AL HABER PAGADO
        public void PagarConsumo()
        {
            Consumo actualiza = new Consumo();
            Pago npago = new Pago();
            string estadoconsumo = "pagado";
            string cveconsu = CmbMes.SelectedValue.ToString();
            string totalcns = CmbTotales.SelectedValue.ToString();
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");            
            actualiza.ActualizarConsumo(estadoconsumo, totalcns, cveconsu);
            npago.InsertarPago(cveconsu, fecha);
        }

        // MOSTRAR CAMPOS SI ENCUENTRA EL CLIENTE
        public void MostrarCampos()
        {
            LblTotales.Visible = true;
            CmbTotales.Visible = true;
            LblMesPago.Visible = true;
            CmbMes.Visible = true;
            BtnMesPagar.Visible = true;
            BtnCancelar.Visible = true;
            DgvMes.Visible = true;
            TxtContrato.Enabled = false;
            BtnBuscaContrato.Enabled = false;
            BtnCorregir.Visible = true;
            LblNombre.Visible = true;
            LblTipo.Visible = true;
            TxtNombreCliente.Visible = true;
            TxtNombreCliente.Enabled = false;
            TxtTipo.Visible = true;
            TxtTipo.Enabled = false;
            DgvMes.Enabled = false;
            LblDesgloce.Visible = true;
            LblLinea2.Visible = true;
        }

        // RESTABLECE Y OCULTA EL FORMULARIO PARA UNA NUEVA CONSULTA
        public void OcultarFormulario()
        {
            LblTotales.Visible = false;
            LblLinea2.Visible = false;
            LblDesgloce.Visible = false;
            BtnCancelar.Visible = false;
            BtnCorregir.Visible = false;
            BtnMesPagar.Visible = false;
            CmbTotales.Visible = false;
            DgvMes.Visible = false;
            DgvMes.Enabled = false;
            LblMesPago.Visible = false;
            LblTipo.Visible = false;
            LblNombre.Visible = false;
            CmbMes.Visible = false;
            TxtTipo.Visible = false;
            TxtNombreCliente.Visible = false;
            TxtContrato.Text = "";
            TxtContrato.Enabled = true;
            BtnBuscaContrato.Enabled = true;
            CmbTotales.DataSource = null;
        }
    }
}
