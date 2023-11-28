using System;
using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Lapa1_OOP._1

{

    class Program

     
    {
      
      static bool IsPalindrome(int[] arr) 
    
      {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right) 
            {
               if (arr[left] != arr[right])
                    return false;
                    left++;
                    right--;
            }
       return true;

      }
        static void Main()
        {
          Console.Write("Введiть розмiрнiсть матрицi (n): ");
          int n = int.Parse(Console.ReadLine());
        
          int[,] matrix = new int[n, n];
            
           for (int i = 0; i < n; i++)
           
           {
             Console.WriteLine($"Введiть {i + 1}-й рядок, роздiлений пробiлами:");  
             string[] row = Console.ReadLine().Split(' ');
                if (row.Length != n)
                { 
                    Console.WriteLine("Кiлькість елементiв у рядку має дорiвнювати n.");
                    return;

                }
                  for (int j = 0; j < n; j++) 
                  {
                     matrix[i, j] = int.Parse(row[j]);
                  }

            }



            
            Console.WriteLine("Номери рядкiв з палiндромами:");
           
            for (int i = 0; i < n; i++)
            {
               int[] rowArray = new int[n];   
                for (int j = 0; j < n; j++)
                {
                  rowArray[j] = matrix[i, j];
                }
                if (IsPalindrome(rowArray)) 
                {
                  Console.WriteLine(i + 1);
                }

            }

        }

    }

}
