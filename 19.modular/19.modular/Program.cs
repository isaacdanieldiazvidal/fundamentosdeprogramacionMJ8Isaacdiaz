using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Remoting.Messaging;

namespace _19.modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }
        static float Division() 
        {
            Console.WriteLine("Ingrese el numero1:");
            char
        }
        static float Suma()
        {
            float suma = 0;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea seguir sumando (s: continuar)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }
        static float Multiplicasion()
        {
            float multiplicasion = 1;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = float.Parse(Console.ReadLine());
                multiplicasion *= numero;
                Console.WriteLine("Desea seguir sumando (s: continuar)");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicasion;
        }   
            
        static void RealizarOperaciones(int opcion) 
        {
            while (opcion!=0)
            {

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La Suma de los numeros ingresados es: {Suma()} ");
                        break;
                    case 2:
                        Console.WriteLine("Resta");
                        break;
                    case 3:
                        Console.WriteLine($"La Multiplicasion de los numeras ingrasados es {Multiplicasion()}");
                        break;
                    case 4:
                        Console.WriteLine("Division");
                        break;
                    
                } 
            }
        }
        static int CapturarOpcion() 
        {
            return int.Parse(Console.ReadLine());
        }
        static void MostrarMenu()
        {
            Console.WriteLine("-------------Menu-------------");
            Console.WriteLine("ingrese una pocion del menu:");
            Console.WriteLine("1. Suma               2. Resta");
            Console.WriteLine("3. Multiplicasion  4. Division");
            Console.WriteLine("0 Salir");
            Console.WriteLine("------------------------------");
        }
    }
}
