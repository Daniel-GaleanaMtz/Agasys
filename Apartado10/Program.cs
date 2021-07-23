using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartado10
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();
            Empleado empleado3 = new Empleado();
            empleado1.Nombre = "Daniel";
            empleado1.Apellido = "Mendoza";
            empleado1.SueldoDiario = 150;
            Console.WriteLine(empleado1.Nombre + " " + empleado1.Apellido + "\n" + "Sueldo Dirario: " + empleado1.SueldoDiario);
            empleado1.CalculaSueldo(empleado1.SueldoDiario);
            Console.WriteLine("\n");

            empleado2.Nombre = "Minerva";
            empleado2.Apellido = "Reyes";
            empleado2.SueldoDiario = 100;
            Console.WriteLine(empleado2.Nombre + " " + empleado2.Apellido + "\n" + "Sueldo Dirario: " + empleado2.SueldoDiario);
            empleado1.CalculaSueldo(empleado2.SueldoDiario);
            Console.WriteLine("\n");

            empleado3.Nombre = "Carolina";
            empleado3.Apellido = "Sanchez";
            empleado3.SueldoDiario = 750;
            Console.WriteLine(empleado3.Nombre + " " + empleado3.Apellido + "\n" + "Sueldo Dirario: " + empleado3.SueldoDiario);
            empleado1.CalculaSueldo(empleado3.SueldoDiario);
            Console.ReadKey();
        }
    }
}
