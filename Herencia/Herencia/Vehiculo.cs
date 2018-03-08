using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Vehiculo
    {
        string marca, modelo;
        int precio;
        int ruedas;

        public Vehiculo()
        {
            this.marca = "";
            this.modelo = "";
            this.precio = 0;
            this.ruedas = 0;
        }

        public Vehiculo(string marca, string modelo, int precio, int ruedas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.ruedas = ruedas;
        }

        public virtual string escribe()
        {
            return "Marca: " + marca + " modelo: " + modelo + " precio: " + precio + " ruedas: " + ruedas;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Ruedas { get => ruedas; set => ruedas = value; }
    }
}
