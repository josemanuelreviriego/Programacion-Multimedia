using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Palabras que se van a ordenar
            String[] lista =
            {
                    "pepe", "manuela", "abelardo", "ramon"
                };

            // Las ordenamos a partir del método Sort de la clase Array
            Array palabras = lista;
            Array.Sort(lista);

            // Visualizamos las palabras ordenadas
            foreach (string pal in lista)
                Console.WriteLine(pal);

            for(int i=0; i < 4; i++)
            {
                String palabra = lista[i];
                Array.Sort(lista);
                Console.WriteLine(lista[i]);
            }
            Console.ReadKey();
        }

    }
}
