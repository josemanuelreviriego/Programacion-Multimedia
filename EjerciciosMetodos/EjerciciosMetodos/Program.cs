using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMetodos
{
    class Program
    {

        public static int elegirOpcion()
        {
            int numero;
            Console.WriteLine("Opciones");
            Console.WriteLine("1. Truncar un numero real");
            Console.WriteLine("2. Almacenar en el segundo numero el primero ya truncado");
            Console.WriteLine("3. Almacenar un numero real truncado");
            Console.WriteLine("4. Devuelve un numero real con los decimales que quieras");
            Console.WriteLine("5. Devuelve un numero real con los decimales que quieras (tres parametros)");
            Console.WriteLine("6. Almacenamos un numero real con los decimales que quieras");
            Console.WriteLine("7. Salir");
            Console.WriteLine("Introduce opción: ");
            numero = Convert.ToInt32(Console.ReadLine());
            return numero;
        }
        // 1. un numero real truncado
        public static int truncar(double numero1)
        {
            //Tambien podriamos usar el metodo Math.truncate 
            return (int)numero1;
        }

        // 2. Almacena sobre el segundo numero el numero1 ya truncado
        public static void truncar2(double numero1 ,ref int numero2)
        {
            numero2 = truncar(numero1);
        }

        // 3. un numero real truncado y almacenado
        public static void truncarGuardar(ref double numero1)
        {
           numero1 = Math.Truncate(numero1);
        }

        // 4. Truncamos a los decimales que nos diga el usuario
        public static void truncarPorNumero(double numero1, int numero2)
        {
            Console.WriteLine("Introduce el numero de decimales que quieras");
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero1 = Math.Round(numero1, numero2);
            Console.WriteLine("Este es tu numero " + numero1 + "\n");
        }

        // 5. Tres parametros, Almacenas en el tercer parametro los datos truncados del primero con los decimales seleccionados por el segundo
        public static void TruncarPorNumero2(double numero1, int numero2, ref double numero3)
        {
            Console.WriteLine("Introduce el numero de decimales que quieras");
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero3 = Math.Round(numero1, numero2);
            Console.WriteLine("Este es tu numero " + numero3 + "\n");
        }

        // 6. Almacenamos en el primer parametro el numero tras truncarlo a los decimales que quiera el usuario
        public static void truncarPorNumero3(ref double numero1, int numero2)
        {
            Console.WriteLine("Introduce el numero de decimales que quieras");
            numero2 = Convert.ToInt32(Console.ReadLine());
            numero1 = Math.Round(numero1, numero2);
            Console.WriteLine("Este es tu numero " + numero1 + "\n");
        }



        static void Main(string[] args)
        {
            int opcion;
            double numero1 = 764.783478569;
            double numero3 = 0;
            int numero2 = 0; // Aqui se van a guardar los datos

            do
            {
                opcion = elegirOpcion();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Este es tu numero\n" + truncar(numero1));
                        break;
                    case 2:
                        truncar2(numero1, ref numero2);
                        Console.WriteLine("Este es tu numero\n" + numero2);                 
                        break;
                    case 3:
                        truncarGuardar(ref numero1);
                        Console.WriteLine("Este es tu numero\n" + numero1);
                        break;
                    case 4:
                        truncarPorNumero(numero1, numero2);
                        break;
                    case 5:
                        TruncarPorNumero2(numero1, numero2, ref numero3);
                        break;
                    case 6:
                        truncarPorNumero3(ref numero1, numero2);
                        break;
                }
            } while (opcion != 7);
        }
    }
}
