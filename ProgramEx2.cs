using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2POOMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da aresta do quadrado:");

            Double valorAresta = Double.Parse(Console.ReadLine());



            Aresta quadrado = new Aresta(valorAresta);



            Double area = quadrado.CalcularArea();

            Console.WriteLine("A área do quadrado é: {0}", area);
        }
    }
}
