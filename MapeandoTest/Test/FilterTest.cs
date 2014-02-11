using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Mapeando;
using Mapeando.Filtro;
using System.Text.RegularExpressions;

namespace MapeandoTest
{
    [TestClass]
    public class FilterTest
    {
        [TestMethod]
        public void DeveFiltrarListaInteiro()
        {
            List<int> lista = new List<int>();
            lista.Add(19);
            lista.Add(20);
            
            Func<int, bool> f = (i) => i % 2 == 0;

            List<int> nova = new Filtrador<int>().filtra(lista, f);

            Assert.AreEqual(20, nova[0]);
        }

        [TestMethod]
        public void DeveFiltrarUrl()
        {
            List<String> lista = new List<string>();
            lista.Add("tt");
            lista.Add("http://www.teste.com");
            lista.Add("c");
            lista.Add("http://www.google.com");

            Func<String, bool> f = (s) => Regex.IsMatch(s, "^http(s)?://([\\w-]+.)+[\\w-]+(/[\\w- ./?%&=])?$");
            List<String> nova = new Filtrador<String>().filtra(lista, f);

            Assert.AreEqual("http://www.teste.com", nova[0]);
            Assert.AreEqual("http://www.google.com", nova[1]);
        }
    }
}
