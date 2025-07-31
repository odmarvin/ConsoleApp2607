using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio6
{
    public class Factura : DocumentoFiscal
    {
        public Factura(string numero) : base(numero) { }
        public override void GenerarPDF()
        {
            Console.WriteLine($"Factura {numero}, generada correctamente");
        }
    }
}
