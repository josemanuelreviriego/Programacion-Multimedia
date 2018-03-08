using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Moto : Vehiculo
    {
        int cilindrada;
        bool abs;

        public Moto(int cilindrada, bool abs, string marca, string modelo, int precio, int ruedas) 
            : base (marca, modelo, precio, ruedas)
        {
            this.cilindrada = cilindrada;
            this.abs = abs;
        }

        public Moto() : base()
        {
            this.cilindrada = 0;
            this.abs = false;
        }

        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        public bool Abs { get => abs; set => abs = value; }

        public override string escribe()
        {
            return base.escribe() + " Cilindrada: " + cilindrada + " Abs: " + abs;
        }
        
        //public string escribe()
        //{
        //    return "La moto de marca " + this.Marca + " ¿tiene abs? " + this.Abs + " con esta cilindrada " + this.cilindrada +
        //        " de este modelo " + this.Modelo + " con este precio " + this.Precio + " y este numero de ruedas " + this.Ruedas;
        //}
    }
}
