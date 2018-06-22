using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private String _direccionEntrega;
        private EEstado _estado;
        private String _trackingID;

        protected Thread _hilo;

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

        /*MockCicloDeVida hará que el paquete cambie de estado de la siguiente forma:
        a. Colocar una demora de 10 segundos.
        b. Pasar al siguiente estado.
        c. Informar el estado a través de InformarEstado. EventArgs no tendrá ningún dato extra.
        d. Repetir las acciones desde el punto A hasta que el estado sea Entregado.
        e. Finalmente guardar los datos del paquete en la base de datos.*/
        public void MockCicloDeVida()
        {
            while (this._estado != EEstado.Entregado)
            {
                Thread.Sleep(10000);
                this._estado++;
                this.InformarEstado(this, new EventArgs());
            }
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void RealizarDemora()
        {

        }

        /*MostrarDatos utilizará string.Format con el siguiente formato "{0} para {1}", p.trackingID,
        p.direccionEntrega para compilar la información del paquete.*/
        public String MostrarDatos(IMostrar<Paquete> elemento)
        {
            return String.Format("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
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
            return ((IMostrar <Paquete>) this).MostrarDatos(this);
        }

        public event DelegadoEstado InformarEstado;

        public delegate void DelegadoEstado(object sender, EventArgs e); 
        
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}


