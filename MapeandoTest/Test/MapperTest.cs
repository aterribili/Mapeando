using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;
using Mapeando;
using System.Linq;
using Mapeando2;

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

            Func<int, String> f = (i) => i.ToString();

            List<String> novaLista = lista.Mapeia(f);

            Assert.AreEqual("23", novaLista[0]);
            Assert.AreEqual("1", novaLista[1]);
            Assert.AreEqual("1", novaLista[2]);
        }
    }
}
