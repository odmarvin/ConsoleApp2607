using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2607.Clases
{
    public class Circulo : Figura
    {
        public double radio { get; set; }

        public Circulo(string color, double radio) : base(color)
        {
            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }
}
