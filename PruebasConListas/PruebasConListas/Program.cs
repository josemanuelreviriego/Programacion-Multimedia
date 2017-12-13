using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConListas
{
    class Program
    {
        public static void imprimir(string s)
        {
            Console.WriteLine(s);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {

            List<string> nombre = new List<string>();
            nombre.Add("Maria");
            nombre.Add("Pepe");
            nombre.Remove("Maria");
            nombre.Add("Jose");
            nombre.Add("Ramon");

            nombre.ForEach(delegate (string name)
            {
                Console.WriteLine("Estos son mis nombres: " + name);
                Console.ReadKey();
            });

            nombre.ForEach(imprimir);
            
                
            
            

            
        }
    }
}
