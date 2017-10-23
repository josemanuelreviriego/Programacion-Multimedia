using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoBurbuja
{
    class Program
    {
        static public void OrdenarTabla()
        {
            string[] lista = { "Pepe", "Ana", "Juan" };

            for(int i=0;i<lista.Length-1;i++)
            {
                for(int j=0; j<(lista.Length-1)-i;j++)
                {
                    if (lista[j].CompareTo(lista[j+1]) > 0)
                    {
                        string aux;
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                    }
                }
            }

            foreach(string nombre in lista)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            OrdenarTabla();
            

        }
    }
}
