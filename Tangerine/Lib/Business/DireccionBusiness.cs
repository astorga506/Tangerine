using Lib.Data;
using Lib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Business
{
    public class DireccionBusiness
    {
        private DireccionData dd;

        public DireccionBusiness(String cadenaConexion)
        {
            dd = new DireccionData(cadenaConexion);
        }

        public List<Distrito> GetDistritos(String codProvincia, String codCanton)
        {
            return dd.GetDistritos(codProvincia, codCanton);
        }

        public List<Canton> GetCantones(String codProvincia)
        {
            return dd.GetCantones(codProvincia);       
        }

        public List<Provincia> GetProvincias()
        {
            return dd.GetProvincias();
        }
    }
}
