namespace Presentacion
{
    partial class Pagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.LblTituloPagos = new System.Windows.Forms.Label();
            this.LblNumeroContrato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblContrato = new System.Windows.Forms.Label();
            this.TxtContrato = new System.Windows.Forms.TextBox();
            this.BtnBuscaContrato = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvMes = new System.Windows.Forms.DataGridView();
            this.LblMesPago = new System.Windows.Forms.Label();
            this.CmbMes = new System.Windows.Forms.ComboBox();
            this.BtnMesPagar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.LblDesgloce = new System.Windows.Forms.Label();
            this.CmbTotales = new System.Windows.Forms.ComboBox();
            this.LblTotales = new System.Windows.Forms.Label();
            this.LblLinea2 = new System.Windows.Forms.Label();
            this.BtnCorregir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.LblTituloPagos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHelp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnHelp.ErrorImage")));
            this.BtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("BtnHelp.Image")));
            this.BtnHelp.Location = new System.Drawing.Point(746, 5);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(20, 20);
            this.BtnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHelp.TabIndex = 6;
            this.BtnHelp.TabStop = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(775, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblTituloPagos
            // 
            this.LblTituloPagos.AutoSize = true;
            this.LblTituloPagos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPagos.ForeColor = System.Drawing.Color.White;
            this.LblTituloPagos.Location = new System.Drawing.Point(5, 4);
            this.LblTituloPagos.Name = "LblTituloPagos";
            this.LblTituloPagos.Size = new System.Drawing.Size(175, 22);
            this.LblTituloPagos.TabIndex = 0;
            this.LblTituloPagos.Text = "Registro de pagos";
            // 
            // LblNumeroContrato
            // 
            this.LblNumeroContrato.AutoSize = true;
            this.LblNumeroContrato.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroContrato.Location = new System.Drawing.Point(12, 39);
            this.LblNumeroContrato.Name = "LblNumeroContrato";
            this.LblNumeroContrato.Size = new System.Drawing.Size(181, 24);
            this.LblNumeroContrato.TabIndex = 4;
            this.LblNumeroContrato.Text = "Pagar consumos";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 2);
            this.label1.TabIndex = 11;
            // 
            // LblContrato
            // 
            this.LblContrato.AutoSize = true;
            this.LblContrato.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrato.Location = new System.Drawing.Point(38, 83);
            this.LblContrato.Name = "LblContrato";
            this.LblContrato.Size = new System.Drawing.Size(75, 19);
            this.LblContrato.TabIndex = 12;
            this.LblContrato.Text = "Contrato:";
            // 
            // TxtContrato
            // 
            this.TxtContrato.Location = new System.Drawing.Point(119, 83);
            this.TxtContrato.Name = "TxtContrato";
            this.TxtContrato.Size = new System.Drawing.Size(123, 20);
            this.TxtContrato.TabIndex = 13;
            // 
            // BtnBuscaContrato
            // 
            this.BtnBuscaContrato.Location = new System.Drawing.Point(248, 81);
            this.BtnBuscaContrato.Name = "BtnBuscaContrato";
            this.BtnBuscaContrato.Size = new System.Drawing.Size(92, 23);
            this.BtnBuscaContrato.TabIndex = 14;
            this.BtnBuscaContrato.Text = "Buscar";
            this.BtnBuscaContrato.UseVisualStyleBackColor = true;
            this.BtnBuscaContrato.Click += new System.EventHandler(this.BtnBuscaContrato_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 2);
            this.label2.TabIndex = 15;
            // 
            // DgvMes
            // 
            this.DgvMes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DgvMes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMes.Location = new System.Drawing.Point(16, 291);
            this.DgvMes.Name = "DgvMes";
            this.DgvMes.Size = new System.Drawing.Size(551, 150);
            this.DgvMes.TabIndex = 16;
            this.DgvMes.Visible = false;
            // 
            // LblMesPago
            // 
            this.LblMesPago.AutoSize = true;
            this.LblMesPago.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesPago.Location = new System.Drawing.Point(12, 188);
            this.LblMesPago.Name = "LblMesPago";
            this.LblMesPago.Size = new System.Drawing.Size(101, 19);
            this.LblMesPago.TabIndex = 17;
            this.LblMesPago.Text = "Mes a pagar:";
            this.LblMesPago.Visible = false;
            // 
            // CmbMes
            // 
            this.CmbMes.FormattingEnabled = true;
            this.CmbMes.Location = new System.Drawing.Point(119, 188);
            this.CmbMes.Name = "CmbMes";
            this.CmbMes.Size = new System.Drawing.Size(121, 21);
            this.CmbMes.TabIndex = 18;
            this.CmbMes.Visible = false;
            this.CmbMes.SelectionChangeCommitted += new System.EventHandler(this.CmbMes_SelectionChangeCommitted);
            // 
            // BtnMesPagar
            // 
            this.BtnMesPagar.Location = new System.Drawing.Point(249, 217);
            this.BtnMesPagar.Name = "BtnMesPagar";
            this.BtnMesPagar.Size = new System.Drawing.Size(91, 23);
            this.BtnMesPagar.TabIndex = 19;
            this.BtnMesPagar.Text = "Pagar";
            this.BtnMesPagar.UseVisualStyleBackColor = true;
            this.BtnMesPagar.Visible = false;
            this.BtnMesPagar.Click += new System.EventHandler(this.BtnMesPagar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(480, 218);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(82, 23);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(45, 127);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(68, 19);
            this.LblNombre.TabIndex = 21;
            this.LblNombre.Text = "Nombre:";
            this.LblNombre.Visible = false;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(73, 158);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(40, 19);
            this.LblTipo.TabIndex = 22;
            this.LblTipo.Text = "Tipo:";
            this.LblTipo.Visible = false;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Location = new System.Drawing.Point(119, 127);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(221, 20);
            this.TxtNombreCliente.TabIndex = 23;
            this.TxtNombreCliente.Visible = false;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(119, 158);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(121, 20);
            this.TxtTipo.TabIndex = 24;
            this.TxtTipo.Visible = false;
            // 
            // LblDesgloce
            // 
            this.LblDesgloce.AutoSize = true;
            this.LblDesgloce.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesgloce.Location = new System.Drawing.Point(12, 264);
            this.LblDesgloce.Name = "LblDesgloce";
            this.LblDesgloce.Size = new System.Drawing.Size(76, 19);
            this.LblDesgloce.TabIndex = 25;
            this.LblDesgloce.Text = "Desgloce:";
            this.LblDesgloce.Visible = false;
            // 
            // CmbTotales
            // 
            this.CmbTotales.Enabled = false;
            this.CmbTotales.FormattingEnabled = true;
            this.CmbTotales.Location = new System.Drawing.Point(119, 218);
            this.CmbTotales.Name = "CmbTotales";
            this.CmbTotales.Size = new System.Drawing.Size(121, 21);
            this.CmbTotales.TabIndex = 26;
            this.CmbTotales.Visible = false;
            // 
            // LblTotales
            // 
            this.LblTotales.AutoSize = true;
            this.LblTotales.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotales.Location = new System.Drawing.Point(7, 220);
            this.LblTotales.Name = "LblTotales";
            this.LblTotales.Size = new System.Drawing.Size(106, 19);
            this.LblTotales.TabIndex = 27;
            this.LblTotales.Text = "Total a pagar:";
            this.LblTotales.Visible = false;
            // 
            // LblLinea2
            // 
            this.LblLinea2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLinea2.Location = new System.Drawing.Point(12, 256);
            this.LblLinea2.Name = "LblLinea2";
            this.LblLinea2.Size = new System.Drawing.Size(550, 2);
            this.LblLinea2.TabIndex = 28;
            this.LblLinea2.Visible = false;
            // 
            // BtnCorregir
            // 
            this.BtnCorregir.Location = new System.Drawing.Point(365, 217);
            this.BtnCorregir.Name = "BtnCorregir";
            this.BtnCorregir.Size = new System.Drawing.Size(91, 23);
            this.BtnCorregir.TabIndex = 29;
            this.BtnCorregir.Text = "Corregir datos";
            this.BtnCorregir.UseVisualStyleBackColor = true;
            this.BtnCorregir.Visible = false;
            this.BtnCorregir.Click += new System.EventHandler(this.BtnCorregir_Click);
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCorregir);
            this.Controls.Add(this.LblLinea2);
            this.Controls.Add(this.LblTotales);
            this.Controls.Add(this.CmbTotales);
            this.Controls.Add(this.LblDesgloce);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnMesPagar);
            this.Controls.Add(this.CmbMes);
            this.Controls.Add(this.LblMesPago);
            this.Controls.Add(this.DgvMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscaContrato);
            this.Controls.Add(this.TxtContrato);
            this.Controls.Add(this.LblContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblNumeroContrato);
            this.Controls.Add(this.panel1);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTituloPagos;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnHelp;
        private System.Windows.Forms.Label LblNumeroContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblContrato;
        private System.Windows.Forms.TextBox TxtContrato;
        private System.Windows.Forms.Button BtnBuscaContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvMes;
        private System.Windows.Forms.Label LblMesPago;
        private System.Windows.Forms.ComboBox CmbMes;
        private System.Windows.Forms.Button BtnMesPagar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label LblDesgloce;
        private System.Windows.Forms.ComboBox CmbTotales;
        private System.Windows.Forms.Label LblTotales;
        private System.Windows.Forms.Label LblLinea2;
        private System.Windows.Forms.Button BtnCorregir;
    }
}