using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class Provincia
    {
        private String codProvincia;
        private String nombreProvincia;

        public Provincia()
        {

        }

        public String NombreProvincia
        {
            get { return nombreProvincia; }
            set { nombreProvincia = value; }
        }
        

        public String CodProvincia
        {
            get { return codProvincia; }
            set { codProvincia = value; }
        }
        
    }
}
