using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
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

        public static Boolean operator ==(Paquete p1, Paquete p2)
        {
            Boolean resultado = false;



            return resultado;
        }

        public static Boolean operator !=(Paquete p1, Paquete p2)
        {
            Boolean resultado = !(p1==p2);

            return resultado;
        }

        public Paquete(String direccionEntrega, String trackingID)
        {

        }

        public String ToString()
        {
            return "";
        }

        

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}


