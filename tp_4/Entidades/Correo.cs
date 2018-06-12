using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo
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
            Correo resultado = new Correo();



            return resultado;
        }
    }
}
