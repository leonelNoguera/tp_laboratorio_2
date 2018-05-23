using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Correo
    {
        public List<Paquete> Paquetes
        {
            get
            {
                return new List<Paquete>();
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
