using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class Canton
    {
        private String codCanton;
        private String nombreCanton;

        public Canton()
        {

        }

        public String NombreCanton
        {
            get { return nombreCanton; }
            set { nombreCanton = value; }
        }


        public String CodCanton
        {
            get { return codCanton; }
            set { codCanton = value; }
        }
        
    }
}
