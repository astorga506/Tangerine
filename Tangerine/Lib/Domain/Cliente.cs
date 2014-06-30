using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class Cliente
    {
        private int idCliente;
        private String correo;
        private String nombreCliente;
        private String apellidosCliente;
        private String contrasena;
        private Direccion direccion;

        public Cliente()
        {
            direccion = new Direccion();
        }

        public String NombreCompleto 
        {
            get { return apellidosCliente + ", " + nombreCliente; }  
        }

        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        

        public String ApellidosCliente
        {
            get { return apellidosCliente; }
            set { apellidosCliente = value; }
        }
        

        public String NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        

    }
}
