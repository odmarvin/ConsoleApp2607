// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using ConsoleApp2607.NewFolder;


internal class Program
{
    private static void Main(string[] args)
    {
        CuentaBancaria cuentaNueva = new CuentaBancaria("jsandoval", "12345678", 300);

        cuentaNueva.Depositar(100);

        Console.WriteLine("Saldo actual: " + cuentaNueva.ObtenerSaldo("jsandoval", "12345678"));

        cuentaNueva.Retirar(100, "jsandoval", "12345678");

        Console.WriteLine("Saldo actual: " + cuentaNueva.ObtenerSaldo("jsandoval", "12345678"));

        cuentaNueva.Retirar(1000, "jsandoval", "12345678");

        Console.WriteLine("Saldo actual: " + cuentaNueva.ObtenerSaldo("jsandoval", "12345678"));
    }
}