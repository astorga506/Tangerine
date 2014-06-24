using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class Direccion
    {
        private int codDireccion;
        private String ubicacion;
        private String codPostal;
        private int telefono;
        private Provincia provincia;
        private Canton canton;
        private Distrito distrito;

        public Direccion()
        {
            provincia = new Provincia();
            canton = new Canton();
            distrito = new Distrito();
        }

        public Distrito Distrito
        {
            get { return distrito; }
            set { distrito = value; }
        }
        

        public Canton Canton
        {
            get { return canton; }
            set { canton = value; }
        }
        

        public Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        

        public String CodPostal
        {
            get { return codPostal; }
            set { codPostal = value; }
        }
        

        public String Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        

        public int CodDireccion
        {
            get { return codDireccion; }
            set { codDireccion = value; }
        }
        
    }
}
