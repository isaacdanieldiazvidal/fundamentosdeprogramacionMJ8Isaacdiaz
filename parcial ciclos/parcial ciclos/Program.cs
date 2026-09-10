using System;

namespace parcial_ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int codigo = 0;
            int cantidad;

            int totalUnidades = 0;
            int lotesValidos = 0;

            do
            {
                Console.WriteLine("Ingrese el código del producto (si desea terminar ponga el valor -1):");
                codigo = int.Parse(Console.ReadLine());

                if (codigo != -1)
                {
                    Console.WriteLine("Ingrese la cantidad de unidades:");
                    cantidad = int.Parse(Console.ReadLine());

                    if (cantidad <= 0)
                    {
                        Console.WriteLine("Cantidad inválida, no se sumará al inventario");
                    }
                    else
                    {
                        totalUnidades = totalUnidades + cantidad;
                        lotesValidos++;
                    }
                }

            } while (codigo != -1);

            Console.WriteLine("Total de unidades ingresadas: " + totalUnidades);
            Console.WriteLine("Cantidad de lotes válidos: " + lotesValidos);

        }
    }
}
