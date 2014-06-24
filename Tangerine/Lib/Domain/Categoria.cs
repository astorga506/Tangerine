using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class Categoria
    {
        private int codCategoria;
        private String nombreCategoria;

        public Categoria()
        {

        }//Categoria

        public String NombreCategoria
        {
            get { return nombreCategoria; }
            set { nombreCategoria = value; }
        }//NombreCategoria        

        public int CodCategoria
        {
            get { return codCategoria; }
            set { codCategoria = value; }
        }//CodCategoria
        
    }//class

}//namespace
