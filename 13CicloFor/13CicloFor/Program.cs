using System;

namespace _13CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for (int contador = 1; contador <= 5; contador++)
            {
                acumulador += contador;
            }
            Console.WriteLine($"Lasuma de los cinco primeros numeros es: " + acumulador);
        }
    }
    }
}
