namespace Presentacion
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.DgvTablaUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHelp = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.LblUsuarios = new System.Windows.Forms.Label();
            this.LblUsuarioRegistrado = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblContrasenia = new System.Windows.Forms.Label();
            this.LblRol = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTablaUsuarios
            // 
            this.DgvTablaUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DgvTablaUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvTablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaUsuarios.Location = new System.Drawing.Point(16, 74);
            this.DgvTablaUsuarios.Name = "DgvTablaUsuarios";
            this.DgvTablaUsuarios.Size = new System.Drawing.Size(472, 150);
            this.DgvTablaUsuarios.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.LblUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 1;
            // 
            // BtnHelp
            // 
            this.BtnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHelp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnHelp.ErrorImage")));
            this.BtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("BtnHelp.Image")));
            this.BtnHelp.Location = new System.Drawing.Point(747, 4);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(20, 20);
            this.BtnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHelp.TabIndex = 7;
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
            // LblUsuarios
            // 
            this.LblUsuarios.AutoSize = true;
            this.LblUsuarios.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarios.ForeColor = System.Drawing.Color.White;
            this.LblUsuarios.Location = new System.Drawing.Point(12, 4);
            this.LblUsuarios.Name = "LblUsuarios";
            this.LblUsuarios.Size = new System.Drawing.Size(187, 22);
            this.LblUsuarios.TabIndex = 0;
            this.LblUsuarios.Text = "Gestión de usuarios";
            // 
            // LblUsuarioRegistrado
            // 
            this.LblUsuarioRegistrado.AutoSize = true;
            this.LblUsuarioRegistrado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioRegistrado.Location = new System.Drawing.Point(15, 46);
            this.LblUsuarioRegistrado.Name = "LblUsuarioRegistrado";
            this.LblUsuarioRegistrado.Size = new System.Drawing.Size(203, 24);
            this.LblUsuarioRegistrado.TabIndex = 2;
            this.LblUsuarioRegistrado.Text = "Usuarios registrados";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(40, 278);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(68, 19);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre:";
            this.LblNombre.Visible = false;
            // 
            // LblContrasenia
            // 
            this.LblContrasenia.AutoSize = true;
            this.LblContrasenia.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasenia.Location = new System.Drawing.Point(14, 309);
            this.LblContrasenia.Name = "LblContrasenia";
            this.LblContrasenia.Size = new System.Drawing.Size(94, 19);
            this.LblContrasenia.TabIndex = 4;
            this.LblContrasenia.Text = "Contraseña:";
            this.LblContrasenia.Visible = false;
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRol.Location = new System.Drawing.Point(74, 342);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(34, 19);
            this.LblRol.TabIndex = 5;
            this.LblRol.Text = "Rol:";
            this.LblRol.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(117, 278);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(371, 20);
            this.TxtNombre.TabIndex = 6;
            this.TxtNombre.Visible = false;
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(117, 309);
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.Size = new System.Drawing.Size(202, 20);
            this.TxtContrasenia.TabIndex = 7;
            this.TxtContrasenia.Visible = false;
            // 
            // CmbRol
            // 
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.CmbRol.Location = new System.Drawing.Point(117, 342);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(121, 21);
            this.CmbRol.TabIndex = 8;
            this.CmbRol.Visible = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(16, 230);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(227, 230);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(117, 230);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(117, 382);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 12;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Visible = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(227, 382);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.CmbRol);
            this.Controls.Add(this.TxtContrasenia);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.LblContrasenia);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblUsuarioRegistrado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvTablaUsuarios);
            this.Name = "Usuarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTablaUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnHelp;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Label LblUsuarios;
        private System.Windows.Forms.Label LblUsuarioRegistrado;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblContrasenia;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

