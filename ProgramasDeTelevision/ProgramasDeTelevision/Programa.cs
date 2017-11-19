using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasDeTelevision
{
    class Programa
    {
        private string nombre;
        private string tipo;
        private int duracion;


        public Programa()
        {
            nombre = "";
            tipo = "";
            duracion = 0;
        }
        public Programa(string nombre, string tipo, int duracion)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.duracion = duracion;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getTipo()
        {
            return tipo;
        }

        public void setTipo(string t)
        {
            tipo = t;
        }

        public int getDuracion()
        {
            return duracion;
        }

        public void setDuracion(int d)
        {
            duracion = d;
        }


      public void aumentarMinutos(int minutos)
        {
            duracion += minutos;
        }

        public void disminuirMinutos(int minutos)
        {
            duracion -= minutos;
        }


        public string escribir()
        {
            return "el nombre de tu programa es " + nombre +
                "del tipo " + tipo +
                "y con una duracion de " + duracion;
           /* Console.WriteLine("el nombre de tu programa: " + nombre);
            Console.WriteLine("el tipo de tu programa: " + tipo);
            Console.WriteLine("la duracion de tu programa: " + duracion);*/
        }


    }
}
