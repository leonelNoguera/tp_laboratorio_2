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
            this._paquetes = new List<Paquete>();
            this._mockPaquetes = new List<Thread>();
        }

        public void FinEntregas()
        {
            foreach (Thread item in this._mockPaquetes)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }

        public String MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder retorno = new StringBuilder();

            foreach (Paquete p in ((Correo)elementos).Paquetes)
            {
                retorno.AppendLine(String.Format("{0} - {1} - ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }

            return retorno.ToString();
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
                Thread hilo = new Thread(p.MockCicloDeVida);
                c._mockPaquetes.Add(hilo);
                hilo.Start();
            }

            return resultado;
        }
    }
}
