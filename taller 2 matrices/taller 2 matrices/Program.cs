using System;

namespace taller_2_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] matriz = new int[10, 20];

            //for (int fila = 0; fila < 10; fila++)
            //{
            //    for (int columna = 0; columna < 20; columna++)
            //    {
            //        Console.WriteLine($"Ingrese el valor de la posición [{fila},{columna}]:");
            //        matriz[fila, columna] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int columna = 0; columna < 20; columna++)
            //{
            //    int suma = 0;

            //    for (int fila = 0; fila < 10; fila++)
            //    {
            //        suma = suma + matriz[fila, columna];
            //    }

            //    Console.WriteLine($"La suma de la columna {columna} es: {suma}");
            //}

            //int filas = 0;
            //int columnas = 0;

            //Console.WriteLine("Ingrese el número de filas:");
            //filas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el número de columnas:");
            //columnas = int.Parse(Console.ReadLine());

            //char[,] matriz = new char[filas, columnas];

            //for (int fila = 0; fila < filas; fila++)
            //{
            //    for (int columna = 0; columna < columnas; columna++)
            //    {
            //        Console.WriteLine($"Ingrese el carácter de la posición [{fila},{columna}]:");
            //        matriz[fila, columna] = char.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Matriz original:");

            //for (int fila = 0; fila < filas; fila++)
            //{
            //    for (int columna = 0; columna < columnas; columna++)
            //    {
            //        Console.Write(matriz[fila, columna] + " ");
            //    }

            //    Console.WriteLine();
            //}

            //for (int columna = 0; columna < columnas; columna++)
            //{
            //    char temporal = matriz[0, columna];
            //    matriz[0, columna] = matriz[filas - 1, columna];
            //    matriz[filas - 1, columna] = temporal;
            //}

            //Console.WriteLine("Matriz con la primera fila y la última fila intercambiadas:");

            //for (int fila = 0; fila < filas; fila++)
            //{
            //    for (int columna = 0; columna < columnas; columna++)
            //    {
            //        Console.Write(matriz[fila, columna] + " ");
            //    }

            //    Console.WriteLine();
            //}

            int[,] matriz = new int[5, 5];
            int[] frecuencia = new int[10];

            Random aleatorio = new Random();

            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    matriz[fila, columna] = aleatorio.Next(1, 11);
                }
            }

            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    int numero = matriz[fila, columna];

                    frecuencia[numero - 1]++;
                }
            }

            Console.WriteLine("Matriz:");

            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Console.Write(matriz[fila, columna] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Frecuencia de cada número:");

            for (int i = 0; i < frecuencia.Length; i++)
            {
                Console.WriteLine("Número " + (i + 1) + ": " + frecuencia[i]);
            }
        }
    }
}
