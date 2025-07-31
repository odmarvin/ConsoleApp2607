using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio2
{
    public class Usuario
    {
        public string nombre;
        private string dpi;
        private string password;

        public Usuario(string nombre, string dpi, string password)
        { 
            this.nombre = nombre;
            if (dpi.Length == 13)
            {
                this.dpi = dpi;
            } else {
                Console.WriteLine("DPI invalido, Debe contener 13 Digitos");
            }
            if (password.Length >= 6) {
                this.password = password;
            } else {
                Console.WriteLine("La contraseña debe tener mas de 6 caracteres");
            }
        }

        public decimal Autenticar(string input)
        {
            if (input != password)
            {
                Console.WriteLine("No fue posible autenticar al usuario.");
                return 0;
            } else {
                Console.WriteLine("Usuario Autenticado");
                return 0;
            }
        }
        public void MostrarDPI(string input)
        {
            if (input != password)
            {
                Console.WriteLine("COntraseña invalida");
            }
            else
            {
                Console.WriteLine(dpi);
            }
        }
    }
}
