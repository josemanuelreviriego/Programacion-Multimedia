using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Fecha
    {
        private int dia, mes, anio;
        public Fecha()
        {
            dia = 1;
            mes = 1;
            anio = 1970;
        }

        public Fecha(int d, int m, int a)
        {
            dia = d;
            mes = m;
            anio = a;
        }

        public int getDia()
        {
            return this.dia;
        }
        public void setDia(int dia)
        {
            this.dia = dia;
        }
        public int getMes()
        {
            return this.mes;
        }
        public void setMes(int mes)
        {
            this.mes = mes;
        }

        public int getAnio()
        {
            return this.anio;
        }
        public void setAnio(int anio)
        {
            this.anio = anio;
        }

        public void anadirMes()
        {
            if (mes < 12)
            {
                mes++;
            }
            else if (mes == 12)
            {
                mes = 1;
                anio++;
            }
        }
        public Boolean bisiesto()
        {
            if (this.anio % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            public void imprimirFechas()
        {
            Console.Write(this.dia + "-");
            Console.Write(this.mes + "-");
            Console.Write(this.anio);
            Console.Write("\n");
        }





        //Devuelve el numero de dias desde el 1 de enero del año en curso

        //Crear 3 fechas y leer los valores por pantalla y que escriba la mayor de todas 
    }
    }

