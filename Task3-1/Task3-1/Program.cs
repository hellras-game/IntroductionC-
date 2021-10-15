using System;

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Написать программу, выводящую элементы двумерного массива по диагонали.
            Console.WriteLine("Введите количество строк массива:");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива:");
            int y = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[x,y];
            Random rand = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = rand.Next(1,10);
                }
            }
            Output(arr, x, y);
        }
        public static void Output(int [,] arr, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0} ", arr[i, j]);
                    }
                }
            }

        }
    }
}
