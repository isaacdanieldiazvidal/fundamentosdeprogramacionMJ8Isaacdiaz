using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condicionales anidados = diagrama de flujo
            //b. diseñar un algoritmo que lea tres numero a, b, c, y visualice en pantalla el valor mas grande. el usuario devi ingrsar tres valores diferentes

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("debe ingrese 3 valores diferntes");
            Console.WriteLine("ingrese el valor del numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del numero 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del numero 3");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            { //verdadera
                if (num1 > num3)
                {
                    Console.WriteLine("El nimero 1 es mayor");
                }
                else
                {
                    Console.WriteLine("El nimero 3 es mayor");
                }
            }
            else 
            { //false
                if (num2 > num3)
                {
                    Console.WriteLine("El nimero 2 es mayor");
                }
                else
                {
                    Console.WriteLine("El nimero 3 es mayor");
                }
            }
        }
    }
}
