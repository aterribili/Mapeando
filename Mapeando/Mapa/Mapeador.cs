using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeando
{
    public class Mapeador<F, T>
    {
        public List<T> mapeia(List<F> lista, Mapper<F, T> mapper)
        {
            List<T> novaLista = new List<T>();

            foreach (F i in lista)
                novaLista.Add(mapper.map(i));

            return novaLista;
        }
    }
}
