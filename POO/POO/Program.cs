using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {

        //Metodo que determine si la fecha es de un año bisiesto


        //Aumentar el numero del mes en 1 y si pasa de 12 volver a 1 y aumentar el año
        //Un año es bisiesto si es múltiplo de 4 (por ejemplo 1984). Los años múltiplos de 100 no son bisiestos, salvo si ellos son también múltiplos de 400 (2000 es bisiesto, pero;  1800 no lo es).

        /* if (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))
         {
             Console.WriteLine("El año " + a + " Si es bisiesto ");
         }
         else
         {
             Console.WriteLine("El año " + a + " No es bisiesto ");
         }
         Console.ReadLine();
     }*/


        static void Main(string[] args)
        {
            Fecha f1 = new Fecha(14, 5, 1996);
            Fecha f2 = new Fecha(12, 2, 2017);
            Fecha f3 = new Fecha(10, 12, 2002);
            int opcion = 0;

            do
            {
                Console.WriteLine("1.- Fecha se corresponde a un año bisiesto. \n" +
                                                 "2.- Aumentar en el mes en 1 y cambar de año si es 12 + 1. \n" +
                                                 "3.- Imprime 3 fechas.\n" +
                                                 "4.- Salir");

                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (f1.bisiesto() == true)
                        {
                            f1.imprimirFechas();
                            Console.WriteLine("Es bisiesto");
                        }
                        else
                        {
                            f1.imprimirFechas();
                            Console.WriteLine("No es bisiesto");
                        }

                        if (f2.bisiesto() == true)
                        {
                            f2.imprimirFechas();
                            Console.WriteLine("Es bisiesto");
                        }
                        else
                        {
                            f2.imprimirFechas();
                            Console.WriteLine("No es bisiesto");
                        }

                        if (f3.bisiesto() == true)
                        {
                            f3.imprimirFechas();
                            Console.WriteLine("Es bisiesto");
                        }
                        else
                        {
                            f3.imprimirFechas();
                            Console.WriteLine("No es bisiesto");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        f1.imprimirFechas();
                        f2.imprimirFechas();
                        f3.imprimirFechas();
                        f1.anadirMes();
                        f2.anadirMes();
                        f3.anadirMes();
                        f1.imprimirFechas();
                        f2.imprimirFechas();
                        f3.imprimirFechas();
                        Console.ReadKey();
                        break;

                    case 3:
                        f1.imprimirFechas();
                        f2.imprimirFechas();
                        f3.imprimirFechas();
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 4);
        }
    }
}
