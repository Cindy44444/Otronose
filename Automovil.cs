using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otronose
{
    internal class Automovil
    {
        public Automovil() { }
        public Automovil(string marca, string modelo, int año, int nOpuertas, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            NOpuertas = nOpuertas;
            Color = color;
        }


        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int NOpuertas { get; set; }
        public string Color { get; set; }

    }
}
