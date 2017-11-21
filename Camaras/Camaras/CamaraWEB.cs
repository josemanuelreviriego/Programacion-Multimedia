using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camaras
{
    class CamaraWEB
    {
        private string marca, objetivo, resolucion;
        private int peso, zoom;

        public CamaraWEB()
        {
            marca = "";
            objetivo = "";
            resolucion = "";
            peso = 0;
            zoom = 0;
        }

        public CamaraWEB(string marca, string objetivo, string resolucion, int peso, int zoom)
        {
            this.marca = marca;
            this.objetivo = objetivo;
            this.resolucion = resolucion;
            this.peso = peso;
            this.zoom = zoom;
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Resolucion
        {
            get
            {
                return resolucion;
            }

            set
            {
                resolucion = value;
            }
        }

        public string Escribir()
        {
            return "Camara de marca: " + marca +
                " con el objetivo " + objetivo +
                " con esta resolucion " + resolucion +
                " con este peso " + peso +
                " y este zoom " + zoom;
        }

        public void vaciar()
        {
            marca = "";
            objetivo = "";
            resolucion = "";
            peso = 0;
            zoom = 0;
        }
    }
}
