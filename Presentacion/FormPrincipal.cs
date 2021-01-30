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

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        //METODO PARA ABRIR FORMULARIOS DENTRO DE UN PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            // instanciamos
            Form formulario;
            formulario = PnlFormularios.Controls.OfType<MiForm>().FirstOrDefault(); // buscamos el formulario en la coleccion
            // si el formulario/instancia no existe (es diferente de null)
            if(formulario == null)
            {
                formulario = new MiForm(); // creamos el objeto (la instancia la hicimos en la linea 30)
                // cambiamos sus propiedades: toplevel (poner al frente), estilo de borde y su ajuste (dock)
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                // añadimos el formulario al panel principal
                PnlFormularios.Controls.Add(formulario); 
                PnlFormularios.Tag = formulario; // establecemos el objeto que tendra control
                formulario.Show(); // mostramos el formulario
                formulario.BringToFront(); // lo posicionamos al frente
                formulario.FormClosed += new FormClosedEventHandler(CerrarFormulario); // sobrecarga del metodo cerrar del formulario
            }
            // si el formulario/instancia existe, solo lo traemos al frente
            else
            {
                formulario.BringToFront();
            }
        }

        #region CARACTERISTICAS Y/O PROPIEDADES / METODOS DEL FORMULARIO PRINCIPAL (arrastrar ventana, cambio tamaño posicion, interaccion de botones, etc)
        // METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION 
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //DIBUJAR RECTANGULO PARA REDIMENSIONAR VENTANA PRINCIPAL / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.PnlContenedor.Region = region;
            this.Invalidate();
        }
        //COLOR Y GRIP DE RECTANGULO INFERIOR (el que redimenciona la ventana principal)
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(222, 242, 249));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        // BOTON CERRAR ( sale de la aplicacion )
        private void BtnCerrar_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
                Application.Exit();
        }

        // PARA CAPTURA DE TAMAÑO Y POSICION DE LA VENTANA PARA USAR EN BOTON MAXIMIZAR/    RESTAURAR
        int lx, ly; // ubicacion ventana x y ( ubicacion x x = lx , ubicacion y = ly)
        int sw, sh; // tamaño ventana: tamaño - size = s, ancho - width = w , alto - height = h (sw = size width, sh = size height)

        // BOTON PARA RESTAURAR LA VENTANA
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        // BOTON MAXIMIZAR VENTANA
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        // ARRASTRAR VENTANA DESDE LA BARRA DE TITULO (la barra es un control "Panel"
        private void PnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // MINIMIZAR VENTANA
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // BOTON PARA ABRIR EL FORMULARIO CLIENTES
        private void BtnregistroClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Clientes>();
            BtnregistroClientes.BackColor = Color.FromArgb(0, 118, 190);
        }

        // BOTON PARA ABRIR EL FORMULARIO PRECIOS
        private void BtnRegistroPrecios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Precios>();
            BtnRegistroPrecios.BackColor = Color.FromArgb(0, 118, 190);
        }

        // BOTON PARA ABRIR EL CONSUMOS
        private void BtnRegistroConsumos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Consumos>();
            BtnRegistroConsumos.BackColor = Color.FromArgb(0, 118, 190);
        }

        // BOTON PARA ABRIR EL FORMULARIO PAGOS
        private void BtnRegistroPagos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Pagos>();
            BtnRegistroPagos.BackColor = Color.FromArgb(0, 118, 190);
        }

        // BOTON PARA ABRIR EL FORMULARIO DE REPORTES "CONSUMOS INDIVIDUALES"
        private void BtnConsumosIndividuales_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BusquedaIndividual>();
            BtnConsumosIndividuales.BackColor = Color.FromArgb(0, 118, 190);
        }

        // BOTON PARA ABRIR EL FORMULARIO DE REPORTES "CONSUMOS TOTALES"
        private void BtnConsumosTotales_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BusquedaTotal>();
            BtnConsumosTotales.BackColor = Color.FromArgb(0, 118, 190);
        }

        // ARRASTRAR FORMULARIO
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea cerrar la sesión?", "Confirmar", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation)== DialogResult.Yes)
            this.Close();
        }

        // BOTON PARA ABRIR EL FORMULARIO USUARIOS
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Usuarios>();
            BtnUsuarios.BackColor = Color.FromArgb(0, 118, 190);
        }


        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        // BOTON PARA CERRAR LOS FORMULARIOS Y CAMBIAR SU ESTADO A TRAVES DE COLORES (si se cierra, el boton vuelve a su color original)
        private void CerrarFormulario(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Clientes"] == null)
                BtnregistroClientes.BackColor = Color.FromArgb(1,88,141);
            if (Application.OpenForms["Precios"] == null)
                BtnRegistroPrecios.BackColor = Color.FromArgb(1, 88, 141);
            if (Application.OpenForms["Consumos"] == null)
                BtnRegistroConsumos.BackColor = Color.FromArgb(1, 88, 141);
            if (Application.OpenForms["Pagos"] == null)
                BtnRegistroPagos.BackColor = Color.FromArgb(1, 88, 141);
            if (Application.OpenForms["BusquedaIndividual"] == null)
                BtnConsumosIndividuales.BackColor = Color.FromArgb(1, 88, 141);
            if (Application.OpenForms["BusquedaTotal"] == null)
                BtnConsumosTotales.BackColor = Color.FromArgb(1, 88, 141);
            if (Application.OpenForms["Usuarios"] == null)
                BtnUsuarios.BackColor = Color.FromArgb(1, 88, 141);

        }        
    }
}
