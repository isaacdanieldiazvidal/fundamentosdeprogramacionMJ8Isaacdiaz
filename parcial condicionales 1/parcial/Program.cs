using System;

//1.Selección del tipo de pizza
//El programa debe solicitar al usuario que seleccione uno de los siguientes tipos de pizza:
//Vegetariana
//No vegetariana

namespace parcial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 0;
            Console.WriteLine("elija una pizza");
            Console.WriteLine("--------------Nemu--------------");
            Console.WriteLine(" vegetarana  o no vegetariana ");
            Console.WriteLine(" elija 1 para vegetariana elija 2 para no vegetariana");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Elija una opcion del menu:");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligio la vegetariana");
                    break;
                case 2:
                    Console.WriteLine("Eligio la no vegetariana");
                    break;
                default:
                    Console.WriteLine("Elija una opcion valida");
                    break;