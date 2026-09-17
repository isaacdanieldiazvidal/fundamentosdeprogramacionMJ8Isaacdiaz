using System;

namespace _15.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el número {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elementos del arreglo:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Posición {i}: {numeros[i]}");
            }

            int mayor = numeros[0];
            int menor = numeros[0];

            int posicionMayor = 0;
            int posicionMenor = 0;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    posicionMayor = i;
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicionMenor = i;
                }
            }

            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("Está en la posición: " + posicionMayor);

            Console.WriteLine("El número menor es: " + menor);
            Console.WriteLine("Está en la posición: " + posicionMenor);
        }
    }
}
