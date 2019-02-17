using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {// Ingresar un número y mostrar: el cuadrado y el cubo del mismo.
         // Se debe validar que el número sea mayor que cero, caso contrario, 
         // mostrar el mensaje: "ERROR. ¡Reingresar número!".
         //Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación. 
            double num, cuadrado = 2, cubo = 3, resultado;
            Console.WriteLine("Ingrese el número a elevar:");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > 0)
            {
                Console.Clear();
                resultado = Math.Pow(num, cuadrado);
                Console.WriteLine("El cuadrado de " + num + " es: " + resultado + ".");
                resultado = Math.Pow(num, cubo);
                Console.WriteLine("El cubo de " + num + " es: " + resultado + ".");

            }
            else { Console.WriteLine("ERROR. ¡Reingresar número!"); }
            Console.WriteLine("Ingrese el número a elevar:");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > 0)
            {
                Console.Clear();
                resultado = Math.Pow(num, cuadrado);
                Console.WriteLine("El cuadrado de " + num + " es: " + resultado + ".");
                resultado = Math.Pow(num, cubo);
                Console.WriteLine("El cubo de " + num + " es: " + resultado + ".");
                Console.ReadKey();

            }
        }
    }
}
