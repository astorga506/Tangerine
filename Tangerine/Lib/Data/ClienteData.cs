using Lib.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data
{
    public class ClienteData
    {
        private String cadenaConexion;
        public ClienteData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }//ClienteData

        public Cliente EditarCliente(Cliente cliente)
        {
            using(SqlConnection con = new SqlConnection())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "sp_editar_cliente";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Transaction = tran;

                cmd.Parameters.Add(new SqlParameter("@id_cliente", cliente.IdCliente));
                cmd.Parameters.Add(new SqlParameter("@correo", cliente.Correo));
                cmd.Parameters.Add(new SqlParameter("@nombre_cliente", cliente.NombreCliente));
                cmd.Parameters.Add(new SqlParameter("@apellidos", cliente.ApellidosCliente));

                try
                {
                    cmd.ExecuteNonQuery();
                    new DireccionData(cadenaConexion).EditarDireccion(cliente.Direccion);

                    tran.Commit();
                }//try
                catch (SqlException ex)
                {
                    tran.Rollback();
                    throw ex;                    
                }//catch
                
            }//using con

            return cliente;
        }//EditarCliente

        public Cliente InsertarCliente(Cliente cliente) 
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                SqlCommand cmd = con.CreateCommand();
                SqlParameter param = new SqlParameter();
                cmd.CommandText = "sp_insertar_cliente";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Transaction = tran;                
                param.ParameterName = "@id_cliente";
                param.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@correo", cliente.Correo));
                cmd.Parameters.Add(new SqlParameter("@nombre_cliente", cliente.NombreCliente));
                cmd.Parameters.Add(new SqlParameter("@apellidos", cliente.ApellidosCliente));

                try
                {
                    cmd.ExecuteNonQuery();
                    cliente.IdCliente = Int32.Parse(cmd.Parameters["@id_cliente"].Value.ToString());
                    new DireccionData(cadenaConexion).InsertarDireccion(cliente.Direccion);                  
                  
                    tran.Commit();
                }//try
                catch (SqlException ex)
                {
                    tran.Rollback();
                    throw ex;
                }//catch
            }//using con

            return cliente;

        }//InsertarCliente

        public void EliminarCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                SqlCommand cmd = con.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandText = "sp_eliminar_cliente";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_cliente", cliente.IdCliente));

                try
                {
                    cmd.ExecuteNonQuery();
                    new DireccionData(cadenaConexion).EliminarDireccion(cliente.Direccion.CodDireccion);
                    
                }//try
                catch (SqlException ex)
                {
                    tran.Rollback();
                    throw ex;
                }//catch
            }//using con        
        }//EliminarCliente


        public LinkedList<Cliente> GetClientes(String palabraBusqueda)
        {
            LinkedList<Cliente> clientes = new LinkedList<Cliente>();

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "sp_obtener_clientes";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@palabra_busqueda",System.Data.SqlDbType.VarChar);
                cmd.Parameters.Add(param);
                SqlDataReader drCliente =  cmd.ExecuteReader();

                while(drCliente.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Int32.Parse(drCliente["id_cliente"].ToString());
                    cliente.Correo = drCliente.GetString(1);
                    cliente.NombreCliente = drCliente.GetString(2);
                    cliente.ApellidosCliente = drCliente.GetString(3);
                    cliente.Direccion = new DireccionData(cadenaConexion).GetDireccion(Int32.Parse(drCliente["cod_direccion"].ToString()));

                    clientes.AddLast(cliente);
                }//while

            }//using con

            return clientes;
        }//GetClientes

    }//class
}//namespace
