using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_con_while
{
    class Program
    {
        static void Main(string[] args)
        {// 1. Ingresar 5 números por consola, guardándolos en una variable escalar.
         // Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. 
            int cantidad = 0, num, max = 0, min = 0, promedio = 0; //Preguntar a Demian porque tuve que igualarlas a cero. Tiraba un error.
            Console.WriteLine("Digite sus 5 números:");
            while (cantidad < 5)
            {
                num = Convert.ToInt32(Console.ReadLine());
                cantidad++;

                if (cantidad == 1)
                {
                    num = max;
                    num = min;
                }
                else 
                {
                    if (num > max)
                    {
                     max = num;

                    }
                    if (num < min)
                    {
                        min = num;
                    }
                }
                
                promedio = (promedio + num);
            }
            
            Console.WriteLine("El máximo es: " + max);
            Console.WriteLine("El mínimo es: " + min);
            Console.WriteLine("El promedio es: " + promedio / cantidad);
            Console.ReadKey();
        } 
    }
}
