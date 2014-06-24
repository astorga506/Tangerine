using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Domain
{
    public class Orden
    {
        private int idOrden;
        private DateTime fechaOrden;
        private String estadoEnvio;
        private String courier;
        private float montoTotal;
        private String enviarANombre;
        private String enviarAApellidos;
        private int numTarjeta;
        private DateTime fechaExpiracion;
        private String tipoTarjeta;
        private String provincia;
        private String canton;
        private String distrito;
        private String direccion;
        private String codPostal;
        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        

        public Orden()
        {
            cliente = new Cliente();
        }

        public String CodPostal
        {
            get { return codPostal; }
            set { codPostal = value; }
        }
        

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public String Distrito
        {
            get { return distrito; }
            set { distrito = value; }
        }
        

        public String Canton
        {
            get { return canton; }
            set { canton = value; }
        }
        

        public String Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }
        

        public String TipoTarjeta
        {
            get { return tipoTarjeta; }
            set { tipoTarjeta = value; }
        }
        

        public DateTime FechaExpiracion
        {
            get { return fechaExpiracion; }
            set { fechaExpiracion = value; }
        }
        

        public int NumTarjeta
        {
            get { return numTarjeta; }
            set { numTarjeta = value; }
        }
        

        public String EnviarAApellidos
        {
            get { return enviarAApellidos; }
            set { enviarAApellidos = value; }
        }
        

        public String EnviarANombre
        {
            get { return enviarANombre; }
            set { enviarANombre = value; }
        }
        

        public float MontoTotal
        {
            get { return montoTotal; }
            set { montoTotal = value; }
        }
        

        public String Courier
        {
            get { return courier; }
            set { courier = value; }
        }
        

        public String EstadoEnvio
        {
            get { return estadoEnvio; }
            set { estadoEnvio = value; }
        }
        

        public DateTime FechaOrden
        {
            get { return fechaOrden; }
            set { fechaOrden = value; }
        }
        

        public int IdOrden
        {
            get { return idOrden; }
            set { idOrden = value; }
        }
        
    }
}
