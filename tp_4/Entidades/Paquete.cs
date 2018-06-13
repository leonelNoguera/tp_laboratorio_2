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
                return this._direccionEntrega;
            }
            set
            {
                this._direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this._estado;
            }
            set
            {
                this._estado = value;
            }
        }

        public String TrackingID
        {
            get
            {
                return this._trackingID;
            }
            set
            {
                this._trackingID = value;
            }
        }

        public void MockCicloDeVida()
        {

        }

        /*MostrarDatos utilizará string.Format con el siguiente formato "{0} para {1}", p.trackingID,
        p.direccionEntrega para compilar la información del paquete.*/
        public String MostrarDatos(IMostrar<Paquete> elemento)
        {
            String retorno = "";
            // Aún falta...
            retorno = String.Format("" + elemento.ToString());
            
            return retorno;
        }
        
        public static Boolean operator !=(Paquete p1, Paquete p2)
        {
            /*Boolean resultado = !(p1 == p2);
            return resultado;*/
            return !(p1 == p2);
        }
        
        public static Boolean operator ==(Paquete p1, Paquete p2)
        {
            /*Boolean resultado = false;

            if (p1.TrackingID.Equals(p2.TrackingID))
            {
                resultado = true;
            }

            return resultado;*/

            return p1.TrackingID.Equals(p2.TrackingID);
        }

        public Paquete(String direccionEntrega, String trackingID)
        {

        }

        public override String ToString()
        {
            return "";
        }

        /*private void InformaEstado(object sender, EventArgs e) // Debe retornar.
        {
            //return new DelegadoEstado();
        }*/

        public event DelegadoEstado InformaEstado;

        public delegate void DelegadoEstado(object sender, EventArgs e); 
        
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}


