using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio4
{
    public abstract class Vehiculo
    {
        public string marca;
        public Vehiculo(string marca) {
            this.marca = marca;
        }

        public void Encender () {
            Console.WriteLine($"{marca}: Encendido");
        }

        public abstract void Conducir();
    }
}
