using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPassada
{
    class ConversorDias : Numeros
    {
        private string dataExtensa;
        public ConversorDias() { }

        public string ConverteDias(int dias) 
        {
            if (dias < 7)
                dataExtensa = $"{dias} dias";
            else if (dias < 30)
            {
                if (dias % 7 == 0)
                    dataExtensa = $"{dias / 7}semanas";
                else
                    dataExtensa = $"{dias / 7}semanas e {dias % 7} dias";
            }
            else
            {
                if (dias % 30 == 0)
                    dataExtensa = $"{dias} meses";
                else 
                {
                    if ((dias % 30) / 7 == 0)
                        dataExtensa = $"{dias/30} meses {(dias % 30) / 7} semanas";
                    else
                        dataExtensa = $"{dias / 30} meses {(dias % 30) / 7} semanas {((dias % 30)%7)} dias";
                }
            }


            return dataExtensa;
        }
    }
}
