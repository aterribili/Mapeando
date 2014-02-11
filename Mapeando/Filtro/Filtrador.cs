using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mapeando
{
    public class Filtrador<T>
    {
        public List<T> filtra(List<T> lista, Func<T, bool> f)
        {
            List<T> novaLista = new List<T>();

            foreach (T i in lista)
                if (f.Invoke(i))
                    novaLista.Add(i);

            return novaLista;
        }
    }
}
