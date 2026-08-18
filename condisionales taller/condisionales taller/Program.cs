using System;


namespace condisionales_taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            //numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            //diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            //pantalla los números de menor a mayor.
            
            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;
            Console.WriteLine("ingrese tres valores diferentes");
            Console.WriteLine("ingrese valor 1");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese valor 2");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese valor 3");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)

                if (numero1 > numero2 && numero1 > numero3)
                {
                    Console.WriteLine("el numero 1 es mayor");
                }
                if (numero2 > numero1 && numero2 > numero3)
                {
                    Console.WriteLine("el numero 1 es mayor");
                }
                if (numero3 > numero1 && numero3 > numero2)
                {
                    Console.WriteLine("el numero 1 es mayor");
                }

            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3) 
            {
                Console.WriteLine("ingrese valores diferentes");
            }

            if (numero1 > numero2 && numero2 > numero3)
            {
                Console.WriteLine(" 3 2 1 ");

                    if (numero1 > numero3 && numero3 > numero2)
                    {
                    Console.WriteLine(" 2 3 1 ");
                    }
            }
            if (numero2 > numero1 && numero1 > numero3)
            {
                Console.WriteLine(numero3 + " " + numero1 + "" + numero2+ " " );

                if (numero2 > numero3 && numero3 > numero1)
                {
                    Console.WriteLine(" 1 3 2 ");
                }
            }
            if (numero3 > numero1 && numero1 > numero2)
            {
                Console.WriteLine(" 2 1 3 ");

                if (numero3 > numero2 && numero2 > numero1)
                {
                    Console.WriteLine(" 1 2 3 ");
                }
            }
}
