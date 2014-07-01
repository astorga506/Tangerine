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
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
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
        }//NuevoCliente

        private void CmbProvincia(object sender, EventArgs e)
        {
            String cadenaConexion = ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString;
            ComboBox cmb = (ComboBox)sender;
            Provincia prov = (Provincia)cmb.SelectedItem;
            cmbCanton.DataSource = new DireccionBusiness(cadenaConexion).GetCantones(prov.CodProvincia);
        }//CmbProvincia

        private void CmbCanton(object sender, EventArgs e)
        {
            String cadenaConexion = ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString;
            Provincia prov = (Provincia)cmbProvincia.SelectedItem;
            ComboBox cmb = (ComboBox)sender;
            Canton canton = (Canton)cmb.SelectedItem;
            cmbDistrito.DataSource = new DireccionBusiness(cadenaConexion).GetDistritos(prov.CodProvincia, canton.CodCanton);
        }//CmbCanton

        private void CmbDistrito(object sender, EventArgs e)
        {
            Provincia prov = (Provincia)cmbProvincia.SelectedItem;
            Canton canton = (Canton)cmbCanton.SelectedItem;
            ComboBox cmb = (ComboBox)sender;
            Distrito dist = (Distrito)cmb.SelectedItem;

            tbCodPostal.Text = prov.CodProvincia + canton.CodCanton + dist.CodDistrito;
        }//CmbDistrito

        private void BtnGuardar(object sender, EventArgs e)
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

            if (insertar)
            {
                var resultado = MessageBox.Show(this, "Se guardarán los cambios realizados, estos podrían ser cambios posteriormente ¿Desea continuar?", "Confirmar cambios", MessageBoxButtons.YesNo);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    Cliente cliente = new Cliente();
                    cliente.NombreCliente = tbNombre.Text;
                    cliente.ApellidosCliente = tbApellidos.Text;
                    cliente.Correo = tbCorreo.Text;
                    cliente.Direccion.Ubicacion = tbUbicacion.Text;
                    cliente.Direccion.Telefono = Int32.Parse(tbTelefono.Text);
                    cliente.Direccion.Provincia = (Provincia)cmbProvincia.SelectedItem;
                    cliente.Direccion.Canton = (Canton)cmbCanton.SelectedItem;
                    cliente.Direccion.Distrito = (Distrito)cmbDistrito.SelectedItem;
                    cliente.Direccion.CodPostal = tbCodPostal.Text;

                    new ClienteBusiness(ConfigurationManager.ConnectionStrings["Cocoa"].ConnectionString).InsertarCliente(cliente);
                }//se desean guardar los cambios                

            }//se puede insertar
            else
            {
                MessageBox.Show(this, "Compruebe que no haya dejado espacios en blanco y que la información sea valida", "No se ha podido completar la acción", MessageBoxButtons.OK);
            }//no se puede insertar
        }//BtnGuardar
    }
}
