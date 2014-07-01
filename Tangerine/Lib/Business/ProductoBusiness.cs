using Lib.Data;
using Lib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Business
{
    public class ProductoBusiness
    {
        private ProductoData pd;

        public ProductoBusiness(String cadenaConexion)
        {
            pd = new ProductoData(cadenaConexion);
        }

        public Producto InsertarProducto(Producto producto)
        {
            return pd.InsertarProducto(producto);
        }

        public Producto EditarProducto(Producto producto)
        {
            return pd.EditarProducto(producto);
        }

        public void ElimninarProducto(Producto producto)
        {
            pd.ElimninarProducto(producto);
        }

        public List<Producto> GetProductos(String palabraBusqueda)
        {
            return pd.GetProductos(palabraBusqueda);
        }
    }
}
