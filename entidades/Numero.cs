using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Numero
    {
        private double numero;

        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero):this()
        {
            this.numero = numero;
        }

        public Numero(string strNumero):this()
        {
            this.SetNumero = strNumero;
        }

        private double ValidarNumero(string strNumero)
        {
            double retorno, aux;
            if (double.TryParse(strNumero, out aux))
            {
                retorno = aux;
            }
            else
            {
                retorno = 0;
            }
            return retorno;
        }

        public static string BinarioDecimal(string binario)
        {
            int j = 0;
            string retorno = "1";
            double aux, resultado = 0;
            
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    retorno = "-1";
                    break;
                }
            }



            if (retorno == "1")
            {
                retorno = "";
                for (int i = binario.Length; i > 0; i--)
                {
                    if (binario[i - 1] == '1')
                    {
                        aux = Math.Pow(2, j);
                        resultado += aux;
                    }
                    j++;
                }
                retorno = Convert.ToString(resultado);
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;
        }


        public static string DecimalBinario(double numero)
        {
            int resto, resultado, auxiliar;
            string binario = "", auxBinario, retorno = "", strAux;

            strAux = Convert.ToString(numero);

            if (int.TryParse(strAux, out auxiliar))
            {
                do
                {
                    resultado = auxiliar / 2;
                    resto = auxiliar % 2;
                    auxiliar = resultado;

                    auxBinario = Convert.ToString(resto);
                    binario += auxBinario;
                } while (resultado != 1);

                auxBinario = Convert.ToString(resultado);
                binario += auxBinario;

                for (int i = binario.Length; i > 0; i--)
                {
                    retorno += binario[i - 1];
                }
            }
            else
            {
                retorno = "Valor invalido";
            }
            return retorno;
        }


        public static string DecimalBinario(string numero)
        {
            double aux;
            string binario = "";
            if (double.TryParse(numero, out aux))
            {
                binario = DecimalBinario(aux);
            }
            return binario;
        }

        private bool EsBinario(string binario)
        {
            bool retorno = true;
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != 0 && binario[i] != 1)
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            double retorno = num1.numero - num2.numero;
            return retorno;
        }


        public static double operator +(Numero num1, Numero num2)
        {
            double retorno = num1.numero + num2.numero;
            return retorno;
        }

        public static double operator *(Numero num1, Numero num2)
        {
            double retorno = num1.numero * num2.numero;
            return retorno;
        }

        
        public static double operator /(Numero num1, Numero num2)
        {
            double retorno = num1.numero / num2.numero;
            return retorno;
        }
    }
}

