// See https://aka.ms/new-console-template for more information
using Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio1;
using Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio2;
using Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio3;
using Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio4;
using Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio5;
using Hoja_de_trabajo___Pilares_de_POO.Clases.ejercicio6;

class Program
{
    static void Main()
    {
        // ejercicio 2

        Console.WriteLine("\n ---- Ejercicio 2 ----");
        Usuario user = new Usuario("Marvin", "1234567890123", "clave123");

        decimal autenticado = user.Autenticar("clave123");

        user.MostrarDPI("clave123");

        // ejercicio 4

        Console.WriteLine("\n ---- Ejercicio 4 ----");
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        vehiculos.Add(new Carro("Toyota"));
        vehiculos.Add(new Motocicleta("Yamaha"));
        vehiculos.Add(new Carro("Ford"));
        vehiculos.Add(new Motocicleta("Honda"));

        foreach (Vehiculo v in vehiculos)
        {
            v.Encender();
            v.Conducir();
            Console.WriteLine();
        }

        // ejercicio 6

        Console.WriteLine("\n ---- Ejercicio 6 ----");
        List<DocumentoFiscal> lista = new List<DocumentoFiscal>()
        {
            new Factura("F001"),
            new NotaCredito("NC001"),
            new NotaDebito("ND001")
        };

        GestorDocumentos gestor = new GestorDocumentos(lista);
        gestor.VerDocumentos();

        Biblioteca biblio = new Biblioteca();
        ///// Ejercicio1

        // 1. Registrar libros
        Console.WriteLine("\n ---- Ejercicio 1 ----");
        Console.WriteLine("\n ----- Registrar libros ----");
        biblio.RegistrarLibro("Alas de sangre", "Rebecca Yarros");
        biblio.RegistrarLibro("La biblioteca de los sueños", "Mariana Enríquez");
        biblio.RegistrarLibro("Memorias del futuro cercano", "Elena Poniatowska");
        biblio.RegistrarLibro("Alas de sangre", "Otro autor");

        // 2. Mostrar libros disponibles
        Console.WriteLine("\n ---- Libros disponibles al inicio ----");
        biblio.MostrarDisponibles();

        // 3. Prestar un libro disponible
        Console.WriteLine("\n ---- Prestar un libro disponible ----");
        biblio.PrestarLibro("Alas de sangre", "Sofía Martínez");

        // 4. Intentar prestar el mismo libro otra vez
        Console.WriteLine("\n ---- Intentar prestar el mismo libro otra vez ----");
        biblio.PrestarLibro("Alas de sangre", "Mateo Díaz");

        // 5. Prestar otro libro diferente
        Console.WriteLine("\n ---- Prestar otro libro disponible ----");
        biblio.PrestarLibro("La biblioteca de los sueños", "Luis Gómez");

        // 6. Intentar prestar un libro que no existe
        Console.WriteLine("\n ---- Intentar prestar libro que no existe ----");
        biblio.PrestarLibro("Código secreto del alma", "Pedro");

        // 7. Mostrar los libros disponibles después de algunos préstamos
        Console.WriteLine("\n ---- Libros disponibles después de préstamos ----");
        biblio.MostrarDisponibles();

        Console.WriteLine("\n ----------------------------------------------------------");

        ///// Ejercicio 2
        Console.WriteLine("\n ---- Ejercicio 3 ----");
        Inventario inventario = new Inventario();

        Console.WriteLine("\n ----- Agregar productos ----");
        inventario.AgregarProducto("Laptops", 10);
        inventario.AgregarProducto("Teclados", 5);
        inventario.AgregarProducto("Laptops", 3);

        Console.WriteLine("\n ---- Mostrar inventario ----");
        inventario.MostrarInventario();

        Console.WriteLine("\n ---- Retirar productos ----");
        inventario.RetirarProducto("Laptops", 8);
        inventario.RetirarProducto("Teclados", 10);
        inventario.RetirarProducto("Mouse", 1);

        Console.WriteLine("\n ---- Inventario final ----");
        inventario.MostrarInventario();

        Console.WriteLine("\n ----------------------------------------------------------");

        ///// Ejercicio 3
        Console.WriteLine("\n ---- Ejercicio 5 ----");

        Escuela escuela = new Escuela();

        // Agregar estudiantes y maestros
        escuela.AgregarPersona(new Estudiante("Luis Gomez", "Ingenieria en Sistemas"));
        escuela.AgregarPersona(new Maestro("Culajay", "Matematicas"));
        escuela.AgregarPersona(new Estudiante("Karla Estrada", "Fisica"));
        escuela.AgregarPersona(new Maestro("Carlos Perez", "Historia"));

        // Mostrar perfiles
        escuela.MostrarPerfiles();

    }
}

