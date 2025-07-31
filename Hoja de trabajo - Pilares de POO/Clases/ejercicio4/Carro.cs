using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio4
{
    public class Carro : Vehiculo
    {
        public Carro(string marca) : base(marca) { }
        public override void Conducir()
        {
            Console.WriteLine($"El carro marca {marca} va por la carretera");
        }
    }
}
