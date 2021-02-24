using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7AnalisisGuia7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Double op;

            do
            {
            Console.Title = "Programa que muestra menú de calculo";
            Console.WriteLine("\n\tOPERACIONES MATEMÁTICAS:");
            Console.WriteLine("\n\t1. Seno de x");
            Console.WriteLine("\n\t2. Coseno de x");
            Console.WriteLine("\n\t3. Tangente de x");
            Console.WriteLine("\n\t4. Raíz cuadrada de x");
            Console.WriteLine("\n\t5. Potencia de Y^x");
            Console.WriteLine("\n\t6. Verificar si el número es par o impar");
            Console.WriteLine("\n\t7. Salir del programa");
            Console.WriteLine("\n ");
            Console.Write("Digite su opción: ");
            op = Double.Parse(Console.ReadLine());

            switch (op)
            {
            case 1:
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado la opción: Seno de x.");
            break;
           
            case 2:
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado la opción: Coseno de x.");
            break;
            
            case 3:
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado la opción: Tangente de x.");
            break;
           
            case 4:
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado la opción: Raíz cuadrada de x.");
            break;
           
            case 5:
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado la opción: Potencia de Y^x.");
            break;
           
            case 6:
            Console.Clear();
            Console.WriteLine("Usted ha seleccionado la opción: Verificar si el número es par o impar.");
            break;

            case 7:
            Console.Clear();
            Console.WriteLine("Saliendo del programa...");
            Environment.Exit(0);
            break;
            
            default:
            Console.Clear();
            Console.WriteLine("Opción no definida. Intente de nuevo");
            break;
            }

            } while (op >= 1 && op <= 7);
            
            {
                Console.WriteLine("Opción no definida. Intente de nuevo");
                Console.Write("Por favor digite su opción: ");
                op = Double.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
