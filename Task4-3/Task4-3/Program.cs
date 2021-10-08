using System;
using System.Collections.Generic;

namespace Task4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
            //На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. Написать метод,
            //принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
            //Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. Если введено некорректное число,
            //вывести в консоль текст «Ошибка: введите число от 1 до 12».

            //не совсем поняла, на чём должно базироваться наше задание и как присвоить название времени года на русском

            object[] months = { Season.Winter, Season.Winter, Season.Spring, Season.Spring, Season.Spring, Season.Summer, Season.Summer, Season.Summer,
            Season.Autumn, Season.Autumn, Season.Autumn, Season.Winter};

            Console.WriteLine("Введите число месяца:");
            int n = Convert.ToInt32(Console.ReadLine());
            while (!(n >= 1 && n <= 12))
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(months[n - 1]);

        }

        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
    }
}
