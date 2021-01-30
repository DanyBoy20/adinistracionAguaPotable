namespace Presentacion
{
    partial class BusquedaTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaTotal));
            this.PnlTituloBsT = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblLineaDivBottom = new System.Windows.Forms.Label();
            this.BtnNuevaBusqueda = new System.Windows.Forms.Button();
            this.LblTotalgastado = new System.Windows.Forms.Label();
            this.LblResutadoM3 = new System.Windows.Forms.Label();
            this.DgvConsumoTipoC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.LblMesFinal = new System.Windows.Forms.Label();
            this.LblMesInicial = new System.Windows.Forms.Label();
            this.LblTipoCliente = new System.Windows.Forms.Label();
            this.LblReporteConTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.LblMuestraM3 = new System.Windows.Forms.Label();
            this.LblMuestraTotGasta = new System.Windows.Forms.Label();
            this.LblNota = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.PnlTituloBsT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsumoTipoC)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTituloBsT
            // 
            this.PnlTituloBsT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.PnlTituloBsT.Controls.Add(this.BtnHelp);
            this.PnlTituloBsT.Controls.Add(this.BtnCerrar);
            this.PnlTituloBsT.Controls.Add(this.LblTitulo);
            this.PnlTituloBsT.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTituloBsT.Location = new System.Drawing.Point(0, 0);
            this.PnlTituloBsT.Name = "PnlTituloBsT";
            this.PnlTituloBsT.Size = new System.Drawing.Size(800, 30);
            this.PnlTituloBsT.TabIndex = 0;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHelp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnHelp.ErrorImage")));
            this.BtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("BtnHelp.Image")));
            this.BtnHelp.Location = new System.Drawing.Point(743, 5);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(20, 20);
            this.BtnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHelp.TabIndex = 3;
            this.BtnHelp.TabStop = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(774, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(7, 4);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(165, 22);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Consultas Totales";
            // 
            // LblLineaDivBottom
            // 
            this.LblLineaDivBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLineaDivBottom.Location = new System.Drawing.Point(12, 383);
            this.LblLineaDivBottom.Name = "LblLineaDivBottom";
            this.LblLineaDivBottom.Size = new System.Drawing.Size(520, 2);
            this.LblLineaDivBottom.TabIndex = 50;
            this.LblLineaDivBottom.Visible = false;
            // 
            // BtnNuevaBusqueda
            // 
            this.BtnNuevaBusqueda.Location = new System.Drawing.Point(425, 395);
            this.BtnNuevaBusqueda.Name = "BtnNuevaBusqueda";
            this.BtnNuevaBusqueda.Size = new System.Drawing.Size(107, 23);
            this.BtnNuevaBusqueda.TabIndex = 49;
            this.BtnNuevaBusqueda.Text = "Nueva busqueda";
            this.BtnNuevaBusqueda.UseVisualStyleBackColor = true;
            this.BtnNuevaBusqueda.Visible = false;
            this.BtnNuevaBusqueda.Click += new System.EventHandler(this.BtnNuevaBusqueda_Click);
            // 
            // LblTotalgastado
            // 
            this.LblTotalgastado.AutoSize = true;
            this.LblTotalgastado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalgastado.Location = new System.Drawing.Point(314, 351);
            this.LblTotalgastado.Name = "LblTotalgastado";
            this.LblTotalgastado.Size = new System.Drawing.Size(107, 19);
            this.LblTotalgastado.TabIndex = 48;
            this.LblTotalgastado.Text = "Total gastado:";
            this.LblTotalgastado.Visible = false;
            // 
            // LblResutadoM3
            // 
            this.LblResutadoM3.AutoSize = true;
            this.LblResutadoM3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResutadoM3.Location = new System.Drawing.Point(170, 325);
            this.LblResutadoM3.Name = "LblResutadoM3";
            this.LblResutadoM3.Size = new System.Drawing.Size(251, 19);
            this.LblResutadoM3.TabIndex = 47;
            this.LblResutadoM3.Text = "Total m3 consumidos en el periodo:";
            this.LblResutadoM3.Visible = false;
            // 
            // DgvConsumoTipoC
            // 
            this.DgvConsumoTipoC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DgvConsumoTipoC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvConsumoTipoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsumoTipoC.Location = new System.Drawing.Point(12, 162);
            this.DgvConsumoTipoC.Name = "DgvConsumoTipoC";
            this.DgvConsumoTipoC.Size = new System.Drawing.Size(528, 150);
            this.DgvConsumoTipoC.TabIndex = 44;
            this.DgvConsumoTipoC.Visible = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 2);
            this.label1.TabIndex = 43;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(470, 108);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(62, 23);
            this.BtnBuscar.TabIndex = 42;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinal.Location = new System.Drawing.Point(344, 111);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(96, 20);
            this.DtpFechaFinal.TabIndex = 41;
            // 
            // DtpFechaInicial
            // 
            this.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicial.Location = new System.Drawing.Point(165, 111);
            this.DtpFechaInicial.Name = "DtpFechaInicial";
            this.DtpFechaInicial.Size = new System.Drawing.Size(96, 20);
            this.DtpFechaInicial.TabIndex = 40;
            // 
            // LblMesFinal
            // 
            this.LblMesFinal.AutoSize = true;
            this.LblMesFinal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesFinal.Location = new System.Drawing.Point(293, 111);
            this.LblMesFinal.Name = "LblMesFinal";
            this.LblMesFinal.Size = new System.Drawing.Size(53, 19);
            this.LblMesFinal.TabIndex = 39;
            this.LblMesFinal.Text = "Hasta:";
            // 
            // LblMesInicial
            // 
            this.LblMesInicial.AutoSize = true;
            this.LblMesInicial.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesInicial.Location = new System.Drawing.Point(110, 111);
            this.LblMesInicial.Name = "LblMesInicial";
            this.LblMesInicial.Size = new System.Drawing.Size(56, 19);
            this.LblMesInicial.TabIndex = 38;
            this.LblMesInicial.Text = "Desde:";
            // 
            // LblTipoCliente
            // 
            this.LblTipoCliente.AutoSize = true;
            this.LblTipoCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoCliente.Location = new System.Drawing.Point(52, 81);
            this.LblTipoCliente.Name = "LblTipoCliente";
            this.LblTipoCliente.Size = new System.Drawing.Size(114, 19);
            this.LblTipoCliente.TabIndex = 37;
            this.LblTipoCliente.Text = "Tipo de cliente:";
            // 
            // LblReporteConTotal
            // 
            this.LblReporteConTotal.AutoSize = true;
            this.LblReporteConTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReporteConTotal.Location = new System.Drawing.Point(12, 36);
            this.LblReporteConTotal.Name = "LblReporteConTotal";
            this.LblReporteConTotal.Size = new System.Drawing.Size(395, 24);
            this.LblReporteConTotal.TabIndex = 36;
            this.LblReporteConTotal.Text = "Consumos totales por tipo de clientes";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 2);
            this.label2.TabIndex = 51;
            // 
            // CmbTipoCliente
            // 
            this.CmbTipoCliente.FormattingEnabled = true;
            this.CmbTipoCliente.Location = new System.Drawing.Point(165, 82);
            this.CmbTipoCliente.Name = "CmbTipoCliente";
            this.CmbTipoCliente.Size = new System.Drawing.Size(121, 21);
            this.CmbTipoCliente.TabIndex = 52;
            // 
            // LblMuestraM3
            // 
            this.LblMuestraM3.AutoSize = true;
            this.LblMuestraM3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMuestraM3.Location = new System.Drawing.Point(425, 325);
            this.LblMuestraM3.Name = "LblMuestraM3";
            this.LblMuestraM3.Size = new System.Drawing.Size(0, 19);
            this.LblMuestraM3.TabIndex = 53;
            this.LblMuestraM3.Visible = false;
            // 
            // LblMuestraTotGasta
            // 
            this.LblMuestraTotGasta.AutoSize = true;
            this.LblMuestraTotGasta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMuestraTotGasta.Location = new System.Drawing.Point(425, 351);
            this.LblMuestraTotGasta.Name = "LblMuestraTotGasta";
            this.LblMuestraTotGasta.Size = new System.Drawing.Size(0, 19);
            this.LblMuestraTotGasta.TabIndex = 54;
            this.LblMuestraTotGasta.Visible = false;
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota.Location = new System.Drawing.Point(246, 366);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(175, 16);
            this.LblNota.TabIndex = 55;
            this.LblNota.Text = "(no incluye los meses sin pagar)";
            this.LblNota.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(249, 395);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(84, 23);
            this.BtnCancelar.TabIndex = 56;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BusquedaTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblMuestraTotGasta);
            this.Controls.Add(this.LblMuestraM3);
            this.Controls.Add(this.CmbTipoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblLineaDivBottom);
            this.Controls.Add(this.BtnNuevaBusqueda);
            this.Controls.Add(this.LblTotalgastado);
            this.Controls.Add(this.LblResutadoM3);
            this.Controls.Add(this.DgvConsumoTipoC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DtpFechaFinal);
            this.Controls.Add(this.DtpFechaInicial);
            this.Controls.Add(this.LblMesFinal);
            this.Controls.Add(this.LblMesInicial);
            this.Controls.Add(this.LblTipoCliente);
            this.Controls.Add(this.LblReporteConTotal);
            this.Controls.Add(this.PnlTituloBsT);
            this.Controls.Add(this.LblNota);
            this.Name = "BusquedaTotal";
            this.Text = "BusquedaTotal";
            this.Load += new System.EventHandler(this.BusquedaTotal_Load);
            this.PnlTituloBsT.ResumeLayout(false);
            this.PnlTituloBsT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsumoTipoC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTituloBsT;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnHelp;
        private System.Windows.Forms.Label LblLineaDivBottom;
        private System.Windows.Forms.Button BtnNuevaBusqueda;
        private System.Windows.Forms.Label LblTotalgastado;
        private System.Windows.Forms.Label LblResutadoM3;
        private System.Windows.Forms.DataGridView DgvConsumoTipoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker DtpFechaFinal;
        private System.Windows.Forms.DateTimePicker DtpFechaInicial;
        private System.Windows.Forms.Label LblMesFinal;
        private System.Windows.Forms.Label LblMesInicial;
        private System.Windows.Forms.Label LblTipoCliente;
        private System.Windows.Forms.Label LblReporteConTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbTipoCliente;
        private System.Windows.Forms.Label LblMuestraM3;
        private System.Windows.Forms.Label LblMuestraTotGasta;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.Button BtnCancelar;
    }
}