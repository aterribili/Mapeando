using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Mapeando;

namespace MapeandoTest
{
    [TestClass]
    public class FilterTest
    {
        [TestMethod]
        public void DeveFiltrarListaInteiro()
        {
            List<int> lista = new List<int>();
            lista.Add(20);

            List<int> nova = new Filtrador<int>().filtra(lista, new FiltroInteiros());

            Assert.AreEqual(20, nova[0]);
        }
    }
}
