using System;


namespace _7._2CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int factorial = 1;
            int contador = 1;

            Console.WriteLine("Ingrese un número:");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("No se puede calcular el factorial de un número negativo.");
            }
            else
            {
                while (contador <= numero)
                {
                    factorial = factorial * contador;
                    contador++;
                }

                Console.WriteLine("El factorial de " + numero + " es: " + factorial);
            }
        }
    }
}
