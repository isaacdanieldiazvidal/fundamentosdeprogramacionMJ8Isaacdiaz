using System;
using System.Runtime.InteropServices;

namespace _6.condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 0;
            Console.WriteLine("--------------Nemu--------------");
            Console.WriteLine("1. Opcion 1     2. Opcion 2");
            Console.WriteLine("3. Opcion 3     4. Opcion 4");
            Console.WriteLine("5. Opcion 5 ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Elija una opcion del menu:");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligiom la opcion 1");
                    break;
                case 2:
                    Console.WriteLine("Eligiom la opcion 2");
                    break;
                case 3:
                    Console.WriteLine("Eligiom la opcion 3");
                    break;
                case 4:
                    Console.WriteLine("Eligiom la opcion 4");
                    break;
                case 5:
                    Console.WriteLine("Eligiom la opcion 5");
                    break;
                default:
                    Console.WriteLine("Elija una opcion valida");
                    break;


            }



        }
    }
}
