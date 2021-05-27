using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPassada
{
    public class EscritorDataPeriodoPassadas
    {
        private readonly ConversorHorario cnvHor = new ConversorHorario();
        private readonly ConversorDias cnvDia = new ConversorDias();
        private readonly Numeros num = new Numeros();
        private DateTime dataDateTime;
        private String dataPorExtenso = "";

        public EscritorDataPeriodoPassadas() { }
        public string DataParaTempopassado(object dataEntrada)
        {
            if (ValidadorEntrada(dataEntrada) == "valido")
            {
                dataDateTime = Convert.ToDateTime(Convert.ToString(dataEntrada));
                int dia     = DateTime.Now.Day - dataDateTime.Day;
                int ano     = DateTime.Now.Year - dataDateTime.Year;
                int hora    = DateTime.Now.Hour - dataDateTime.Hour;
                int minuto  = DateTime.Now.Minute - dataDateTime.Minute;
                int segundo = DateTime.Now.Second - dataDateTime.Second;
                if (dia < 1)
                {
                    dataPorExtenso += $"{cnvHor.ConverteHoras(hora)} ";
                    dataPorExtenso += $"{cnvHor.ConverteMinutos(minuto)} ";
                    dataPorExtenso += $" e {cnvHor.ConverteSegundos(segundo)}";
                }
                else if (ano == 0)
                {
                    dataPorExtenso = cnvDia.ConverteDias(dia);
                }
                else
                    dataPorExtenso = $"{num.RetornaUnidadesAno(ano)} anos";



            }
            else
                dataPorExtenso = (ValidadorEntrada(dataEntrada));
            return dataPorExtenso;
        }


        #region Métodos Privados
        private string ValidadorEntrada(object entrada)
        {
            DateTime valida;
            string resultado = "";
            if (DateTime.TryParse((String)entrada, out valida))
                resultado = "valido";
            else
                return "Entrada inválida";
            if (Convert.ToDateTime(Convert.ToString(entrada)) > DateTime.Now)
                resultado = "Data Maior que o dia atual";
            return resultado;
        }

        #endregion
    }
}
