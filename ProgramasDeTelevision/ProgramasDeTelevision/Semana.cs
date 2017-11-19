using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramasDeTelevision
{
    class Semana
    {
        private Dia[] dias; //dias de la semana

        public Semana()
        {
            dias = new Dia[5];
            dias[0] = new Dia("Lunes");
            dias[1] = new Dia("Martes");
            dias[2] = new Dia("Miercoles");
            dias[3] = new Dia("Jueves");
            dias[4] = new Dia("Viernes");
        }

        public void setPrograma(Programa p, int dia, int horario)
        {
            dias[dia].setPrograma(p, horario);
        }

        public void escribir()
        {
            for (int i = 0; i < dias.Length; i++)
                dias[i].escribir();
        }

        public void escribir(int d)
        {
            dias[d].escribir();
        }

    }
}
