using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private String _direccionEntrega;
        private EEstado _estado;
        private String _trackingID;

        public String DireccionEntrega
        {
            get
            {
                return "";
            }
            set
            {

            }
        }

        public EEstado Estado
        {
            get
            {
                return EEstado.Ingresado;
            }
            set
            {

            }
        }

        public String TrackingID
        {
            get
            {
                return "";
            }
            set
            {

            }
        }

        public void MockCicloDeVida()
        {

        }
        
        public String MostrarDatos(IMostrar<Paquete> elemento)
        {
            return "";
        }
        
        public static Boolean operator !=(Paquete p1, Paquete p2)
        {
            Boolean resultado = !(p1 == p2);

            return resultado;
        }
        
        public static Boolean operator ==(Paquete p1, Paquete p2)
        {
            Boolean resultado = false;



            return resultado;
        }

        public Paquete(String direccionEntrega, String trackingID)
        {

        }

        public String ToString()
        {
            return "";
        }

        /*private DelegadoEstado InformaEstado(object sender, EventArgs e) // Debe retornar.
        {
            return new MiDelegado(miClase.MiMetodo);
        }*/

        public delegate void DelegadoEstado(object sender, EventArgs e); 
        
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}


