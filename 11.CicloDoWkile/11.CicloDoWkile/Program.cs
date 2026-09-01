using System;

namespace _11.CicloDoWkile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int contador = 1;
            //int acumulador = 0;

            //do
            //{
            //    acumulador += contador;
            //    contador++;
            //}   while (acumulador<=5);

            //Console.WriteLine("$lLa suma los primeros 5 numeros enteros positivos es :{acumulador}");

            //int numero = 0;
            //int multiplicador = 0;
            //string respuesta;

            //do
            //{
            //    Console.WriteLine("Ingrese un número:");
            //    numero = int.Parse(Console.ReadLine());

            //    multiplicador = 1;

            //    while (multiplicador <= 10)
            //    {
            //        Console.WriteLine(numero + " x " + multiplicador + " = " + (numero * multiplicador));
            //        multiplicador++;
            //    }

            //    Console.WriteLine("¿Desea realizar otra tabla? (si/no)");
            //    respuesta = Console.ReadLine();

            //    if (respuesta == "si")
            //    {
            //        Console.WriteLine("Vamos a realizar otra tabla.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se realizarán más tablas.");
            //    }

            //} while (respuesta == "si");

            //Console.WriteLine("Programa terminado.");

            int numero = 2;
            int divisor;
            int resultado;
            bool primo;

            do
            {
                divisor = 2;
                primo = true;

                do
                {
                    resultado = numero / divisor;

                    if (resultado * divisor == numero && divisor != numero)
                    {
                        primo = false;
                    }
                    else
                    {
                        divisor++;
                    }

                } while (divisor < numero && primo == true);

                if (primo == true)
                {
                    Console.WriteLine(numero);
                }
                else
                {
                    Console.Write("");
                }

                numero++;

            } while (numero <= 100);

            Console.WriteLine("Fin del programa.");

        }
    }
}
