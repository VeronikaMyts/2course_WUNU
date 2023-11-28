using System;
using System.Data;//Цей простір імен містить класи для роботи з реляційними базами даних та ADO.NET (ActiveX Data Objects for .NET), такі як DataTable, DataRow, SqlConnection, і багато інших.
using System.Linq;//Цей простір імен містить функціональність LINQ (Language Integrated Query) для операцій над даними та колекціями.


namespace Lapa2.OOP
{
    internal class Program
    {
        static void Main()
        {
          
            Console.Write("Введiть кiлькiсть елементiв у масивi: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Невiрне введення. Кiлькiсть елементiв має бути цiлим додатнiм числом.");
                return;
            }

            double[] array = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введiть {i + 1}-й елемент: ");
                if (!double.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Невiрне введення. Будь ласка, введiть дiйсне число.");
                    i--;
                }
            }

            ArraySegment<double> segment = new ArraySegment<double>(array);

            double sumOfPositives = 0;
            double productBetweenMinMax = 1;

            if (segment.Count > 0)
            {
                int maxIndex = 0;
                int minIndex = 0;

                for (int i = 1; i < segment.Count; i++)
                {
                    if (Math.Abs(segment.Array[i]) > Math.Abs(segment.Array[maxIndex]))
                    {
                        maxIndex = i;
                    }
                    if (Math.Abs(segment.Array[i]) < Math.Abs(segment.Array[minIndex]))
                    {
                        minIndex = i;
                    }
                }

                foreach (double element in segment)
                {
                    if (element > 0)
                    {
                        sumOfPositives += element;
                    }
                }

                int startIndex = Math.Min(maxIndex, minIndex) + 1;
                int endIndex = Math.Max(maxIndex, minIndex);

                if (startIndex < endIndex)
                {
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        productBetweenMinMax *= segment.Array[i];
                    }
                }

                Array.Sort(segment.Array, (a, b) => b.CompareTo(a));
            }

            Console.WriteLine("Сума додатних елементiв: " + sumOfPositives);
            Console.WriteLine("Добуток мiж максимальним i мiнiмальним за модулем елементами: " + productBetweenMinMax);
            Console.WriteLine("Впорядкований масив за спаданням:");
            foreach (double element in segment)
            {
                Console.Write(element + " ");
            }

        }
    }
}
