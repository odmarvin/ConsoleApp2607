using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio6
{
    public abstract class DocumentoFiscal
    {
        public string numero;
        public DocumentoFiscal(string numero) {
            this.numero = numero;
        }

        public abstract void GenerarPDF();
    }
}
