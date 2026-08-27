using System;

namespace _9.sicloswhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CantidadNumeros = 0;
            int numero = 0;
            int contador = 0;
            int contadorpositivos = 0;
            int contadornegativos = 0;
            int contadorceros = 0;
            Console.WriteLine("ingrese la cantidad de numeros a evaluar");
            CantidadNumeros = int.Parse(Console.ReadLine());

            while (CantidadNumeros >= contador)
            {
                contador++;
                Console.WriteLine("ingrese el numero a evaluar");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    contadornegativos++;
                }
                else
                {
                    if (numero > 0)
                    {
                        contadorpositivos++;
                    }
                    else
                    {
                        contadorceros++;
                    }
                }
                Console.WriteLine($"cantidad positivos: {contadorpositivos}, cantidad negativos : {contadornegativos}, cantidad de ceros : {contadorceros}");
            }
        }
    }
}
