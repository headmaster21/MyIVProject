using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIVProject
{
    public static class Helpers
    {
        
        public static List<int> Pares( this List<int> l)
        {
            Predicate<int> EsPar = x => x % 2 == 0;
            return l.FindAll(EsPar);
        }

        public static List<int> Impares(this List<int> l)
        {
            Predicate<int> EsImpar = x => x % 2 != 0;
            return l.FindAll(EsImpar);


        }
    }
}
