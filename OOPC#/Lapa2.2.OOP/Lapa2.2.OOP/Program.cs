using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapa2._2.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.Write("Введіть кількість рядків матриці: ");
            int rowCount = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість стовпців матриці: ");
            int colCount = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rowCount][];

         
            for (int i = 0; i < rowCount; i++)
            {
                matrix[i] = new int[colCount];
                Console.WriteLine($"Введіть рядок {i + 1} з {colCount} чисел, розділених пробілами:");
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    matrix[i][j] = int.Parse(input[j]);
                }
            }

            // Знаходження кількості стовпців без нулів
            int nonZeroColumns = 0;
            for (int j = 0; j < colCount; j++)
            {
                bool hasZero = false;
                for (int i = 0; i < rowCount; i++)
                {
                    if (matrix[i][j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }
                if (!hasZero)
                {
                    nonZeroColumns++;
                }
            }

            // Сортування рядків за характеристиками (сума додатних парних елементів)
            Array.Sort(matrix, (row1, row2) =>
            {
                int sum1 = 0, sum2 = 0;
                foreach (int num in row1)
                {
                    if (num > 0 && num % 2 == 0)
                    {
                        sum1 += num;
                    }
                }
                foreach (int num in row2)
                {
                    if (num > 0 && num % 2 == 0)
                    {
                        sum2 += num;
                    }
                }
                return sum1.CompareTo(sum2);
            });

            // Виведення результатів
            Console.WriteLine($"Кількість стовпців без нулів: {nonZeroColumns}");
            Console.WriteLine("Матриця після сортування за характеристиками:");
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
