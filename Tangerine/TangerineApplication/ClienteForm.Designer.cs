namespace TangerineApplication
{
    partial class ClienteForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbCanton = new System.Windows.Forms.ComboBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbBusqueda = new System.Windows.Forms.ToolStripTextBox();
            this.cbHabilitar = new System.Windows.Forms.CheckBox();
            this.tsmiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(256, 45);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(120, 20);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Nuevo Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(324, 93);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(158, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellidos:";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(324, 126);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(158, 20);
            this.tbApellidos.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo:";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(324, 159);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(158, 20);
            this.tbCorreo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Teléfono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Código Postal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Distrito:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Provincia:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Cantón:";
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(322, 468);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(181, 21);
            this.cmbDistrito.TabIndex = 20;
            this.cmbDistrito.SelectedIndexChanged += new System.EventHandler(this.CmbDistrito);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(324, 362);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(179, 21);
            this.cmbProvincia.TabIndex = 21;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.CmbProvincia);
            // 
            // cmbCanton
            // 
            this.cmbCanton.FormattingEnabled = true;
            this.cmbCanton.Location = new System.Drawing.Point(322, 414);
            this.cmbCanton.Name = "cmbCanton";
            this.cmbCanton.Size = new System.Drawing.Size(181, 21);
            this.cmbCanton.TabIndex = 22;
            this.cmbCanton.SelectedIndexChanged += new System.EventHandler(this.CmbCanton);
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(509, 314);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.ReadOnly = true;
            this.tbCodPostal.Size = new System.Drawing.Size(67, 20);
            this.tbCodPostal.TabIndex = 23;
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(324, 261);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(252, 20);
            this.tbUbicacion.TabIndex = 24;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(322, 314);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(92, 20);
            this.tbTelefono.TabIndex = 25;
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.Location = new System.Drawing.Point(28, 76);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(197, 329);
            this.lbClientes.TabIndex = 26;
            this.lbClientes.SelectedIndexChanged += new System.EventHandler(this.MostarCliente);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.eToolStripMenuItem,
            this.tsmiNuevo,
            this.tsmiEliminar,
            this.tsmiGuardar,
            this.tbBusqueda,
            this.tsmiBuscar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 27);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(12, 23);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(12, 23);
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(100, 23);
            // 
            // cbHabilitar
            // 
            this.cbHabilitar.AutoSize = true;
            this.cbHabilitar.Location = new System.Drawing.Point(433, 50);
            this.cbHabilitar.Name = "cbHabilitar";
            this.cbHabilitar.Size = new System.Drawing.Size(15, 14);
            this.cbHabilitar.TabIndex = 29;
            this.cbHabilitar.UseVisualStyleBackColor = true;
            this.cbHabilitar.Visible = false;
            this.cbHabilitar.CheckedChanged += new System.EventHandler(this.CbEditar);
            // 
            // tsmiNuevo
            // 
            this.tsmiNuevo.Image = global::TangerineApplication.Properties.Resources.nuevo;
            this.tsmiNuevo.Name = "tsmiNuevo";
            this.tsmiNuevo.Size = new System.Drawing.Size(70, 23);
            this.tsmiNuevo.Text = "Nuevo";
            this.tsmiNuevo.Click += new System.EventHandler(this.Nuevo);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.Image = global::TangerineApplication.Properties.Resources.eliminar;
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(78, 23);
            this.tsmiEliminar.Text = "Eliminar";
            this.tsmiEliminar.Click += new System.EventHandler(this.Eliminar);
            // 
            // tsmiGuardar
            // 
            this.tsmiGuardar.Image = global::TangerineApplication.Properties.Resources.guardar;
            this.tsmiGuardar.Name = "tsmiGuardar";
            this.tsmiGuardar.Size = new System.Drawing.Size(77, 23);
            this.tsmiGuardar.Text = "Guardar";
            this.tsmiGuardar.Click += new System.EventHandler(this.Guardar);
            // 
            // tsmiBuscar
            // 
            this.tsmiBuscar.Image = global::TangerineApplication.Properties.Resources.buscar;
            this.tsmiBuscar.Name = "tsmiBuscar";
            this.tsmiBuscar.Size = new System.Drawing.Size(70, 23);
            this.tsmiBuscar.Text = "Buscar";
            this.tsmiBuscar.Click += new System.EventHandler(this.BuscarClientes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Clientes";
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHabilitar);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbUbicacion);
            this.Controls.Add(this.tbCodPostal);
            this.Controls.Add(this.cmbCanton);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.cmbDistrito);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClienteForm";
            this.Text = "Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbCanton;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox cbHabilitar;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardar;
        private System.Windows.Forms.ToolStripTextBox tbBusqueda;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscar;
        private System.Windows.Forms.Label label1;
    }
}