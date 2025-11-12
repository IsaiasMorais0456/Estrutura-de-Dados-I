using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlgoritmoDeBusca
{
    public static class Busca
    {
        public static string BuscaLinear<T>(T[] array, T target)
        {
            var comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < array.Length; i++)
            {
                if (comparer.Equals(array[i], target))
                {
                    return $"Elemento {target} encontrado na posição {i}.";
                }
            }

            return $"Elemento {target} não encontrado no array.";
        }
    }
}