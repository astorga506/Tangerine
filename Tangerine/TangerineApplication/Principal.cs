using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TangerineApplication
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void EditarCliente(object sender, EventArgs e)
        {
            Form [] hijos = this.MdiChildren;

            int i = 0;
            Boolean encontrado = false;
            while (i < hijos.Length && !encontrado)
            {
                if (hijos[i].Name == "EditarCliente")
                {
                    encontrado = true;
                    hijos[i].Focus();
                    hijos[i].WindowState = FormWindowState.Normal;
                }
                i++;
            }//buscar
            if (!encontrado)
            {
                EditarCliente editarCliente = new EditarCliente();
                editarCliente.MdiParent = this;
                editarCliente.Show();
            }
        }//EditarCliente

        private void NuevoCliente(object sender, EventArgs e)
        {
            Form[] hijos = this.MdiChildren;

            int i = 0;
            Boolean encontrado = false;
            while (i < hijos.Length && !encontrado)
            {
                if (hijos[i].Name == "NuevoCliente")
                {
                    encontrado = true;
                    hijos[i].Focus();
                    hijos[i].WindowState = FormWindowState.Normal;
                }
                i++;
            }//buscar
            if (!encontrado)
            {
                NuevoCliente nuevoCliente = new NuevoCliente();
                nuevoCliente.MdiParent = this;
                nuevoCliente.Show();
            }

        }//Nuevo Cliente

        private void salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }//Class
}//Namespace
