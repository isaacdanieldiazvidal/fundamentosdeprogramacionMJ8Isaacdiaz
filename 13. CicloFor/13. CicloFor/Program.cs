using System;

namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            int final;

            Console.WriteLine("Ingrese el número inicial del rango:");
            inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número final del rango:");
            final = int.Parse(Console.ReadLine());

            for (int i = inicio; i <= final; i++)
            {
                if (i / 5 * 5 == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
