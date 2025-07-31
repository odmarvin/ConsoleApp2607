using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2607.Clases
{
    public abstract class Figura
    {
        public string Color { get; set; }

        public Figura(string color)
        {
            Color = color;
        }

        public abstract double CalcularArea();

    }
}
