using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class Proveedor
    {
        private int codProveedor;
        private String nombreProveedor;
        private Direccion direccion;

        public Proveedor()
        {
            direccion = new Direccion();
        }

        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public String NombreProveedor
        {
            get { return nombreProveedor; }
            set { nombreProveedor = value; }
        }
        

        public int CodProveedor
        {
            get { return codProveedor; }
            set { codProveedor = value; }
        }
        
    }
}
