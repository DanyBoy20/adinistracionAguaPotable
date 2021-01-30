namespace Presentacion
{
    partial class BusquedaIndividual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaIndividual));
            this.PnlBusquedaInd = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.LblConsultaInd = new System.Windows.Forms.Label();
            this.LblReporteConIndividual = new System.Windows.Forms.Label();
            this.LblLineaDivisor = new System.Windows.Forms.Label();
            this.LblMesInicial = new System.Windows.Forms.Label();
            this.LblContrato = new System.Windows.Forms.Label();
            this.LblMesFinal = new System.Windows.Forms.Label();
            this.TxtContrato = new System.Windows.Forms.TextBox();
            this.DtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvConsumoIndividual = new System.Windows.Forms.DataGridView();
            this.LblTotalM3Periodo = new System.Windows.Forms.Label();
            this.LblTotalgastado = new System.Windows.Forms.Label();
            this.BtnNuevaBusqueda = new System.Windows.Forms.Button();
            this.LblLineaDivBottom = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.LblNota = new System.Windows.Forms.Label();
            this.DgvDatoCliente = new System.Windows.Forms.DataGridView();
            this.LblTotalCon = new System.Windows.Forms.Label();
            this.LblTotPag = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.PnlBusquedaInd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsumoIndividual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBusquedaInd
            // 
            this.PnlBusquedaInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.PnlBusquedaInd.Controls.Add(this.BtnHelp);
            this.PnlBusquedaInd.Controls.Add(this.BtnCerrar);
            this.PnlBusquedaInd.Controls.Add(this.LblConsultaInd);
            this.PnlBusquedaInd.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBusquedaInd.Location = new System.Drawing.Point(0, 0);
            this.PnlBusquedaInd.Name = "PnlBusquedaInd";
            this.PnlBusquedaInd.Size = new System.Drawing.Size(800, 30);
            this.PnlBusquedaInd.TabIndex = 0;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHelp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnHelp.ErrorImage")));
            this.BtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("BtnHelp.Image")));
            this.BtnHelp.Location = new System.Drawing.Point(745, 4);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(20, 20);
            this.BtnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHelp.TabIndex = 2;
            this.BtnHelp.TabStop = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(774, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblConsultaInd
            // 
            this.LblConsultaInd.AutoSize = true;
            this.LblConsultaInd.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsultaInd.ForeColor = System.Drawing.Color.White;
            this.LblConsultaInd.Location = new System.Drawing.Point(5, 4);
            this.LblConsultaInd.Name = "LblConsultaInd";
            this.LblConsultaInd.Size = new System.Drawing.Size(212, 22);
            this.LblConsultaInd.TabIndex = 0;
            this.LblConsultaInd.Text = "Consultas Individuales";
            // 
            // LblReporteConIndividual
            // 
            this.LblReporteConIndividual.AutoSize = true;
            this.LblReporteConIndividual.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReporteConIndividual.Location = new System.Drawing.Point(12, 38);
            this.LblReporteConIndividual.Name = "LblReporteConIndividual";
            this.LblReporteConIndividual.Size = new System.Drawing.Size(350, 24);
            this.LblReporteConIndividual.TabIndex = 5;
            this.LblReporteConIndividual.Text = "Busqueda de consumo individual";
            // 
            // LblLineaDivisor
            // 
            this.LblLineaDivisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLineaDivisor.Location = new System.Drawing.Point(12, 72);
            this.LblLineaDivisor.Name = "LblLineaDivisor";
            this.LblLineaDivisor.Size = new System.Drawing.Size(520, 2);
            this.LblLineaDivisor.TabIndex = 20;
            // 
            // LblMesInicial
            // 
            this.LblMesInicial.AutoSize = true;
            this.LblMesInicial.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesInicial.Location = new System.Drawing.Point(110, 113);
            this.LblMesInicial.Name = "LblMesInicial";
            this.LblMesInicial.Size = new System.Drawing.Size(56, 19);
            this.LblMesInicial.TabIndex = 22;
            this.LblMesInicial.Text = "Desde:";
            // 
            // LblContrato
            // 
            this.LblContrato.AutoSize = true;
            this.LblContrato.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrato.Location = new System.Drawing.Point(12, 85);
            this.LblContrato.Name = "LblContrato";
            this.LblContrato.Size = new System.Drawing.Size(154, 19);
            this.LblContrato.TabIndex = 21;
            this.LblContrato.Text = "Numero de contrato:";
            // 
            // LblMesFinal
            // 
            this.LblMesFinal.AutoSize = true;
            this.LblMesFinal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesFinal.Location = new System.Drawing.Point(293, 113);
            this.LblMesFinal.Name = "LblMesFinal";
            this.LblMesFinal.Size = new System.Drawing.Size(53, 19);
            this.LblMesFinal.TabIndex = 23;
            this.LblMesFinal.Text = "Hasta:";
            // 
            // TxtContrato
            // 
            this.TxtContrato.Location = new System.Drawing.Point(165, 85);
            this.TxtContrato.Name = "TxtContrato";
            this.TxtContrato.Size = new System.Drawing.Size(96, 20);
            this.TxtContrato.TabIndex = 24;
            // 
            // DtpFechaInicial
            // 
            this.DtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicial.Location = new System.Drawing.Point(165, 113);
            this.DtpFechaInicial.Name = "DtpFechaInicial";
            this.DtpFechaInicial.Size = new System.Drawing.Size(96, 20);
            this.DtpFechaInicial.TabIndex = 25;
            // 
            // DtpFechaFinal
            // 
            this.DtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinal.Location = new System.Drawing.Point(344, 113);
            this.DtpFechaFinal.Name = "DtpFechaFinal";
            this.DtpFechaFinal.Size = new System.Drawing.Size(96, 20);
            this.DtpFechaFinal.TabIndex = 26;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(470, 110);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(62, 23);
            this.BtnBuscar.TabIndex = 27;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 2);
            this.label1.TabIndex = 28;
            // 
            // DgvConsumoIndividual
            // 
            this.DgvConsumoIndividual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DgvConsumoIndividual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvConsumoIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsumoIndividual.Location = new System.Drawing.Point(43, 189);
            this.DgvConsumoIndividual.Name = "DgvConsumoIndividual";
            this.DgvConsumoIndividual.ReadOnly = true;
            this.DgvConsumoIndividual.Size = new System.Drawing.Size(489, 150);
            this.DgvConsumoIndividual.TabIndex = 29;
            this.DgvConsumoIndividual.Visible = false;
            // 
            // LblTotalM3Periodo
            // 
            this.LblTotalM3Periodo.AutoSize = true;
            this.LblTotalM3Periodo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalM3Periodo.Location = new System.Drawing.Point(237, 346);
            this.LblTotalM3Periodo.Name = "LblTotalM3Periodo";
            this.LblTotalM3Periodo.Size = new System.Drawing.Size(208, 19);
            this.LblTotalM3Periodo.TabIndex = 32;
            this.LblTotalM3Periodo.Text = "Total consumo en el periodo:";
            this.LblTotalM3Periodo.Visible = false;
            // 
            // LblTotalgastado
            // 
            this.LblTotalgastado.AutoSize = true;
            this.LblTotalgastado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalgastado.Location = new System.Drawing.Point(340, 373);
            this.LblTotalgastado.Name = "LblTotalgastado";
            this.LblTotalgastado.Size = new System.Drawing.Size(105, 19);
            this.LblTotalgastado.TabIndex = 33;
            this.LblTotalgastado.Text = "Total Pagado:";
            this.LblTotalgastado.Visible = false;
            // 
            // BtnNuevaBusqueda
            // 
            this.BtnNuevaBusqueda.Location = new System.Drawing.Point(425, 418);
            this.BtnNuevaBusqueda.Name = "BtnNuevaBusqueda";
            this.BtnNuevaBusqueda.Size = new System.Drawing.Size(107, 23);
            this.BtnNuevaBusqueda.TabIndex = 34;
            this.BtnNuevaBusqueda.Text = "Nueva busqueda";
            this.BtnNuevaBusqueda.UseVisualStyleBackColor = true;
            this.BtnNuevaBusqueda.Visible = false;
            this.BtnNuevaBusqueda.Click += new System.EventHandler(this.BtnNuevaBusqueda_Click);
            // 
            // LblLineaDivBottom
            // 
            this.LblLineaDivBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLineaDivBottom.Location = new System.Drawing.Point(12, 410);
            this.LblLineaDivBottom.Name = "LblLineaDivBottom";
            this.LblLineaDivBottom.Size = new System.Drawing.Size(520, 2);
            this.LblLineaDivBottom.TabIndex = 35;
            this.LblLineaDivBottom.Visible = false;
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Location = new System.Drawing.Point(134, 159);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(199, 20);
            this.TxtNombreCliente.TabIndex = 36;
            this.TxtNombreCliente.Visible = false;
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCliente.Location = new System.Drawing.Point(12, 158);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(119, 19);
            this.LblNombreCliente.TabIndex = 37;
            this.LblNombreCliente.Text = "Nombre cliente:";
            this.LblNombreCliente.Visible = false;
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.Location = new System.Drawing.Point(352, 158);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(40, 19);
            this.LblTipo.TabIndex = 38;
            this.LblTipo.Text = "Tipo:";
            this.LblTipo.Visible = false;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(394, 159);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(138, 20);
            this.TxtTipo.TabIndex = 39;
            this.TxtTipo.Visible = false;
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota.Location = new System.Drawing.Point(269, 389);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(175, 16);
            this.LblNota.TabIndex = 40;
            this.LblNota.Text = "(no incluye los meses sin pagar)";
            this.LblNota.Visible = false;
            // 
            // DgvDatoCliente
            // 
            this.DgvDatoCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DgvDatoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatoCliente.Location = new System.Drawing.Point(16, 110);
            this.DgvDatoCliente.Name = "DgvDatoCliente";
            this.DgvDatoCliente.Size = new System.Drawing.Size(14, 10);
            this.DgvDatoCliente.TabIndex = 41;
            this.DgvDatoCliente.Visible = false;
            // 
            // LblTotalCon
            // 
            this.LblTotalCon.AutoSize = true;
            this.LblTotalCon.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCon.Location = new System.Drawing.Point(444, 346);
            this.LblTotalCon.Name = "LblTotalCon";
            this.LblTotalCon.Size = new System.Drawing.Size(0, 19);
            this.LblTotalCon.TabIndex = 42;
            this.LblTotalCon.Visible = false;
            // 
            // LblTotPag
            // 
            this.LblTotPag.AutoSize = true;
            this.LblTotPag.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotPag.Location = new System.Drawing.Point(443, 375);
            this.LblTotPag.Name = "LblTotPag";
            this.LblTotPag.Size = new System.Drawing.Size(0, 19);
            this.LblTotPag.TabIndex = 43;
            this.LblTotPag.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(272, 418);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 23);
            this.BtnCancelar.TabIndex = 44;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BusquedaIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblTotPag);
            this.Controls.Add(this.LblTotalCon);
            this.Controls.Add(this.DgvDatoCliente);
            this.Controls.Add(this.LblTotalgastado);
            this.Controls.Add(this.LblNota);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblNombreCliente);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.LblLineaDivBottom);
            this.Controls.Add(this.BtnNuevaBusqueda);
            this.Controls.Add(this.LblTotalM3Periodo);
            this.Controls.Add(this.DgvConsumoIndividual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DtpFechaFinal);
            this.Controls.Add(this.DtpFechaInicial);
            this.Controls.Add(this.TxtContrato);
            this.Controls.Add(this.LblMesFinal);
            this.Controls.Add(this.LblMesInicial);
            this.Controls.Add(this.LblContrato);
            this.Controls.Add(this.LblLineaDivisor);
            this.Controls.Add(this.LblReporteConIndividual);
            this.Controls.Add(this.PnlBusquedaInd);
            this.Name = "BusquedaIndividual";
            this.Text = "BusquedaIndividual";
            this.Load += new System.EventHandler(this.BusquedaIndividual_Load);
            this.PnlBusquedaInd.ResumeLayout(false);
            this.PnlBusquedaInd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsumoIndividual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlBusquedaInd;
        private System.Windows.Forms.Label LblConsultaInd;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnHelp;
        private System.Windows.Forms.Label LblReporteConIndividual;
        private System.Windows.Forms.Label LblLineaDivisor;
        private System.Windows.Forms.Label LblMesInicial;
        private System.Windows.Forms.Label LblContrato;
        private System.Windows.Forms.Label LblMesFinal;
        private System.Windows.Forms.TextBox TxtContrato;
        private System.Windows.Forms.DateTimePicker DtpFechaInicial;
        private System.Windows.Forms.DateTimePicker DtpFechaFinal;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvConsumoIndividual;
        private System.Windows.Forms.Label LblTotalM3Periodo;
        private System.Windows.Forms.Label LblTotalgastado;
        private System.Windows.Forms.Button BtnNuevaBusqueda;
        private System.Windows.Forms.Label LblLineaDivBottom;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.DataGridView DgvDatoCliente;
        private System.Windows.Forms.Label LblTotalCon;
        private System.Windows.Forms.Label LblTotPag;
        private System.Windows.Forms.Button BtnCancelar;
    }
}