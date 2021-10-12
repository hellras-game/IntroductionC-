using System;

namespace Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую в консоль текст: «Привет, %имя пользователя%, сегодня %дата%». Имя пользователя сохранить из консоли в
            //промежуточную переменную. Поставить точку останова и посмотреть значение этой переменной в режиме отладки. Запустить исполняемый файл через системный терминал.
            Console.WriteLine("Представьтесь:");
            string s = Convert.ToString(Console.ReadLine());
            DateTime date = DateTime.Now;
            Console.WriteLine("Привет, {0}, сегодня {1}", s, date.ToShortDateString());
        }
    }
}
