using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapa1_OPP._3
{
    internal class Program
    {
        static bool prime(int num)
        {
            if (num <= 1)
                return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;

        }
        static void GoldbachConjecture(int n)

        {
            if (n <= 2 || n % 2 != 0)
            {
                Console.WriteLine("Гiпотеза Гольбаха не виконується для даного числа.");
                return;
            }

            for (int i = 2; i <= n / 2; i++)
            {
                if (prime(i) && prime(n - i))
                {
                    Console.WriteLine($"{n} = {i} + {n - i}");
                    return;
                }
            }

            Console.WriteLine("Не вдалося знайти два простi числа, якi складають парне число n.");
        }

        static void Main()
        {
            Console.Write("Введiть парне число бiльше 2: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 2 || n % 2 != 0)
            {
                Console.WriteLine("Введене число не вiдповiдає умовам гiпотези Гольбаха.");
            }
            else
            {
                GoldbachConjecture(n);
            }
        }
    }

}
