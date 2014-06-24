using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class Producto
    {
        private int codProducto;
        private String nombreProducto;
        private String descripcionProducto;
        private byte[] imagen;
        private String fabricante;
        private int cantDisponible;
        private float precioUnitario;
        private Proveedor proveedor;
        private Categoria categoria;

        public Producto()
        {
            proveedor = new Proveedor();
            categoria = new Categoria();
        }

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        

        public float PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }
        

        public int CantDisponible
        {
            get { return cantDisponible; }
            set { cantDisponible = value; }
        }
        

        public String Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        

        public byte[] Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        

        public String DescripcionProducto
        {
            get { return descripcionProducto; }
            set { descripcionProducto = value; }
        }
        

        public String NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }
        

        public int CodProducto
        {
            get { return codProducto; }
            set { codProducto = value; }
        }
        

    }
}
