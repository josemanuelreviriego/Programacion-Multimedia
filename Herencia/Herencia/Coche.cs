using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Coche : Vehiculo
    {
        int motores;
        string tipoMotor;


        public Coche() : base()
        {
            this.motores = 0;
            this.TipoMotor = "";
        }
        public Coche(int motores, string tipoMotor, string marca, string modelo, int precio, int ruedas)
            : base(marca, modelo, precio, ruedas)
        {
            this.motores = motores;
            this.tipoMotor = tipoMotor;            
        }

        public int Motores { get => motores; set => motores = value; }
        public string TipoMotor { get => tipoMotor; set => tipoMotor = value; }

        
        public override string escribe()
        {
            return base.escribe() + " Motor: " + Motores + " TipoMotor: " + tipoMotor;
        }

        //public string escribe()
        //{
        //    return "El coche de marca " + this.Marca + " con estos motores " + this.Motores + " con este motor " + this.TipoMotor +
        //        " de este modelo " + this.Modelo + " con este precio " + this.Precio + " y este numero de ruedas " + this.Ruedas;
        //}
    }
}
