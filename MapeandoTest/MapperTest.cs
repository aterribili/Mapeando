using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using Mapeando;

namespace MapeandoTest
{
    [TestClass]
    public class MapperTest
    {
        [TestMethod]
        public void DeveMapearLista()
        {
            List<int> lista = new List<int>();
            lista.Add(23);

            List<String> novaLista = new Mapeador().mapeia(lista, new Mapa());

            Assert.AreEqual("23", novaLista[0]);
        }
    }
}
