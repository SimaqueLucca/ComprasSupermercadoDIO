using System;
using System.Collections.Generic;
using System.Linq;

namespace ComprasSupermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            List<string> listasDeCompras = new List<string>();

            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                string lista = Console.ReadLine();

                var listaSemRepeticoes = lista.Split(" ").Distinct();

                List<string> listaOrdenada = listaSemRepeticoes.ToList();
                listaOrdenada.Sort();

                string listaEmString = string.Join(" ", listaOrdenada.ToArray());

                listasDeCompras.Add(listaEmString);
            }
            listasDeCompras.ForEach(Console.WriteLine);
        }

    }
}