using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeando
{
    public interface Filter<T>
    {
        bool map(T from);
    }
}
