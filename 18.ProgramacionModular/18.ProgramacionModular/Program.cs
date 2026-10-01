using System;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static int añoActual = 2026;
        static void Main(string[] args)
        {
            Console.WriteLine("Biemvenido al curso de fundamentos de programación");
            MostrarMensaje("Isaac");
            Console.WriteLine($"Isaac tiene {CalcularEdad()}");
            MostrarMensaje("Paco");
            int añonacimiento = 1600;
            Console.WriteLine($"paco tiene, {CalcularEdad(añonacimiento, añoActual)} años");
            MostrarMensaje("Isaac", "Diaz Vidal");
            Console.ReadKey();
            Borrarpantalla();
        }

        static int CalcularEdad(int añoNacimiento, int añoActual)
        {
            return añoActual - añoNacimiento;
        }
        static int CalcularEdad()
        {
            int añoNacimiento = 2006;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        }
        static void Borrarpantalla()
        {
            Console.Clear();
        }

        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"bienvenido, {nombre} al curso Fundamentos de programacion");
        }

        static void MostrarMensaje(String nombre, string apellidos)
        {
            Console.WriteLine($"Binbenido, {nombre} {apellidos} al curso Fundamentos de programacion");
        }
    }
}
