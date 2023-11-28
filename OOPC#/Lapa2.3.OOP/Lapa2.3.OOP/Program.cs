using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lapa2._3.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("Введіть текстовий рядок:");
            string input = Console.ReadLine();

            // Перевірка кількості відкритих і закритих круглих та квадратних дужок
            int openParenthesesCount = input.Count(c => c == '(');
            int closeParenthesesCount = input.Count(c => c == ')');
            int openSquareBracketsCount = input.Count(c => c == '[');
            int closeSquareBracketsCount = input.Count(c => c == ']');

            if (openParenthesesCount == closeParenthesesCount && openSquareBracketsCount == closeSquareBracketsCount)
            {
                Console.WriteLine("Кількість відкритих і закритих дужок співпадає.");
            }
            else
            {
                Console.WriteLine("Кількість відкритих і закритих дужок не співпадає.");
            }

            // Знаходження найдовшого слова
            string[] words = input.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':', '(', ')', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();

            if (longestWord != null)
            {
                Console.WriteLine($"Найдовше слово: {longestWord}");
            }
            else
            {
                Console.WriteLine("Немає слів у введеному рядку.");
            }

            // Видалення 
            string pattern = @"^[A-Za-z]+$";
            string result = string.Join(" ", words.Where(word => !Regex.IsMatch(word, pattern)));

            Console.WriteLine($"Текст без слів, що складаються тільки з латинських літер:\n{result}");
        }
    }
}

