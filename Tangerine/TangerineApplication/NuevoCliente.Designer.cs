namespace TangerineApplication
{
    partial class NuevoCliente
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
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbCodPostal = new System.Windows.Forms.TextBox();
            this.cmbCanton = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(81, 283);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(105, 20);
            this.tbTelefono.TabIndex = 44;
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.Location = new System.Drawing.Point(83, 230);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(305, 20);
            this.tbUbicacion.TabIndex = 43;
            // 
            // tbCodPostal
            // 
            this.tbCodPostal.Location = new System.Drawing.Point(297, 283);
            this.tbCodPostal.Name = "tbCodPostal";
            this.tbCodPostal.ReadOnly = true;
            this.tbCodPostal.Size = new System.Drawing.Size(67, 20);
            this.tbCodPostal.TabIndex = 42;
            // 
            // cmbCanton
            // 
            this.cmbCanton.FormattingEnabled = true;
            this.cmbCanton.Location = new System.Drawing.Point(81, 383);
            this.cmbCanton.Name = "cmbCanton";
            this.cmbCanton.Size = new System.Drawing.Size(181, 21);
            this.cmbCanton.TabIndex = 41;
            this.cmbCanton.SelectedIndexChanged += new System.EventHandler(this.CmbCanton);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(83, 331);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(179, 21);
            this.cmbProvincia.TabIndex = 40;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.CmbProvincia);
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(81, 437);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(181, 21);
            this.cmbDistrito.TabIndex = 39;
            this.cmbDistrito.SelectedIndexChanged += new System.EventHandler(this.CmbDistrito);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 385);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Cantón:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Provincia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Distrito:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Código Postal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Dirección";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(83, 134);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(158, 20);
            this.tbCorreo.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Correo:";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(328, 86);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(145, 20);
            this.tbApellidos.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Apellidos:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(83, 86);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(158, 20);
            this.tbNombre.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nuevo Cliente:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(0, 1);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 23);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 498);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NuevoCliente";
            this.Text = "Nuevo Cliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.TextBox tbCodPostal;
        private System.Windows.Forms.ComboBox cmbCanton;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnGuardar;

    }
}