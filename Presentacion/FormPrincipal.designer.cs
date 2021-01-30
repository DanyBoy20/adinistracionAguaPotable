using System;

namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlFormularios = new System.Windows.Forms.Panel();
            this.PnlMenus = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnConsumosTotales = new System.Windows.Forms.Button();
            this.BtnConsumosIndividuales = new System.Windows.Forms.Button();
            this.BtnRegistroPagos = new System.Windows.Forms.Button();
            this.BtnRegistroConsumos = new System.Windows.Forms.Button();
            this.BtnRegistroPrecios = new System.Windows.Forms.Button();
            this.BtnregistroClientes = new System.Windows.Forms.Button();
            this.PnlBarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.PnlContenedor.SuspendLayout();
            this.PnlMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(180)))), ((int)(((byte)(215)))));
            this.PnlContenedor.Controls.Add(this.PnlFormularios);
            this.PnlContenedor.Controls.Add(this.PnlMenus);
            this.PnlContenedor.Controls.Add(this.PnlBarraTitulo);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1055, 650);
            this.PnlContenedor.TabIndex = 0;
            // 
            // PnlFormularios
            // 
            this.PnlFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.PnlFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormularios.Location = new System.Drawing.Point(203, 40);
            this.PnlFormularios.Name = "PnlFormularios";
            this.PnlFormularios.Size = new System.Drawing.Size(852, 610);
            this.PnlFormularios.TabIndex = 2;
            // 
            // PnlMenus
            // 
            this.PnlMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(88)))), ((int)(((byte)(141)))));
            this.PnlMenus.Controls.Add(this.label5);
            this.PnlMenus.Controls.Add(this.label4);
            this.PnlMenus.Controls.Add(this.label3);
            this.PnlMenus.Controls.Add(this.BtnUsuarios);
            this.PnlMenus.Controls.Add(this.BtnCerrarSesion);
            this.PnlMenus.Controls.Add(this.pictureBox1);
            this.PnlMenus.Controls.Add(this.BtnConsumosTotales);
            this.PnlMenus.Controls.Add(this.BtnConsumosIndividuales);
            this.PnlMenus.Controls.Add(this.BtnRegistroPagos);
            this.PnlMenus.Controls.Add(this.BtnRegistroConsumos);
            this.PnlMenus.Controls.Add(this.BtnRegistroPrecios);
            this.PnlMenus.Controls.Add(this.BtnregistroClientes);
            this.PnlMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenus.Location = new System.Drawing.Point(0, 40);
            this.PnlMenus.Name = "PnlMenus";
            this.PnlMenus.Size = new System.Drawing.Size(203, 610);
            this.PnlMenus.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(0, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 2);
            this.label5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(1, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 2);
            this.label4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(1, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 2);
            this.label3.TabIndex = 13;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsuarios.Image")));
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Location = new System.Drawing.Point(3, 427);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(200, 49);
            this.BtnUsuarios.TabIndex = 8;
            this.BtnUsuarios.Text = "Control de accesos";
            this.BtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarSesion.Image")));
            this.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(3, 558);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(197, 49);
            this.BtnCerrarSesion.TabIndex = 7;
            this.BtnCerrarSesion.Text = "Cerrar sesión";
            this.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BtnConsumosTotales
            // 
            this.BtnConsumosTotales.FlatAppearance.BorderSize = 0;
            this.BtnConsumosTotales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.BtnConsumosTotales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BtnConsumosTotales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsumosTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsumosTotales.ForeColor = System.Drawing.Color.White;
            this.BtnConsumosTotales.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsumosTotales.Image")));
            this.BtnConsumosTotales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsumosTotales.Location = new System.Drawing.Point(3, 367);
            this.BtnConsumosTotales.Name = "BtnConsumosTotales";
            this.BtnConsumosTotales.Size = new System.Drawing.Size(200, 49);
            this.BtnConsumosTotales.TabIndex = 5;
            this.BtnConsumosTotales.Text = "Reporte general";
            this.BtnConsumosTotales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsumosTotales.UseVisualStyleBackColor = true;
            this.BtnConsumosTotales.Click += new System.EventHandler(this.BtnConsumosTotales_Click);
            // 
            // BtnConsumosIndividuales
            // 
            this.BtnConsumosIndividuales.FlatAppearance.BorderSize = 0;
            this.BtnConsumosIndividuales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.BtnConsumosIndividuales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BtnConsumosIndividuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsumosIndividuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsumosIndividuales.ForeColor = System.Drawing.Color.White;
            this.BtnConsumosIndividuales.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsumosIndividuales.Image")));
            this.BtnConsumosIndividuales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsumosIndividuales.Location = new System.Drawing.Point(3, 314);
            this.BtnConsumosIndividuales.Name = "BtnConsumosIndividuales";
            this.BtnConsumosIndividuales.Size = new System.Drawing.Size(200, 49);
            this.BtnConsumosIndividuales.TabIndex = 4;
            this.BtnConsumosIndividuales.Text = "Reporte individual";
            this.BtnConsumosIndividuales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConsumosIndividuales.UseVisualStyleBackColor = true;
            this.BtnConsumosIndividuales.Click += new System.EventHandler(this.BtnConsumosIndividuales_Click);
            // 
            // BtnRegistroPagos
            // 
            this.BtnRegistroPagos.FlatAppearance.BorderSize = 0;
            this.BtnRegistroPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.BtnRegistroPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BtnRegistroPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroPagos.ForeColor = System.Drawing.Color.White;
            this.BtnRegistroPagos.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroPagos.Image")));
            this.BtnRegistroPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroPagos.Location = new System.Drawing.Point(3, 261);
            this.BtnRegistroPagos.Name = "BtnRegistroPagos";
            this.BtnRegistroPagos.Size = new System.Drawing.Size(200, 49);
            this.BtnRegistroPagos.TabIndex = 3;
            this.BtnRegistroPagos.Text = "Registro de pagos";
            this.BtnRegistroPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistroPagos.UseVisualStyleBackColor = true;
            this.BtnRegistroPagos.Click += new System.EventHandler(this.BtnRegistroPagos_Click);
            // 
            // BtnRegistroConsumos
            // 
            this.BtnRegistroConsumos.FlatAppearance.BorderSize = 0;
            this.BtnRegistroConsumos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.BtnRegistroConsumos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BtnRegistroConsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroConsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroConsumos.ForeColor = System.Drawing.Color.White;
            this.BtnRegistroConsumos.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroConsumos.Image")));
            this.BtnRegistroConsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroConsumos.Location = new System.Drawing.Point(3, 208);
            this.BtnRegistroConsumos.Name = "BtnRegistroConsumos";
            this.BtnRegistroConsumos.Size = new System.Drawing.Size(200, 49);
            this.BtnRegistroConsumos.TabIndex = 2;
            this.BtnRegistroConsumos.Text = "Registro de consumos";
            this.BtnRegistroConsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistroConsumos.UseVisualStyleBackColor = true;
            this.BtnRegistroConsumos.Click += new System.EventHandler(this.BtnRegistroConsumos_Click);
            // 
            // BtnRegistroPrecios
            // 
            this.BtnRegistroPrecios.FlatAppearance.BorderSize = 0;
            this.BtnRegistroPrecios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.BtnRegistroPrecios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BtnRegistroPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroPrecios.ForeColor = System.Drawing.Color.White;
            this.BtnRegistroPrecios.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroPrecios.Image")));
            this.BtnRegistroPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistroPrecios.Location = new System.Drawing.Point(3, 155);
            this.BtnRegistroPrecios.Name = "BtnRegistroPrecios";
            this.BtnRegistroPrecios.Size = new System.Drawing.Size(200, 49);
            this.BtnRegistroPrecios.TabIndex = 1;
            this.BtnRegistroPrecios.Text = "Registro de precios";
            this.BtnRegistroPrecios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistroPrecios.UseVisualStyleBackColor = true;
            this.BtnRegistroPrecios.Click += new System.EventHandler(this.BtnRegistroPrecios_Click);
            // 
            // BtnregistroClientes
            // 
            this.BtnregistroClientes.FlatAppearance.BorderSize = 0;
            this.BtnregistroClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.BtnregistroClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BtnregistroClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnregistroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnregistroClientes.ForeColor = System.Drawing.Color.White;
            this.BtnregistroClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnregistroClientes.Image")));
            this.BtnregistroClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnregistroClientes.Location = new System.Drawing.Point(3, 102);
            this.BtnregistroClientes.Name = "BtnregistroClientes";
            this.BtnregistroClientes.Size = new System.Drawing.Size(200, 49);
            this.BtnregistroClientes.TabIndex = 0;
            this.BtnregistroClientes.Text = "Registro de clientes";
            this.BtnregistroClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnregistroClientes.UseVisualStyleBackColor = true;
            this.BtnregistroClientes.Click += new System.EventHandler(this.BtnregistroClientes_Click);
            // 
            // PnlBarraTitulo
            // 
            this.PnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.PnlBarraTitulo.Controls.Add(this.label1);
            this.PnlBarraTitulo.Controls.Add(this.BtnRestaurar);
            this.PnlBarraTitulo.Controls.Add(this.BtnMaximizar);
            this.PnlBarraTitulo.Controls.Add(this.BtnMinimizar);
            this.PnlBarraTitulo.Controls.Add(this.BtnCerrar);
            this.PnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlBarraTitulo.Name = "PnlBarraTitulo";
            this.PnlBarraTitulo.Size = new System.Drawing.Size(1055, 40);
            this.PnlBarraTitulo.TabIndex = 0;
            this.PnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBarraTitulo_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administración de Agua Potable";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(977, 7);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(30, 27);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(977, 7);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(30, 27);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(941, 7);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(30, 27);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 1;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1013, 7);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 27);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 650);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 525);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PnlContenedor.ResumeLayout(false);
            this.PnlMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlBarraTitulo.ResumeLayout(false);
            this.PnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Panel PnlFormularios;
        private System.Windows.Forms.Panel PnlMenus;
        private System.Windows.Forms.Panel PnlBarraTitulo;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Button BtnConsumosTotales;
        private System.Windows.Forms.Button BtnConsumosIndividuales;
        private System.Windows.Forms.Button BtnRegistroPagos;
        private System.Windows.Forms.Button BtnRegistroConsumos;
        private System.Windows.Forms.Button BtnRegistroPrecios;
        private System.Windows.Forms.Button BtnregistroClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

