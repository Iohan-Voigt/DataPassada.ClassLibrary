using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPassada
{
    class ConversorHorario : Numeros
    {
        private string dataExtensa;
        public string ConverteSegundos(int segundo)
        {
            string horsStr = Convert.ToString(segundo);
            char[] horaChar = horsStr.ToCharArray();
            if (horaChar.Length == 1)
            {
                if (horaChar[0].Equals('0'))
                    return "";
                else if (horaChar[0].Equals('1'))
                    dataExtensa = $"{RetornaUnidades(horaChar[0])} segundo";
                else
                    dataExtensa = $"{RetornaUnidades(horaChar[0])} segundos";
            }
            else if (horaChar[0].Equals('1'))
            {
                dataExtensa = $"{RetornaPrimeirasDezenas(horaChar[1])} segundos";
            }
            else if (horaChar[1].Equals('0'))
                dataExtensa = $"{RetornaDezenas(horaChar[1])} segundos";
            else
                dataExtensa = $"{RetornaDezenas(horaChar[1])} e {RetornaUnidades(horaChar[1])} segundos";

            return dataExtensa;
        }

        public string ConverteMinutos(int minuto)
        {
            string horsStr = Convert.ToString(minuto);
            char[] horaChar = horsStr.ToCharArray();
            if (horaChar.Length == 1)
            {
                if (horaChar[0].Equals('0'))
                    return "";
                else if (horaChar[0].Equals('1'))
                    dataExtensa = $"{RetornaUnidades(horaChar[0])} minuto";
                else
                    dataExtensa = $"{RetornaUnidades(horaChar[0])} minutos";
            }
            else if (horaChar[0].Equals('1'))
            {
                dataExtensa = $"{RetornaPrimeirasDezenas(horaChar[1])} minutos";
            }
            else if (horaChar[1].Equals('0'))
                dataExtensa = $"{RetornaDezenas(horaChar[1])} minutos";
            else
                dataExtensa = $"{RetornaDezenas(horaChar[1])} e {RetornaUnidades(horaChar[1])} minutos";

            return dataExtensa;
        }
        public string ConverteHoras(int horas)
        {
            string horsStr = Convert.ToString(horas);
            char[] horaChar = horsStr.ToCharArray();           
            if (horaChar.Length == 1)
            {
                if (horaChar[0].Equals('0'))
                    return "";
                else if (horaChar[0].Equals('1'))
                    dataExtensa = $"{RetornaUnidades(horaChar[0])}a hora";
                else
                    dataExtensa = $"{RetornaUnidades(horaChar[0])} horas";
            }
            else if (horaChar[0].Equals('1'))
            {
                dataExtensa = $"{RetornaPrimeirasDezenas(horaChar[1])} horas";
            }
            else if (horaChar[1].Equals('0'))
                dataExtensa = $"{RetornaDezenas(horaChar[1])} horas";
            else
                dataExtensa = $"{RetornaDezenas(horaChar[1])} e {RetornaUnidades(horaChar[1])} horas";

            return dataExtensa;
        }
    }
}
