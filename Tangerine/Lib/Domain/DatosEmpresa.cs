using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class DatosEmpresa
    {
        private String nombreEmpresa;
        private int cedJuridica;
        private String correoContacto;
        private Direccion direccion;

        public DatosEmpresa()
        {
            direccion = new Direccion();
        }

        public Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public String CorreoContacto
        {
            get { return correoContacto; }
            set { correoContacto = value; }
        }
        

        public int CedJuridica
        {
            get { return cedJuridica; }
            set { cedJuridica = value; }
        }
        

        public String NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }
        
    }
}
