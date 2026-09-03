using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string numeroCuenta;
            double saldo = 0;

            int cantidadUsuarios = 0;
            double sumaSaldos = 0;
            double promedio = 0;

            char continuar;

            do
            {
                Console.WriteLine("Ingrese el nombre del usuario:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el número de cuenta:");
                numeroCuenta = Console.ReadLine();

                Console.WriteLine("Ingrese el saldo:");
                saldo = double.Parse(Console.ReadLine());

                cantidadUsuarios++;
                sumaSaldos = sumaSaldos + saldo;

                if (saldo > 3000000)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Número de cuenta: " + numeroCuenta);
                    Console.WriteLine("Saldo: " + saldo);
                    Console.WriteLine("Es apto para el crédito.");
                }
                else
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Número de cuenta: " + numeroCuenta);
                    Console.WriteLine("Saldo: " + saldo);
                    Console.WriteLine("No es apto para el crédito.");
                }

                Console.WriteLine("¿Desea ingresar otro usuario? (S/N)");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar == 'S' || continuar == 's');

            if (cantidadUsuarios > 0)
            {
                promedio = sumaSaldos / cantidadUsuarios;

                Console.WriteLine("Cantidad de usuarios: " + cantidadUsuarios);
                Console.WriteLine("Promedio de los saldos: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron usuarios.");
            }
        }
    }
}
