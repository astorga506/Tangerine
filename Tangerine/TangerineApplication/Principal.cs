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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
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
        }//Editar Cliente

    }//Class
}//Namespace
