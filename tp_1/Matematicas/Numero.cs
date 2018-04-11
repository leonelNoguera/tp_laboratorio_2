using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematicas
{
    public class Numero
    {
        private Double numero;

        public Double SetNumero
        {
            set
            {
                String strNumero = "" + value;

                numero = ValidarNumero(strNumero);

                Console.WriteLine("ValidarNumero retorna: " + ValidarNumero(strNumero));
            }
            
        }
        public Double GetNumero
        {
            get
            {
                return numero;
            }

        }

        public String BinarioDecimal(String binario)
        {
            //convertirá un número binario a decimal, en caso de ser posible. Caso contrario retornará "Valor inválido".
            String resultado = "";

            int baseDiez = 0;

            String bitString = "";
            int bit;
            String posString;
            int pos;

            for (int i = 0; i < binario.Length; i++)
            {
                bitString = Convert.ToString(binario[i]);

                int.TryParse(bitString, out bit);

                posString = Convert.ToString(Math.Pow(2, (binario.Length - (i + 1))));

                int.TryParse(posString, out pos);
                
                baseDiez += (bit) * pos;

            }

            resultado = Convert.ToString(baseDiez);

            return resultado;
        }

        public String DecimalBinario(Double numero)
        {
            //convertirá un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido".
            String resultado;

            String numeroString = "" + numero;

            int numeroEnInt;

            if (int.TryParse(numeroString, out numeroEnInt) == true)
            {
                resultado = Convert.ToString(numeroEnInt, 2);
            }
            else
            {
                resultado = "Valor inválido";
            }

            return resultado;
        }

        public String DecimalBinario(String numero)
        {
            //convertirá un número decimal a binario, en caso de ser posible. Caso contrario retornará "Valor inválido".
            String resultado = "";
            long numeroEnLong;

            if (long.TryParse(numero, out numeroEnLong) == true)
            {
                resultado = Convert.ToString(numeroEnLong, 2);
            }
            else
            {
                resultado = "Valor inválido";
            }

            return resultado;
        }

        public Numero()
        {
            //
        }

        public Numero(Double numero)
        {
            this.SetNumero = numero;

            //this.numero = numero;

            Console.WriteLine("El numero luego del SetNumero es: " + this.GetNumero);
        }

        public Numero(String strNumero)
        {
            //
        }

        public static Double operator +(Numero n1, Numero n2)
        {
            Double resultado = n1.GetNumero + n2.GetNumero;

            return resultado;
        }

        public static Double operator -(Numero n1, Numero n2)
        {
            Double resultado = n1.GetNumero - n2.GetNumero;

            return resultado;
        }

        public static Double operator *(Numero n1, Numero n2)
        {
            Double resultado = n1.GetNumero * n2.GetNumero;

            return resultado;
        }

        public static Double operator /(Numero n1, Numero n2)
        {
            Double resultado = n1.GetNumero / n2.GetNumero;

            return resultado;
        }

        public Double ValidarNumero(String strNumero)
        {
            //comprobará que el valor recibido sea numérico, y lo retornará en formato double. Caso contrario, retornará 0.
            Double numero = 0;

            double.TryParse(strNumero, out numero);

            return numero;
        }
    }
}
