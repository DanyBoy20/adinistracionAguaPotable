namespace Presentacion
{
    partial class Consumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consumos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.LblConsumos = new System.Windows.Forms.Label();
            this.LblConsumo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblContrato = new System.Windows.Forms.Label();
            this.LblMesLectura = new System.Windows.Forms.Label();
            this.LblLectConsumo = new System.Windows.Forms.Label();
            this.TxtContrato = new System.Windows.Forms.TextBox();
            this.DtpFechaLectura = new System.Windows.Forms.DateTimePicker();
            this.TxtConsumo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.LblConsumos);
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
            this.BtnHelp.Location = new System.Drawing.Point(743, 5);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(20, 20);
            this.BtnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHelp.TabIndex = 5;
            this.BtnHelp.TabStop = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(774, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblConsumos
            // 
            this.LblConsumos.AutoSize = true;
            this.LblConsumos.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsumos.ForeColor = System.Drawing.Color.White;
            this.LblConsumos.Location = new System.Drawing.Point(6, 4);
            this.LblConsumos.Name = "LblConsumos";
            this.LblConsumos.Size = new System.Drawing.Size(211, 22);
            this.LblConsumos.TabIndex = 0;
            this.LblConsumos.Text = "Registro de Consumos";
            // 
            // LblConsumo
            // 
            this.LblConsumo.AutoSize = true;
            this.LblConsumo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConsumo.Location = new System.Drawing.Point(12, 42);
            this.LblConsumo.Name = "LblConsumo";
            this.LblConsumo.Size = new System.Drawing.Size(413, 24);
            this.LblConsumo.TabIndex = 4;
            this.LblConsumo.Text = "Ingrese la lectura de consumo del mes";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 2);
            this.label2.TabIndex = 12;
            // 
            // LblContrato
            // 
            this.LblContrato.AutoSize = true;
            this.LblContrato.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrato.Location = new System.Drawing.Point(23, 96);
            this.LblContrato.Name = "LblContrato";
            this.LblContrato.Size = new System.Drawing.Size(154, 19);
            this.LblContrato.TabIndex = 13;
            this.LblContrato.Text = "Numero de contrato:";
            // 
            // LblMesLectura
            // 
            this.LblMesLectura.AutoSize = true;
            this.LblMesLectura.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesLectura.Location = new System.Drawing.Point(44, 126);
            this.LblMesLectura.Name = "LblMesLectura";
            this.LblMesLectura.Size = new System.Drawing.Size(133, 19);
            this.LblMesLectura.TabIndex = 14;
            this.LblMesLectura.Text = "Fecha de lectura:";
            // 
            // LblLectConsumo
            // 
            this.LblLectConsumo.AutoSize = true;
            this.LblLectConsumo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLectConsumo.Location = new System.Drawing.Point(99, 156);
            this.LblLectConsumo.Name = "LblLectConsumo";
            this.LblLectConsumo.Size = new System.Drawing.Size(78, 19);
            this.LblLectConsumo.TabIndex = 15;
            this.LblLectConsumo.Text = "Consumo:";
            // 
            // TxtContrato
            // 
            this.TxtContrato.Location = new System.Drawing.Point(183, 96);
            this.TxtContrato.Name = "TxtContrato";
            this.TxtContrato.Size = new System.Drawing.Size(96, 20);
            this.TxtContrato.TabIndex = 16;
            // 
            // DtpFechaLectura
            // 
            this.DtpFechaLectura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaLectura.Location = new System.Drawing.Point(183, 126);
            this.DtpFechaLectura.Name = "DtpFechaLectura";
            this.DtpFechaLectura.Size = new System.Drawing.Size(96, 20);
            this.DtpFechaLectura.TabIndex = 17;
            // 
            // TxtConsumo
            // 
            this.TxtConsumo.Location = new System.Drawing.Point(183, 156);
            this.TxtConsumo.Name = "TxtConsumo";
            this.TxtConsumo.Size = new System.Drawing.Size(96, 20);
            this.TxtConsumo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 2);
            this.label1.TabIndex = 19;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(341, 96);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 20;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(341, 152);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 21;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Consumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtConsumo);
            this.Controls.Add(this.DtpFechaLectura);
            this.Controls.Add(this.TxtContrato);
            this.Controls.Add(this.LblLectConsumo);
            this.Controls.Add(this.LblMesLectura);
            this.Controls.Add(this.LblContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblConsumo);
            this.Controls.Add(this.panel1);
            this.Name = "Consumos";
            this.Text = "Consumos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblConsumos;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnHelp;
        private System.Windows.Forms.Label LblConsumo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblContrato;
        private System.Windows.Forms.Label LblMesLectura;
        private System.Windows.Forms.Label LblLectConsumo;
        private System.Windows.Forms.TextBox TxtContrato;
        private System.Windows.Forms.DateTimePicker DtpFechaLectura;
        private System.Windows.Forms.TextBox TxtConsumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}