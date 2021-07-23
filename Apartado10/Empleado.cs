using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartado10
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int SueldoDiario { get; set; }


        public void CalculaSueldo(int a)
        {
            Console.WriteLine("Ingresa los dias Trabajados");
            int diasTrabajados = int.Parse(Console.ReadLine());
            int Sueldo = diasTrabajados * a;
            Console.WriteLine("Su sueldo es de: " + Sueldo);
        }
    }
}
