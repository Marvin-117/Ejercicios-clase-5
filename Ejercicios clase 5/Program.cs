using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Nombre");
            Console.WriteLine("3. Cálculo de Edad");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Nombre();
                    break;
                case 3:
                    CálculoEdad();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 4);
    }

    static void Suma()
    {
        Console.WriteLine("Ingrese valor 1: ");
        int Val1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese valor 2: ");
        int Val2 = Convert.ToInt32(Console.ReadLine());
        int Respuesta = Val1 + Val2;
        Console.WriteLine("Suma = " + Respuesta);
    }

    static void Nombre()
    {
        Console.WriteLine("¿Cuál es su nombre?");
        string nombre = Console.ReadLine();
        Console.WriteLine("Mucho gusto, " + nombre);
    }

    static void CálculoEdad()
    {
        Console.WriteLine("Ingrese año de nacimiento: ");
        int año = Convert.ToInt32(Console.ReadLine());
        int edad = 2024 - año;
        Console.WriteLine("Su edad es: " + edad);
    }
}