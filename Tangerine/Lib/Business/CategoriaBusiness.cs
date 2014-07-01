using Lib.Data;
using Lib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Business
{
    public class CategoriaBusiness
    {
        private CategoriaData cd;

        public CategoriaBusiness(String cadenaConexion)
        {
            cd = new CategoriaData(cadenaConexion);
        }

        public List<Categoria> GetCategorias()
        {
            return cd.GetCategorias();
        }
    }
}
