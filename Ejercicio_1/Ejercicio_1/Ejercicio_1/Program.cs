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
            int cantidad = 5, num, max =0, min=0, promedio=0; //Preguntar a Demian porque tuve que igualarlas a cero. Tiraba un error.
            Console.WriteLine("Digite sus cinco números.");
            Console.Clear();
            for (int x = 0; x < cantidad; x++)
            {
                Console.WriteLine("Digite un número:");
                num = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    max = num;
                    min = num;
                }
                
                    if (num < min)
                    {
                        min = num;
                    }
                    if (num > max)
                    {
                        max = num;
                    }
                promedio =  (promedio + num); //Salió de casualidad, ¿Por qué se acumulan los números si en ningún lado los sumé entre si?
            }
            Console.WriteLine("El número máximo es: " + max);
            Console.WriteLine("El número mínimo es: " + min);
            Console.WriteLine("El promedio de los números es: " + promedio / cantidad);
            Console.ReadKey();    
        }
    }
}
