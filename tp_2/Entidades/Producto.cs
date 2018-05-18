using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    /// <summary>
    /// La clase Producto será abstracta, evitando que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        private EMarca _marca;
        private string _codigoDeBarras;
        private ConsoleColor _colorPrimarioEmpaque;

        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo
        /// </summary>
        public virtual short CantidadCalorias
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual String Mostrar()
        {
            return (String)this;
        }
        public virtual String Mostrar(short cantidadDeCalorias) // ----- aquí me quedé -----
        {
            if (this.CantidadCalorias == cantidadDeCalorias)
            {
                return (String)this;
            }
            return "";
        }

        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            //p.CantidadCalorias

            sb.AppendLine("CODIGO DE BARRAS: " + p._codigoDeBarras + "\r\n");
            sb.AppendLine("MARCA          : " + p._marca.ToString() + "\r\n");
            sb.AppendLine("COLOR EMPAQUE  : " + p._colorPrimarioEmpaque.ToString() + "\r\n");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            if (v1._codigoDeBarras == v2._codigoDeBarras)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return (!(v1 == v2));
        }

        //public Producto(){}

        public Producto(String codigoDeBarras, EMarca marca, ConsoleColor color)
        {
            this._codigoDeBarras = codigoDeBarras;
            this._marca = marca;
            this._colorPrimarioEmpaque = color;
        }
    }
}
