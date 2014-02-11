﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapeando
{
    public class Filtrador<T>
    {
        public List<T> filtra(List<T> lista, Filter<T> filter)
        {
            List<T> novaLista = new List<T>();

            foreach (T i in lista)
                if (filter.map(i))
                    novaLista.Add(i);

            return novaLista;
        }
    }
}
