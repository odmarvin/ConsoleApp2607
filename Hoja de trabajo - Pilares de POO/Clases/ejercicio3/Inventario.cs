using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio3
{
    public class Inventario
    {
        private class Producto
        {
            private string nombre;
            private int cantidad;

            public Producto(string nombre, int cantidad)
            {
                this.nombre = nombre;
                this.cantidad = cantidad;
            }

            public string ObtenerNombre()
            {
                return nombre;
            }

            public int ObtenerCantidad()
            {
                return cantidad;
            }

            public void Incrementar(int cantidadNueva)
            {
                if (cantidadNueva > 0)
                {
                    cantidad += cantidadNueva;
                }
            }

            public bool Retirar(int cantidadRetiro)
            {
                if (cantidadRetiro > 0 && cantidadRetiro <= cantidad)
                {
                    cantidad -= cantidadRetiro;
                    return true;
                }

                return false;
            }

            public string Mostrar()
            {
                return $"{nombre}: {cantidad} unidades";
            }
        }

        private List<Producto> productos;

        public Inventario()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(string nombre, int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor a cero.");
                return;
            }

            foreach (var producto in productos)
            {
                if (producto.ObtenerNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    producto.Incrementar(cantidad);
                    return;
                }
            }

            productos.Add(new Producto(nombre, cantidad));
        }

        public void RetirarProducto(string nombre, int cantidad)
        {
            foreach (var producto in productos)
            {
                if (producto.ObtenerNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    bool resultado = producto.Retirar(cantidad);

                    if (resultado)
                    {
                        Console.WriteLine($"Se retiraron {cantidad} unidades de '{nombre}'.");
                    }
                    else
                    {
                        Console.WriteLine("Cantidad insuficiente o invalida.");
                    }

                    return;
                }
            }

            Console.WriteLine("Producto no encontrado.");
        }

        public void MostrarInventario()
        {
            Console.WriteLine("\n== Inventario actual ==");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.Mostrar());
            }
        }

    }
}
