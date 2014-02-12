using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeando2
{
    public static class FilterExtension
    {
        public static List<T> Filtra<T>(this List<T> lista, Predicate<T> deveAdicionar)
        {
            var novaLista = new List<T>();

            foreach (var i in lista)
                if (deveAdicionar(i))
                    novaLista.Add(i);

            return novaLista;
        }

        public static List<T> FilterRecursivo<T>(this List<T> lista, Predicate<T> deveAdicionar)
        {
            var novaLista = new List<T>();

            if (lista.Count == 0)
                return novaLista;

            if (deveAdicionar(lista[0]))
                novaLista.Add(lista[0]);

            lista.RemoveAt(0);

            novaLista.AddRange(FilterRecursivo<T>(lista, deveAdicionar));
            return novaLista;

        }
    }
}
