using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
     public static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            string op = Validar(operador);
            double resultado = 0;
            switch (op)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }
            return resultado;
        }

        private static string Validar(string operador)
        {
            string retorno;
            if (operador == "/" || operador == "*" || operador == "-")
            {
                retorno = operador;
            }
            else
            {
                retorno = "+";
            }
            return retorno;
        }
    }
}
