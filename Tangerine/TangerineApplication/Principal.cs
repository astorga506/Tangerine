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

        private void salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cliente(object sender, EventArgs e)
        {
            Form[] hijos = this.MdiChildren;

            int i = 0;
            Boolean encontrado = false;
            while (i < hijos.Length && !encontrado)
            {
                if (hijos[i].Name == "ClienteForm")
                {
                    encontrado = true;
                    hijos[i].Focus();
                    hijos[i].WindowState = FormWindowState.Normal;
                }
                i++;
            }//buscar
            if (!encontrado)
            {
                ClienteForm cliente = new ClienteForm();
                cliente.MdiParent = this;
                cliente.Show();
            }

        }

    }//Class
}//Namespace
