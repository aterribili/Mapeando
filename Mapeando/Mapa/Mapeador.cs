using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeando
{
    public class Mapeador<F, T>
    {
        public List<T> mapeia(List<F> lista, Func<F, T> f)
        {
            List<T> novaLista = new List<T>();

            foreach (F i in lista)
                novaLista.Add(f(i));

            return novaLista;
        }
    }
}
