using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeando
{
    public class Mapeador
    {
        public List<String> mapeia(List<int> lista, Mapper<int, String> mapper)
        {
            List<String> novaLista = new List<String>();

            foreach (int i in lista)
                novaLista.Add(mapper.map(i));

            return novaLista;
        }
    }
}
