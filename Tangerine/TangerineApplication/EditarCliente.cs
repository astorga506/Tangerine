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
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
            String cadenaConexion = ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString;

            cmbProvincia.DataSource = new DireccionBusiness(cadenaConexion).GetProvincias();
            cmbProvincia.ValueMember = "CodProvincia";
            cmbProvincia.DisplayMember = "NombreProvincia";
            cmbProvincia.SelectedIndex = 0;

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
            cbHabilitar.Enabled = true;

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
                tbNombre.Enabled = true;
                tbApellidos.Enabled = true;
                tbCorreo.Enabled = true;
                tbUbicacion.Enabled = true;
                tbTelefono.Enabled = true;
                cmbProvincia.Enabled = true;
                cmbCanton.Enabled = true;
                cmbDistrito.Enabled = true;
            }//if
            else 
            {
                tbNombre.Enabled = false;
                tbApellidos.Enabled = false;
                tbCorreo.Enabled = false;
                tbUbicacion.Enabled = false;
                tbTelefono.Enabled = false;
                cmbProvincia.Enabled = false;
                cmbCanton.Enabled = false;
                cmbDistrito.Enabled = false;            
            }//else
        }//CbEditar
    }//class
}//namespace
