using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasDeTelevision
{
    class Dia
    {
        private Programa[] programas; //tabla con 5 programas asignados a esos dias 
        private string nombreDia; //lunes martes miercoles etc
                                  //private string[] horario;

        /* public void iniciarHorario()
         {
             horario[0] = "Primera Hora";
             horario[1] = "Matinal";
             horario[2] = "Medio dia";
             horario[3] = "Tarde";
             horario[4] = "Noche";
         }*/
        /* public Dia(Programa[] programas, string nombreDia, string[] horario)
         {
             this.programas = programas;
             this.nombreDia = nombreDia;
             this.horario = horario;
         }*/
        public Dia()
        {
            nombreDia = "";
            programas = new Programa[5];
            for (int i = 0; i < programas.Length; i++)
                programas[i] = new Programa();
        }
        public Dia(string n)
        {
            nombreDia = n;
            programas = new Programa[5];
            for (int i = 0; i < programas.Length; i++)
                programas[i] = new Programa;
        }

        public void Asignar(string h)
        {
            Console.WriteLine("A que horario lo quieres asignar");
             
            Programa p = new Programa("","", 0);

            string nombre, tipo;
            int duracion;
             

            //Console.WriteLine("Indica en que horario quieres meter tu programa 0:Primera hora 1:Matinal 2:Medio dia 3:Tarde 4:Noche");
            Console.WriteLine("Dime el nombre del programa");
            nombre = Console.ReadLine();
            Console.WriteLine("Dime el tipo de programa");
            tipo = Console.ReadLine();
            Console.WriteLine("Dime la duracion del programa");
            duracion = Int32.Parse(Console.ReadLine());

            p.setNombre(nombre);
            p.setTipo(tipo);
            p.setDuracion(duracion);    
        }

        public void setPrograma(Programa p, int horario)
        {
            programas[horario] = p;
        }

        public void escribir()
        {
            Console.WriteLine(nombreDia);
            for (int i = 0; i < programas.Length; i++)
                Console.WriteLine(programas[i].escribir());
        }
    }

    }
}
