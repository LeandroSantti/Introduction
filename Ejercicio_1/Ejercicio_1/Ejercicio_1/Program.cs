using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {// 1. Ingresar 5 números por consola, guardándolos en una variable escalar.
         // Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. 
            int num1, num2, num3, num4, num5;
            Console.WriteLine("Digite un número:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un número:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un número:");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un número:");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un número:");
            num5 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                Console.WriteLine("Numero mayor: " + num1);
            }
            if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            {
                Console.WriteLine("Numero mayor: " + num2);
            }
            if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            {
                Console.WriteLine("Numero mayor: " + num3);
            }
            if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            {
                Console.WriteLine("Numero mayor: " + num4);
            }
            if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
            {
                Console.WriteLine("Numero mayor: " + num5);
            }
            if (num1 < num2 && num1 < num3 && num1 < num4 && num1 < num5)
            {
                Console.WriteLine("Numero menor: " + num1);
            }
            if (num2 < num1 && num2 < num3 && num2 < num4 && num2 < num5)
            {
                Console.WriteLine("Numero menor: " + num2);
            }
            if (num3 < num1 && num3 < num2 && num3 < num4 && num3 < num5)
            {
                Console.WriteLine("Numero menor: " + num3);
            }
            if (num4 < num1 && num4 < num2 && num4 < num3 && num4 < num5)
            {
                Console.WriteLine("Numero menor: " + num4);
            }
            if (num5 < num1 && num5 < num2 && num5 < num3 && num5 < num4)
            {
                Console.WriteLine("Numero menor: " + num5);
            }
            Console.WriteLine("El promedio es: " + (num1 + num2 + num3 + num4 + num5) / 5);
            Console.ReadKey();

        }
    }
}
