using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mapeando.Filtro
{
    public class FiltraUrl : Filter<String>
    {

        public bool map(string from)
        {
            return Regex.IsMatch(from, "^http(s)?://([\\w-]+.)+[\\w-]+(/[\\w- ./?%&=])?$");
        }
    }
}
