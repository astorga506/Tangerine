using Lib.Data;
using Lib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Business
{
    public class ClienteBusiness
    {

        private ClienteData cd;

        public ClienteBusiness(String cadenaConexion)
        {
            cd = new ClienteData(cadenaConexion);
        }//ClienteBusiness

        public Cliente EditarCliente(Cliente cliente)
        {
            return cd.EditarCliente(cliente);
        }//EditarCliente

        public List<Cliente> GetClientes(String palabraBusqueda)
        {
            return cd.GetClientes(palabraBusqueda);
        }//GeClientes

        public Cliente InsertarCliente(Cliente cliente)
        {
            return cd.InsertarCliente(cliente);
        }//InsertarCliente

        public void EliminarCliente(Cliente cliente)
        {
            cd.EliminarCliente(cliente);
        }//EliminarCliente
    }
}
