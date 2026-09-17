using System;


namespace _8.CiclosWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int suma = 0;

            Console.WriteLine("Ingrese un número entero positivo:");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                if (numero > 0)
                {
                    suma = suma + numero;
                }
                else
                {
                    Console.WriteLine("El número 0 no se suma.");
                }

                Console.WriteLine("Ingrese otro número positivo (un número negativo para terminar):");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El total de la suma es: " + suma);
        }
    }
}
