using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartado8
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayorEdad = 0;
            int menorEdad = 0;
            int edad;
            for (int i = 1; i <= 200; i++)
            {
                Console.WriteLine("Escribe tu edad: ");
                edad = int.Parse(Console.ReadLine());

                var x = (edad >= 18) ? mayorEdad++ : menorEdad++;
            }
            Console.WriteLine("Mayores " + mayorEdad);
            Console.WriteLine("Menores " + menorEdad);

            Console.ReadKey();

        }
    }
}
