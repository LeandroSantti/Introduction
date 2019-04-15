using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_con_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {// 1. Ingresar 5 números por consola, guardándolos en una variable escalar.
         // Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio
            int cantidad = 0, max = 0, min =0, num, promedio = 0;
            Console.WriteLine("Digite sus 5 números:");

            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                
                if (cantidad == 0)
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
                
                cantidad++;
                promedio = (promedio + num);
            }            
            while (cantidad < 5);
            
            Console.WriteLine("El número máximo es: " + max);
            Console.WriteLine("El número mínimo es: " + min);
            Console.WriteLine("El promedio de los números es: " + promedio / cantidad);
            Console.ReadKey();
        }
    }
}
