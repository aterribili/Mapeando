using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeando2
{
    public static class MapperExtension
    {
        public static List<T> Mapeia<F, T>(this List<F> lista, Func<F, T> converte)
        {
            var novaLista = new List<T>();

            foreach (var i in lista)
                novaLista.Add(converte(i));

            return novaLista;
        }

        public static List<T> MapRecursivo<F, T>(this List<F> lista, Func<F, T> converte)
        {
            var novaLista = new List<T>();

            // Guard
            if (lista.Count == 0)
                return novaLista;

            novaLista.Add(converte(lista[0]));
            lista.RemoveAt(0);
            novaLista.AddRange(MapRecursivo<F, T>(lista, converte));

            return novaLista;
        }
    }
}
