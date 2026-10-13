using System;

namespace _20_porgra_modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filas = CapturarFilas();
            int columnas = CapturarColumnas();

            int[,] matriz = new int[filas, columnas];

            LlenarMatriz(matriz);
            MostrarMatriz(matriz);
        }

        static int CapturarFilas()
        {
            int filas;

            Console.WriteLine("Ingrese las filas:");
            filas = int.Parse(Console.ReadLine());

            return filas;
        }

        static int CapturarColumnas()
        {
            int columnas;

            Console.WriteLine("Ingrese las columnas:");
            columnas = int.Parse(Console.ReadLine());

            return columnas;
        }

        static bool EsMultiplo(int numero)
        {
            if (numero / 5 * 5 == numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void LlenarMatriz(int[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    int numero;

                    Console.WriteLine("Ingrese un múltiplo de 5:");
                    numero = int.Parse(Console.ReadLine());

                    while (EsMultiplo(numero) == false)
                    {
                        Console.WriteLine("El número no es múltiplo de 5.");
                        Console.WriteLine("Ingrese otro número:");
                        numero = int.Parse(Console.ReadLine());
                    }

                    matriz[fila, columna] = numero;
                }
            }
        }

        static void MostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("Matriz final:");

            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
