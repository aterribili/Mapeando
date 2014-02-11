using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeando
{
    public class FiltroInteiros : Filter<int>
    {
        public bool map(int from)
        {
            return from % 2 == 0;
        }
    }
}
