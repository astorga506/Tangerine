namespace TangerineApplication
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiAccion,
            this.tsmiAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalir});
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(152, 22);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.salir);
            // 
            // tsmiAccion
            // 
            this.tsmiAccion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevo,
            this.tsmiEditar,
            this.tsmiEliminar});
            this.tsmiAccion.Name = "tsmiAccion";
            this.tsmiAccion.Size = new System.Drawing.Size(56, 20);
            this.tsmiAccion.Text = "Acción";
            // 
            // tsmNuevo
            // 
            this.tsmNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevoCliente,
            this.tsmiNuevoProveedor,
            this.tsmiNuevoProducto});
            this.tsmNuevo.Name = "tsmNuevo";
            this.tsmNuevo.Size = new System.Drawing.Size(152, 22);
            this.tsmNuevo.Text = "Nuevo";
            // 
            // tsmiNuevoCliente
            // 
            this.tsmiNuevoCliente.Name = "tsmiNuevoCliente";
            this.tsmiNuevoCliente.Size = new System.Drawing.Size(152, 22);
            this.tsmiNuevoCliente.Text = "Cliente";
            this.tsmiNuevoCliente.Click += new System.EventHandler(this.NuevoCliente);
            // 
            // tsmiNuevoProveedor
            // 
            this.tsmiNuevoProveedor.Name = "tsmiNuevoProveedor";
            this.tsmiNuevoProveedor.Size = new System.Drawing.Size(152, 22);
            this.tsmiNuevoProveedor.Text = "Proveedor";
            // 
            // tsmiNuevoProducto
            // 
            this.tsmiNuevoProducto.Name = "tsmiNuevoProducto";
            this.tsmiNuevoProducto.Size = new System.Drawing.Size(152, 22);
            this.tsmiNuevoProducto.Text = "Producto";
            // 
            // tsmiEditar
            // 
            this.tsmiEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditarCliente,
            this.tsmiEditarProveedor,
            this.tsmiEditarProducto});
            this.tsmiEditar.Name = "tsmiEditar";
            this.tsmiEditar.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditar.Text = "Editar";
            // 
            // tsmiEditarCliente
            // 
            this.tsmiEditarCliente.Name = "tsmiEditarCliente";
            this.tsmiEditarCliente.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditarCliente.Text = "Cliente";
            this.tsmiEditarCliente.Click += new System.EventHandler(this.EditarCliente);
            // 
            // tsmiEditarProveedor
            // 
            this.tsmiEditarProveedor.Name = "tsmiEditarProveedor";
            this.tsmiEditarProveedor.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditarProveedor.Text = "Proveedor";
            // 
            // tsmiEditarProducto
            // 
            this.tsmiEditarProducto.Name = "tsmiEditarProducto";
            this.tsmiEditarProducto.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditarProducto.Text = "Producto";
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEliminarCliente,
            this.tsmiEliminarProveedor,
            this.tsmiEliminarProducto});
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(152, 22);
            this.tsmiEliminar.Text = "Eliminar";
            // 
            // tsmiEliminarCliente
            // 
            this.tsmiEliminarCliente.Name = "tsmiEliminarCliente";
            this.tsmiEliminarCliente.Size = new System.Drawing.Size(152, 22);
            this.tsmiEliminarCliente.Text = "Cliente";
            // 
            // tsmiEliminarProveedor
            // 
            this.tsmiEliminarProveedor.Name = "tsmiEliminarProveedor";
            this.tsmiEliminarProveedor.Size = new System.Drawing.Size(152, 22);
            this.tsmiEliminarProveedor.Text = "Proveedor";
            // 
            // tsmiEliminarProducto
            // 
            this.tsmiEliminarProducto.Name = "tsmiEliminarProducto";
            this.tsmiEliminarProducto.Size = new System.Drawing.Size(152, 22);
            this.tsmiEliminarProducto.Text = "Producto";
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAcercaDe});
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(53, 20);
            this.tsmiAyuda.Text = "Ayuda";
            // 
            // tsmiAcercaDe
            // 
            this.tsmiAcercaDe.Name = "tsmiAcercaDe";
            this.tsmiAcercaDe.Size = new System.Drawing.Size(152, 22);
            this.tsmiAcercaDe.Text = "Acerca De";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 618);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccion;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoProveedor;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarProveedor;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarProveedor;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmiAcercaDe;
    }
}