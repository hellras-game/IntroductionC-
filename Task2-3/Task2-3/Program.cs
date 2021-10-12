using System;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определить, является ли введённое пользователем число чётным.
            Console.WriteLine("Введите целое число:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число не чётное.");
            }
        }
    }
}
