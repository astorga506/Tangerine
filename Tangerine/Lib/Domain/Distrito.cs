using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class Distrito
    {
        private int codDistrito;
        private String nombreDistrito;

        public Distrito()
        {

        }

        public String NombreDistrito
        {
            get { return nombreDistrito; }
            set { nombreDistrito = value; }
        }
        

        public int CodDistrito
        {
            get { return codDistrito; }
            set { codDistrito = value; }
        }
        
    }
}
