using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        delegate int delegadoSuma(int num1, int num2);

        static int funcionSuma(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            int num1 = 3, num2 = 1;
            Moto moto1 = new Moto(125, false, "yamaha", "YZ", 1000, 2);
            Coche coche1 = new Coche(1, "Gasolina", "Citroen", "C4", 2000, 4);

            delegadoSuma fun1 = new delegadoSuma(funcionSuma);

            Console.WriteLine(fun1(num1, num2));
            Console.ReadKey();

            Console.WriteLine(moto1.escribe());
            Console.ReadKey();
            Console.WriteLine(coche1.escribe());
            Console.ReadKey();
        }
    }
}
