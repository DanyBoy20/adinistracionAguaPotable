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
    public partial class Consumos : Form
    {
        public Consumos()
        {
            InitializeComponent();
        }

        // CIERRA EL FORMULARIO
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MUESTRA UN MENSAJE INDICANDO LO QUE SE HACE EN EL FORMULARIO
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este formulario se utiliza para registro de consumos", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // GUARDA LOS CONSUMOS A LA BASE DE DATOS
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtContrato.Text != "")
            {
                if (TxtConsumo.Text != "")
                {
                    Consumo lectura = new Consumo();
                    bool validar = lectura.VerificarCliente(TxtContrato.Text);
                    if (validar == true)
                    {
                        try
                        {﻿
                            string fecha = DateTime.Parse(DtpFechaLectura.Text).ToString("yyyy-MM-dd");
                            string estado = "pendiente"; 
                            lectura.RegistrarConsumo(TxtContrato.Text, fecha, TxtConsumo.Text, estado);
                            MessageBox.Show("CONSUMO REGISTRADO CORRECTAMENTE", "DATOS GUARDADOS", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                            TxtContrato.Text = "";
                            TxtConsumo.Text = "";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("OCURRIO EL SIGUIENTE ERROR:\n\n" + ex + "\n\n NO SE GUARDARAN LOS DATOS");
                            TxtContrato.Text = "";
                            TxtConsumo.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existe el contrato en la base de datos,\nintente nuevamente", "DATOS INCORRECTOS", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                        TxtContrato.Text = "";
                        TxtConsumo.Text = "";
                    }
                }
                else
                    MessageBox.Show("DEBE REGISTRAR UNA LECTURA DE CONSUMO", "DATOS INCORRECTOS", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
            }
            else
            { 
                MessageBox.Show("DEBE INGRESAR UN CONTRATO VALIDO", "DATOS INCORRECTOS", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
            }
        }

        // CIERRA EL FORMULARIO
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
