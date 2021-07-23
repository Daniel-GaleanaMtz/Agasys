using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartado9
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto;
            int c1=0, c2=0, c3=0; //candidatos 1,2,3
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Por quien es tu voto? : \n1-Candidato 1 \n2-Candidato 2 \n3-Candidato 3");
                voto = int.Parse(Console.ReadLine());
                if (voto == 1)
                {
                    c1++;
                }
                else if (voto == 2)
                {
                    c2++;
                }
                else
                {
                    c3++;
                }              
            }
            if (c1 < c2 && c1 < c3)
            {
                Console.WriteLine("El tecer lugar es el candidato 1 ");
                if (c2 > c3)
                {
                    Console.WriteLine("El segundo lugar  es el Candidato 3");
                    Console.WriteLine("El primer lugar  es el Candidato 2");
                }
                else
                {
                    Console.WriteLine("El segundo lugar  es el Candidato 2");
                    Console.WriteLine("El primer lugar  es el Candidato 3");
                }
            }
            else if (c2 < c1 && c2 < c3)
            {
                Console.WriteLine("El tercer lugar  es el Candidato 2");
                if (c1 > c3)
                {
                    Console.WriteLine("El segundo lugar  es el Candidato 3");
                    Console.WriteLine("El primer lugar  es el Candidato 1");
                }
                else
                {
                    Console.WriteLine("El segundo lugar  es el Candidato 1");
                    Console.WriteLine("El primer lugar  es el Candidato 3");
                }
            }
            else
            {
                Console.WriteLine("El ultimo lugar es el Candidato 3");
                if (c1 > c2)
                {
                    Console.WriteLine("El segundo lugar  es el Candidato 2");
                    Console.WriteLine("El primer lugar  es el Candidato 1");
                }
                else
                {
                    Console.WriteLine("El segundo lugar  es el Candidato 1");
                    Console.WriteLine("El primer lugar  es el Candidato 2");               
                }
            }

            Console.ReadKey();
        }
    }
}
