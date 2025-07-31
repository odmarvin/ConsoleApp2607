using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio6
{
    public class NotaCredito : DocumentoFiscal
    {
        public NotaCredito(string numero) : base(numero) { }
        public override void GenerarPDF()
        {
            Console.WriteLine($"Nota de Credito {numero}, generada correctamente");
        }
    }
}
