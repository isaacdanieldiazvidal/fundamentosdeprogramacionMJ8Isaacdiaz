using System;


namespace _14.areglos1dimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numeros=new int[5];
            //numeros[0] = 20;
            //numeros[1] = 30;
            //numeros[2] = 40;
            //numeros[3] = 50;
            //numeros[4] = 60;
            //Console.WriteLine($"el dato almasenaso en la condicion 4 con indice 3 es: {numeros[3]}");
            //float[] notas = new float[3];
            //notas[0] = 3.6f;
            //notas[1] = 4.3f;
            //notas[2] = 5.0f;
            //char[] simbolos = new char[] { '7', '(', '5', 'f' };
            //bool[] valoresVredad = { true, false, true, false };


            //string[] nombres = new string[7];

            //for (int i = 0; i < 7; i++) 
            //{
            //    Console.WriteLine($"ingrese el nombre de la P{i + 1}:{i}");
            //    nombres[i]=Console.ReadLine();
            //}


            //for (int i = 0; i < nombres.Length; i++) 
            //{
            //    Console.Write($"{nombres[i]} |");
            //}

            int[] enteros = new int[10];

            for (int i = 0; i < enteros.Length; i++)
            {
                enteros[i] = 10;
            }

            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine($"El dato almacenado en la posición {i} es: {enteros[i]}");
            }

        }
    }
}
