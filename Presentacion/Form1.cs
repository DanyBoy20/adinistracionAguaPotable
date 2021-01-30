using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // LIBRERIAS DLL IMPORTADAS PARA TENER CONTROL SOBRE LA VENTANA: CAPTURAR EL CLIC SOSTENIEO Y ARRASTRAR EL ELEMENTO - EN ESTE CASO LA VENTANA
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // SIMULAMOS UN "PLACEHOLDER" PARA EL CAMPO DE TEXTO USUARIO (CUANDO TIENE EL FOCO, AL ENTRAR)
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if(TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.White;
            }
        }

        // SIMULAMOS UN "PLACEHOLDER" PARA EL CAMPO DE TEXTO USUARIO(CUANDO PIERDE EL FOCO, AL SALIR DEL CUADRO DE TEXTO)
        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if(TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.LightGray;
            }
        }

        // SIMULAMOS UN "PLACEHOLDER" PARA EL CAMPO DE TEXTO CONTRASEÑA (CUANDO TIENE EL FOCO, AL ENTRAR)
        private void TxtContrasenia_Enter(object sender, EventArgs e)
        {
            if(TxtContrasenia.Text == "Contraseña")
            {
                TxtContrasenia.Text = "";
                TxtContrasenia.ForeColor = Color.White;
                TxtContrasenia.UseSystemPasswordChar = true;
            }
        }

        // SIMULAMOS UN "PLACEHOLDER" PARA EL CAMPO DE TEXTO CONTRASEÑA (CUANDO PIERDE EL FOCO, AL SALIR DEL CUADRO DE TEXTO)
        private void TxtContrasenia_Leave(object sender, EventArgs e)
        {
            if(TxtContrasenia.Text == "")
            {
                TxtContrasenia.Text = "Contraseña";
                TxtUsuario.ForeColor = Color.LightGray;
                TxtContrasenia.UseSystemPasswordChar = false;
            }
        }

        // BOTON CERRAR (ESQUINA SUPERIOR) CIERRA LA APLICACION - ANTES PREGUNTA SI SE DESEA SALIR
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
                Application.Exit();
        }

        // MINIMIZA LA VENTANA
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // CUANDO SE HACE UN CLIC SOSTENIDO EN EL FORM(PARA ARRASTRAR LA VENTANA)
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // CUANDO SE HACE UN CLIC SOSTENIDO EN EL PANEL (PARA ARRASTRAR LA VENTANA)
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // PARA VALIDAR AL USUARIO
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "Usuario")
            {
                if (TxtContrasenia.Text != "Contraseña")
                {
                    Usuario usuario = new Usuario();
                    bool iniciosesion = usuario.IniciarSesion(TxtUsuario.Text, TxtContrasenia.Text);
                    if(iniciosesion == true)
                    {
                        FormPrincipal sistema = new FormPrincipal();
                        sistema.Show();
                        sistema.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {                        
                        MessageBox.Show("El usuario y/o contraseña no existen,\nintente nuevamente", "DATOS INCORRECTOS", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                        LblErrorCredenciales.Visible = false;
                        TxtContrasenia.UseSystemPasswordChar = false;
                        TxtContrasenia.Text = "Contraseña";
                        TxtUsuario.Text = "Usuario";
                    }
                }
                else
                    MensajeError("Ingrese una contraseña");
            }
            else
                MensajeError("Ingrese un usuario");
        }

        // PARA LOS MENSAJES DE ERROR SI EL USUARIO NO ES VALIDO O FALTAN DATOS (SE DESPLIEGAN EN UNA ETIQUETA (Label)
        private void MensajeError(string mensaje)
        {
            LblErrorCredenciales.Text = "      " + mensaje;
            LblErrorCredenciales.Visible = true;
        }

        // CUANDO SE CIERRA SESION, SE UELVE A MOSTRAR EL FORMULARIO DE INGRESO
        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            TxtContrasenia.UseSystemPasswordChar = false;
            TxtContrasenia.Text = "Contraseña";
            TxtUsuario.Text = "Usuario";
            LblErrorCredenciales.Visible = false;
            this.Show();
        }
    }
}
