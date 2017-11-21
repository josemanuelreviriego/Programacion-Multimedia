using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camaras
{
    class CamaraIP
    {
        private string marca, objetivo, direccionMAC, direccionIP;
        private int peso;
        
        public CamaraIP()
        {
            marca = "";
            objetivo = "";
            direccionMAC = "";
            direccionIP = "";
            peso = 0;
        }
        
        public CamaraIP(string marca, string objetivo, string direccionMAC, string direccionIP, int peso)
        {
            this.marca = marca;
            this.objetivo = objetivo;
            this.direccionMAC = direccionMAC;
            this.direccionIP = direccionIP;
            this.peso = peso;
        }

        public string DireccionIP
        {
            get
            {
                return direccionIP;
            }

            set
            {
                direccionIP = value;
            }
        }

        public string DireccionMAC
        {
            get
            {
                return direccionMAC;
            }

            set
            {
                direccionMAC = value;
            }
        }

        public int Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public string Escribir()
        {
            return "Camara de marca: " + marca +
                " con el objetivo " + objetivo +
                " con esta direccionIP " + direccionIP +
                " con esta direccionMAC " + direccionMAC +
                " y este peso " + peso;
        }

        public void vaciar()
        {
            marca = "";
            objetivo = "";
            direccionIP = "";
            direccionMAC = "";
            peso = 0;
        }
    }
}
