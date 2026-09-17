using System;

namespace _16.tallervectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int tamaño = 0;

            //Console.WriteLine("Ingrese el tamaño de los vectores:");
            //tamaño = int.Parse(Console.ReadLine());

            //int[] vector1 = new int[tamaño];
            //int[] vector2 = new int[tamaño];

            //for (int i = 0; i < tamaño; i++)
            //{
            //    Console.WriteLine($"Ingrese el número {i + 1} del primer vector:");
            //    vector1[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < tamaño; i++)
            //{
            //    Console.WriteLine($"Ingrese el número {i + 1} del segundo vector:");
            //    vector2[i] = int.Parse(Console.ReadLine());
            //}

            //int iguales = 0;

            //for (int i = 0; i < tamaño; i++)
            //{
            //    if (vector1[i] == vector2[i])
            //    {
            //        iguales++;
            //    }
            //}

            //Console.WriteLine("La cantidad de elementos iguales es: " + iguales);

            //char[] vector1 = new char[6];
            //char[] vector2 = new char[6];

            //for (int i = 0; i < vector1.Length; i++)
            //{
            //    Console.WriteLine($"Ingrese el carácter {i + 1}:");
            //    vector1[i] = char.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < vector1.Length; i++)
            //{
            //    vector2[i] = vector1[vector1.Length - 1 - i];
            //}

            //Console.WriteLine("Primer vector:");

            //for (int i = 0; i < vector1.Length; i++)
            //{
            //    Console.Write(vector1[i] + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("Segundo vector invertido:");

            //for (int i = 0; i < vector2.Length; i++)
            //{
            //    Console.Write(vector2[i] + " ");
            //}

            //int[] vector = new int[20];

            //Random aleatorio = new Random();

            //for (int i = 0; i < vector.Length; i++)
            //{
            //    vector[i] = aleatorio.Next(0, 51);
            //}

            //int numeroBuscado = 0 ;

            //Console.WriteLine("Ingrese el número que desea buscar:");
            //numeroBuscado = int.Parse(Console.ReadLine());

            //bool encontrado = false;

            //for (int i = 0; i < vector.Length; i++)
            //{
            //    if (vector[i] == numeroBuscado)
            //    {
            //        encontrado = true;
            //    }
            //}

            //if (encontrado == true)
            //{
            //    Console.WriteLine("El número se encuentra en la posición:");

            //    for (int i = 0; i < vector.Length; i++)
            //    {
            //        if (vector[i] == numeroBuscado)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }

            //    Console.WriteLine("Vector:");

            //    for (int i = 0; i < vector.Length; i++)
            //    {
            //        if (vector[i] == numeroBuscado)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.Write(vector[i] + " ");
            //            Console.ResetColor();
            //        }
            //        else
            //        {
            //            Console.Write(vector[i] + " ");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("-1");
            //}

            int tamaño =0;

            Console.WriteLine("Ingrese el tamaño del vector (debe ser impar y diferente de 1):");
            tamaño = int.Parse(Console.ReadLine());

            while (tamaño % 2 == 0 || tamaño == 1)
            {
                Console.WriteLine("El tamaño debe ser impar y diferente de 1.");
                Console.WriteLine("Ingrese nuevamente el tamaño:");
                tamaño = int.Parse(Console.ReadLine());
            }

            int[] vector = new int[tamaño];

            int mitad = tamaño / 2;

            Console.WriteLine("Ingrese un número entero:");
            vector[mitad] = int.Parse(Console.ReadLine());

            for (int i = mitad - 1; i >= 0; i--)
            {
                vector[i] = vector[i + 1] - 1;
            }

            for (int i = mitad + 1; i < tamaño; i++)
            {
                vector[i] = vector[i - 1] + 1;
            }

            Console.WriteLine("Vector:");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }
    }
}
