using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> _mockPaquetes;
        private List<Paquete> _paquetes;
        //public List<Paquete> _paquetes;

        public List<Paquete> Paquetes
        {
            get
            {
                return this._paquetes;
            }
            set
            {
                this._paquetes = value;
            }
        }

        public Correo()
        {

        }

        public void FinEntregas()
        {

        }

        /*public String MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            return "";
        }*/

        public String MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            return "";
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            Correo resultado = c;

            Boolean estaElPaquete = false;

            foreach (Paquete item in c.Paquetes)
            {
                if (item == p)
                {
                    estaElPaquete = true;
                    throw new TrackingIdRepetidoException("El paquete ya está en el correo.");
                }
            }

            if(!estaElPaquete)
            {
                c.Paquetes.Add(p);
            }

            return resultado;
        }
    }
}
