using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camaras
{
    class Program
    {
        public static void asignar(CamaraIP p1, CamaraIP p2, CamaraWEB web1, CamaraWEB web2)
        {
            p1.Peso = 12;
            p1.DireccionIP = p2.DireccionIP;
            p2.DireccionMAC = p1.DireccionMAC;
            web2.Resolucion = web1.Resolucion;
            web1.Marca = web2.Marca;
        }
        static void Main(string[] args)
        {
            CamaraIP ip1 = new CamaraIP("Nikon", "500mm", "00:1E:67:34:3D:2F", "192.168.1.2", 1);
            CamaraIP ip2 = new CamaraIP("Sony", "100mm", "01:1F:34:25:2B:1A", "192.168.1.3", 2);
            CamaraWEB w1 = new CamaraWEB("Panasonic", "20mm", "10mpx", 3, 20);
            CamaraWEB w2 = new CamaraWEB("Samsung", "30mm", "15mpx", 2, 10);

            Console.WriteLine(ip1.Escribir());
            Console.WriteLine();
            Console.WriteLine(ip2.Escribir());
            Console.WriteLine();
            Console.WriteLine(w1.Escribir());
            Console.WriteLine();
            Console.WriteLine(w2.Escribir());
            Console.WriteLine();

            asignar(ip1, ip2, w1, w2);

            Console.WriteLine("VALORES CAMBIADOS");
            Console.WriteLine();
            Console.WriteLine(ip1.Escribir());
            Console.WriteLine();
            Console.WriteLine(ip2.Escribir());
            Console.WriteLine();
            Console.WriteLine(w1.Escribir());
            Console.WriteLine();
            Console.WriteLine(w2.Escribir());
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
