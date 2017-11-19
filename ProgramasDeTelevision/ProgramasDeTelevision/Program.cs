using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasDeTelevision
{
    class Program
    {
        static public int menu()
        {
            Console.WriteLine("1.Asignar un programa a un dia y horario");
            Console.WriteLine("2.Eliminar un programa de un dia y un horario");
            Console.WriteLine("3.Modificar la duracion en minutos de un programa");
            Console.WriteLine("4.Mostrar la programacion semanal");
            Console.WriteLine("5.Mostrar programacion diaria");
            Console.WriteLine("6.Mostrar contenido del dia");
            Console.WriteLine("7. Salir");

            return Int32.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Semana nuevaSemana = new Semana();
            Programa nuevoPrograma;

            int opcion, duracion, dia, horario;
            string nombrePrograma, contenidoPrograma;

            do
            {
                opcion = menu();
                switch (opcion)
                {
                    case 1;
                        Console.WriteLine("Introduce nombre programa: ");
                        nombrePrograma = Console.ReadLine();
                        Console.WriteLine("Introduce contenido programa: ");
                        contenidoPrograma = Console.ReadLine();
                        Console.WriteLine("Introduce duracion programa: ");
                        duracion = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce numero dia: ");
                        dia = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce horario: ");
                        horario = Int32.Parse(Console.ReadLine());
                        nuevoPrograma = new Programa(nombrePrograma, contenidoPrograma, duracion);
                        nuevaSemana.setPrograma(nuevoPrograma, dia, horario);
                        break;
                    case 2:
                        break;
                    case 3:

                    case 4:
                        nuevaSemana.escribir();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Introduce numero dia: ");
                        dia = Int32.Parse(Console.ReadLine());
                        nuevaSemana.escribir(dia);
                        Console.ReadKey();
                        break;

                }while (opcion != 7) ;

            }
        }
    }
}
