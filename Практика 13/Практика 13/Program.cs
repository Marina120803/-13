using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ввести число строк m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ввести число столбцов n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[m, n];
            Random rand = new Random();
            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rand.Next(0, 1000);
                }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
