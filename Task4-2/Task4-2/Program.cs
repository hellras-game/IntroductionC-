using System;
using System.Collections.Generic;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
            //и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.

            Console.WriteLine("Введите целые числа через пробел");
            string s = Convert.ToString(Console.ReadLine());
            string[] array = s.Split(' ');
            int sum = 0, l = array.Length;
            //int[] arr = new int[l];
            for (int i = 0; i < l; i++)
            {
                string aS = array[i];
                int aI = Int32.Parse(aS);
                sum += aI;
            }
            
            Console.WriteLine("Сумма чисел равна " + sum);
        }
    }
}
