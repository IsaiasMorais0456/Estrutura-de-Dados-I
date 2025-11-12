using System;
using System.Collections.Generic;

namespace AlgoritmoDeBusca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ListaDeNomes = { "Isaias", "Maria", "João", "Ana", "Pedro", "Marcos", "Carol", "Lucas", "Beatriz", "Rafael", "Fernanda" };
            Console.WriteLine("Busca Linear:");
            string target = Console.ReadLine() ?? string.Empty;
            string resultadoLinear = Busca.BuscaLinear(ListaDeNomes, target);
            Console.WriteLine(resultadoLinear);
        }
    }
}

