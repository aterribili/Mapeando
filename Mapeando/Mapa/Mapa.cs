using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeando
{
    public class Mapa : Mapper<int, String>
    {
        public String map(int from)
        {
            return from.ToString();
        }
    }
}
