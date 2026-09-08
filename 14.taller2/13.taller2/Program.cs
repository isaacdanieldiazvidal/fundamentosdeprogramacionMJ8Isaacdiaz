using System;

namespace _13.taller2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double calificacion = 0;
            //double suma = 0;
            //int cantidad = 0;
            //double promedio = 0;

            //char continuar;

            //do
            //{
            //    Console.WriteLine("Ingrese una calificación:");
            //    calificacion = double.Parse(Console.ReadLine());

            //    suma = suma + calificacion;
            //    cantidad++;

            //    Console.WriteLine("¿Desea ingresar otra calificación? (S/N)");
            //    continuar = char.Parse(Console.ReadLine());

            //} while (continuar == 'S' || continuar == 's');

            //promedio = suma / cantidad;

            //Console.WriteLine("La suma de las calificaciones es: " + suma);
            //Console.WriteLine("La cantidad de calificaciones es: " + cantidad);
            //Console.WriteLine("El promedio de las calificaciones es: " + promedio);


            //int numero = 0;
            //int resultado = 0;

            //Console.WriteLine("Ingrese un número:");
            //numero = int.Parse(Console.ReadLine());

            //for (int divisor = numero; divisor >= 1; divisor--)
            //{
            //    resultado = numero / divisor;

            //    if (resultado * divisor == numero)
            //    {
            //        Console.WriteLine(divisor);
            //    }
            //}


            int baseNumero = 0;
            int exponente = 0;
            int resultado = 0;
            char continuar;

            do
            {
                Console.WriteLine("Ingrese la base:");
                baseNumero = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el exponente:");
                exponente = int.Parse(Console.ReadLine());

                resultado = 1;

                for (int contador = 1; contador <= exponente; contador++)
                {
                    resultado = resultado * baseNumero;
                }

                Console.WriteLine("El resultado de la potenciación es: " + resultado);

                Console.WriteLine("¿Desea realizar otra potenciación? (S/N)");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar == 'S' || continuar == 's');
        }
    }
}
