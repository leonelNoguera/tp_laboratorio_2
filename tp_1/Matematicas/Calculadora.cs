using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematicas
{
    public class Calculadora
    {
        Numero claseNumero = new Numero();

        public Double Operar(Numero num1, Numero num2, String operador)
        {
            //validará y realizará la operación pedida entre ambos números.
            String operadorAux = ValidarOperador(operador);

            Double resultado = 0;

            if (operadorAux == "+")
            {
                Console.WriteLine("OperadorSuma retorna: " + (num1 + num2));
                resultado = (num1 + num2);
            }
            else
            {
                if (operadorAux == "-")
                {
                    resultado = (num1 - num2);
                }
                else
                {
                    if (operadorAux == "*")
                    {
                        resultado = (num1 * num2);
                    }
                    else
                    {
                        if (operadorAux == "/")
                        {
                            resultado = (num1 / num2);
                        }
                    }
                }
            }

            return resultado;
        }

        private static String ValidarOperador(String operador)
        {
            //Deberá validar que el operador recibido sea +, -, / o *. Caso contrario retornará +.

            String operadorAux = "+";

            if (operador == "+")
            {
                operadorAux = operador;
            }
            else
            {
                if (operador == "-")
                {
                    operadorAux = operador;
                }
                else
                {
                    if (operador == "*")
                    {
                        operadorAux = operador;
                    }
                    else
                    {
                        if (operador == "/")
                        {
                            operadorAux = operador;
                        }
                    }
                }
            }

            return operadorAux;
        }
        public Calculadora()
        {}
    }
}
