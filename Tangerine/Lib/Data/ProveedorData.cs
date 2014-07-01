using Lib.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Data
{
    public class ProveedorData
    {
        private String cadenaConexion;

        public ProveedorData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public Proveedor InsertarProveedor(Proveedor proveedor)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                SqlCommand cmd = con.CreateCommand();

                cmd.Transaction = tran;
                try
                {                    
                    new DireccionData(cadenaConexion).InsertarDireccion(proveedor.Direccion, cmd);
                    cmd.Parameters.Clear();
                    SqlParameter param = new SqlParameter("@cod_proveedor", System.Data.SqlDbType.Int);                    
                    cmd.CommandText = "sp_insertar_proveedor";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    param.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(param);
                    cmd.Parameters.Add(new SqlParameter("@nombre_proveedor", proveedor.NombreProveedor));
                    cmd.ExecuteNonQuery();
                    proveedor.CodProveedor = Int32.Parse(cmd.Parameters["@cod_proveedor"].ToString());
                    
                    tran.Commit();
                }//try
                catch (SqlException ex)
                {
                    tran.Rollback();
                    throw ex;                
                }//catch              
        

            }//using con

            return proveedor;
        }//InsertarProveedor

        public Proveedor EditarProveedor(Proveedor proveedor)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                SqlCommand cmd = con.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandText = "sp_editar_proveedor";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cod_proveedor", proveedor.CodProveedor));
                cmd.Parameters.Add(new SqlParameter("@nombre_proveedor", proveedor.NombreProveedor));

                try
                {
                    cmd.ExecuteNonQuery();
                    new DireccionData(cadenaConexion).EditarDireccion(proveedor.Direccion, cmd);
                    tran.Commit();
                }
                catch (SqlException ex)
                {
                    tran.Rollback();
                    throw ex;
                }

            }//using con

            return proveedor;
        }//EditarProveedor

        public void EliminarProveedor(Proveedor proveedor)
        {
            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                SqlCommand cmd = con.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandText = "sp_eliminar_proveedor";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cod_proveedor", proveedor.CodProveedor));

                try
                {
                    cmd.ExecuteNonQuery();
                    new DireccionData(cadenaConexion).EliminarDireccion(proveedor.Direccion.CodDireccion, cmd);
                    tran.Commit();
                }//try
                catch (SqlException ex)
                {
                    tran.Rollback();
                    throw ex;
                }//catch
            }//using con        
        }//EliminarProveedor

        public Proveedor GetProveedor(int codProveedor) 
        {
            Proveedor proveedor = new Proveedor();
            using(SqlConnection con = new SqlConnection(cadenaConexion))
            {
                con.Open();
                String sqlSelect = "SELECT cod_proveedor, nombre_proveedor, cod_direccion" +
                                        " FROM Proveedor" +
                                        " WHERE cod_proveedor = " + codProveedor;
                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    proveedor.CodProveedor = Int32.Parse(dr["cod_proveedor"].ToString());
                    proveedor.NombreProveedor = dr.GetString(1);
                    proveedor.Direccion = new DireccionData(cadenaConexion).GetDireccion(Int32.Parse(dr["cod_direccion"].ToString()));                
                }//if
            }//using con
            return proveedor;
        }

    }//ProveedorData
}//namespace
