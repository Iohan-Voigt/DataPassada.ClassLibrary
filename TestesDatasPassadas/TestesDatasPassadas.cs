using DataPassada;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestesDatasPassadas
{
    [TestClass]
    public class TestaDatasPassadas
    {
        [TestMethod]
        public void DeveRetornarEntradaInvalidaComString()
        {
            EscritorDataPeriodoPassadas es = new EscritorDataPeriodoPassadas();

            Assert.AreEqual("Entrada inválida", es.DataParaTempopassado("a"));
        }

        [TestMethod]
        public void DeveRetornarEntradaInvalidaComDataFutura()
        {
            EscritorDataPeriodoPassadas es = new EscritorDataPeriodoPassadas();

            Assert.AreEqual("Data Maior que o dia atual", es.DataParaTempopassado("01/01/3000"));
        }

        [TestMethod]
        public void DeveRetornarhorarioSemDias()
        {
            EscritorDataPeriodoPassadas es = new EscritorDataPeriodoPassadas();
            Assert.IsNotNull("uma hora", es.DataParaTempopassado("27/05/2021 13:10:00"));
        }

        [TestMethod]
        public void DeveRetornarHorarioComDias()
        {
            EscritorDataPeriodoPassadas es = new EscritorDataPeriodoPassadas();
            Assert.IsNotNull("uma hora", es.DataParaTempopassado("26/05/2021 13:10:00"));
        }

    }
}
