using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio6
{
    internal class GestorDocumentos
    {
        public List<DocumentoFiscal> documentos;

        public GestorDocumentos(List<DocumentoFiscal> documentos) 
        {
            this.documentos = documentos;
        }

        public void VerDocumentos()
        { 
            foreach (var doc in documentos)
            {
                doc.GenerarPDF();
            }
        }

    }
}
