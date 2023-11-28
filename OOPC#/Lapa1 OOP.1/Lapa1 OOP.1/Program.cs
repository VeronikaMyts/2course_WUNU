using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapa1_oop2
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Write("Введiть значення a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введiть значення b: ");
            double b = double.Parse(Console.ReadLine());
           
            
            if (a <= b)
            {
                
                double top = Math.Pow(a + b, 5);
                double down = Math.Pow(b - a, 3);

                
                if (down == 0)
                {
                    Console.WriteLine("Дiлення на нуль не допускається.");
                }
                else
                {
                    double result = Math.Sqrt(top / down);
                    Console.WriteLine("Результат: " + result);
                }
            }
            else
            {
                Console.WriteLine("Значення a не може бути бiльшим за b.");
            }
        }

    }
}