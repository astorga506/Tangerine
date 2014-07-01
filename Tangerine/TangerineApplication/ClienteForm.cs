using Lib.Business;
using Lib.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TangerineApplication
{
    public partial class ClienteForm : Form
    {
        private Boolean nuevo = true;

        public ClienteForm()
        {
            InitializeComponent();
            String cadenaConexion = ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString;

            cmbProvincia.DataSource = new DireccionBusiness(cadenaConexion).GetProvincias();
            cmbProvincia.ValueMember = "CodProvincia";
            cmbProvincia.DisplayMember = "NombreProvincia";

            cmbCanton.ValueMember = "CodCanton";
            cmbCanton.DisplayMember = "NombreCanton";

            cmbDistrito.ValueMember = "CodDistrito";
            cmbDistrito.DisplayMember = "NombreDistrito";

            lbClientes.DisplayMember = "NombreCompleto";            
        }//EditarCliente

        private void BuscarClientes(object sender, EventArgs e)
        {
            String cadenaConexion = ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString;            
            lbClientes.DataSource = new ClienteBusiness(cadenaConexion).GetClientes(tbBusqueda.Text);
        }//btnBuscar

        private void MostarCliente(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente) lbClientes.SelectedItem;
            cbHabilitar.Checked = false;
            cbHabilitar.Visible = true;
            Habilitar(false);
            nuevo = false;
            lblHeader.Text = "Editar Información";

            tbNombre.Text = cliente.NombreCliente;
            tbApellidos.Text = cliente.ApellidosCliente;
            tbCorreo.Text = cliente.Correo;
            tbUbicacion.Text = cliente.Direccion.Ubicacion;
            tbTelefono.Text = cliente.Direccion.Telefono.ToString();


            cmbProvincia.SelectedValue = cliente.Direccion.Provincia.CodProvincia;
            cmbCanton.SelectedValue = cliente.Direccion.Canton.CodCanton;
            cmbDistrito.SelectedValue = cliente.Direccion.Distrito.CodDistrito;           

        }

        private void CmbProvincia(object sender, EventArgs e)
        {
            String cadenaConexion = ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString;
            ComboBox cmb = (ComboBox)sender;
            Provincia prov = (Provincia)cmb.SelectedItem;
            cmbCanton.DataSource = new DireccionBusiness(cadenaConexion).GetCantones(prov.CodProvincia);

        }

        private void CmbCanton(object sender, EventArgs e)
        {
            String cadenaConexion = ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString;
            Provincia prov = (Provincia) cmbProvincia.SelectedItem;
            ComboBox cmb = (ComboBox)sender;
            Canton canton = (Canton)cmb.SelectedItem;
            cmbDistrito.DataSource = new DireccionBusiness(cadenaConexion).GetDistritos(prov.CodProvincia, canton.CodCanton);
        }

        private void CmbDistrito(object sender, EventArgs e)
        {
            Provincia prov = (Provincia)cmbProvincia.SelectedItem;
            Canton canton = (Canton)cmbCanton.SelectedItem;
            ComboBox cmb = (ComboBox)sender;
            Distrito dist = (Distrito)cmb.SelectedItem;

            tbCodPostal.Text = prov.CodProvincia + canton.CodCanton + dist.CodDistrito;
        }

        private void CbEditar(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox) sender;
            if (cb.Checked)
            {
                Habilitar(true);
            }//if
            else 
            {
                Habilitar(false);
            }//else
        }//CbEditar

        private void Eliminar(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)lbClientes.SelectedItem;

            var resultado = MessageBox.Show(this, "Se eliminará la información del cliente ¿Desea continuar?", "Borrar información", MessageBoxButtons.YesNo);

            if (resultado == System.Windows.Forms.DialogResult.Yes) 
            {
                new ClienteBusiness(ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString).EliminarCliente(cliente);
            }        
        }

        private void Nuevo(object sender, EventArgs e)
        {
            cbHabilitar.Visible = false;
            nuevo = true;
            lblHeader.Text = "Nuevo Cliente";
            Habilitar(true);

            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbCorreo.Text = "";
            tbUbicacion.Text = "";
            tbTelefono.Text = "";
            cmbProvincia.SelectedIndex = 0;
            cmbCanton.SelectedIndex = 0;
            cmbDistrito.SelectedIndex = 0;            
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (nuevo)
            {
                if (Validar())
                {
                    var resultado = MessageBox.Show(this, "Se guardarán los cambios realizados, estos podrían ser cambios posteriormente ¿Desea continuar?", "Guardar información", MessageBoxButtons.YesNo);

                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        Cliente cliente = new Cliente();
                        RecuperarDatos(cliente);

                        new ClienteBusiness(ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString).InsertarCliente(cliente);
                    }//se desean guardar los cambios                

                }//se puede insertar
                else
                {
                    MessageBox.Show(this, "Compruebe que no haya dejado espacios en blanco y que la información sea valida", "No se ha podido completar la acción", MessageBoxButtons.OK);
                }//no se puede insertar
            }
            else             
            {
                Cliente cliente = (Cliente)lbClientes.SelectedItem;

                if (Validar())
                {
                    var resultado = MessageBox.Show(this, "Se guardarán los cambios realizados, es probable que esta acción sea irreversible ¿Desea continuar?", "Confirmar cambios", MessageBoxButtons.YesNo);

                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        RecuperarDatos(cliente);

                        new ClienteBusiness(ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString).EditarCliente(cliente);
                    }//se desean guardar los cambios                

                }//se puede insertar
                else
                {
                    MessageBox.Show(this, "Compruebe que no haya dejado espacios en blanco y que la información sea valida", "No se ha podido completar la acción", MessageBoxButtons.OK);
                }//no se puede insertar            
            }
        }//BtnGuardar

        public Boolean Validar()
        {
            Boolean insertar = true;

            if (tbNombre.Text == "")
            {
                insertar = false;
            }
            if (tbApellidos.Text == "")
            {
                insertar = false;
            }
            if (tbCorreo.Text == "")
            {
                insertar = false;
            }
            if (tbUbicacion.Text == "")
            {
                insertar = false;
            }
            if (tbTelefono.Text == "")
            {
                insertar = false;
            }

            return insertar;
        }

        public Cliente RecuperarDatos(Cliente cliente)
        {
            cliente.NombreCliente = tbNombre.Text;
            cliente.ApellidosCliente = tbApellidos.Text;
            cliente.Correo = tbCorreo.Text;
            cliente.Direccion.Ubicacion = tbUbicacion.Text;
            cliente.Direccion.Telefono = Int32.Parse(tbTelefono.Text);
            cliente.Direccion.Provincia = (Provincia)cmbProvincia.SelectedItem;
            cliente.Direccion.Canton = (Canton)cmbCanton.SelectedItem;
            cliente.Direccion.Distrito = (Distrito)cmbDistrito.SelectedItem;
            cliente.Direccion.CodPostal = tbCodPostal.Text;

            return cliente;        
        }

        public void Habilitar(Boolean bol)
        {
            tbNombre.Enabled = bol;
            tbApellidos.Enabled = bol;
            tbCorreo.Enabled = bol;
            tbUbicacion.Enabled = bol;
            tbTelefono.Enabled = bol;
            cmbProvincia.Enabled = bol;
            cmbCanton.Enabled = bol;
            cmbDistrito.Enabled = bol;
        }

    }//class
}//namespace
