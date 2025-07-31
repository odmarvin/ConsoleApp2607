using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2607.NewFolder
{
    public class CuentaBancaria
    {
        private decimal saldo;
        private string nombreUsuario;
        private string password;
        private List<string> movimientos;

        public CuentaBancaria(string usuario, string password, decimal saldoInicial = 0)
        {
            this.nombreUsuario = usuario;
            this.password = password;
            this.saldo = saldoInicial;
            this.movimientos = new List<string>();
        }

        public void Depositar(decimal montoDeposito)
        {

            if (montoDeposito > 0)
            {
                saldo += montoDeposito;
                Console.WriteLine("Deposito realizado con éxito.");
            }

        }

        public decimal Retirar(decimal montoRetiro, string usuario, string password)
        {
            if (usuario != this.nombreUsuario || password != this.password)
            {
                Console.WriteLine("No fue posible autenticar al usuario.");
                return 0;
            }

            if (this.saldo <= 0 || montoRetiro > saldo)
            {
                Console.WriteLine("El saldo de la cuenta no es suficiente para realizar la operación.");
                return 0;
            }

            saldo -= montoRetiro;
            return saldo;


        }

        public decimal ObtenerSaldo(string usuario, string password)
        {

            if (usuario != this.nombreUsuario || password != this.password)
            {
                Console.WriteLine("No fue posible autenticar al usuario.");
                return 0;
            }

            return saldo;
        }


    }
}

