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
        public void DeveMapearListaCom3Elementos()
        {
            List<int> lista = new List<int>();
            lista.Add(23);
            lista.Add(1);
            lista.Add(1);

            Func<int, String> f = (i) => i+"";
            List<String> novaLista = new Mapeador<int, String>().mapeia(lista, f);

            Assert.AreEqual("23", novaLista[0]);
            Assert.AreEqual("1", novaLista[1]);
            Assert.AreEqual("1", novaLista[1]);
        }
    }
}
