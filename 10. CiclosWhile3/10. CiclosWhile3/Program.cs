using System;

namespace _10.CiclosWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int numeroSecreto = aleatorio.Next(1, 101);
            int intento = 0;

            while (intento != numeroSecreto)
            {
                Console.WriteLine("Adivina el número entre 1 y 100:");
                intento = int.Parse(Console.ReadLine());

                if (intento > numeroSecreto)
                {
                    Console.WriteLine("El número es demasiado alto.");
                }
                else
                {
                    if (intento < numeroSecreto)
                    {
                        Console.WriteLine("El número es demasiado bajo.");
                    }
                    else
                    {
                        Console.WriteLine("¡Correcto! Adivinaste el número.");
                    }
                }
            }
        }
    }
}
