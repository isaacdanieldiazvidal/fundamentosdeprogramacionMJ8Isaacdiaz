using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condisionales4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //estructura de control condisional
            //simple
            //1. crea un algoritmo que lea la edad de un usuario, si el usuario, es mayor de 18, se deve mostrar el siguiente mensaje: "biemvenido a mi sito web"
            byte edad = 0;
            Console.WriteLine("ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18) 
            {
                //si la condision es verdadera 
                Console.WriteLine("biemvenido a mi sitio web");


            }
            else
            {
                Console.WriteLine("no eres apto para este sitio");
            }
            
                //}

                //2. crea un algoritmo que permitta ingresar el nombre y sueldo de una persona, si el sueldo supera los 300o mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.
                /*         string nombre = null;
                         float sueldo = 0;
                         Console.WriteLine("ingrese su nombre");
                         nombre = Console.ReadLine();
                         Console.WriteLine("ingrese su sueldo");
                         sueldo = Convert.ToSingle(Console.ReadLine());
                         if (nombre != null) 
                         {
                             Console.WriteLine(nombre);
                         }
                         if (sueldo >= 3000) 
                         { 
                             Console.WriteLine("!debes pagar tus impuestos¡");


                         }*/



            }
    }
}
