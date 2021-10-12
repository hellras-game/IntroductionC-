using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            Console.WriteLine("Введите минимальную и максимальную температуру через пробел.");
            string s = Convert.ToString(Console.ReadLine());
            string[] t = s.Split(' ');
            float min = float.Parse(t[0]);
            float max = float.Parse(t[1]);
            float val = (min + max) / 2;
            Console.WriteLine("Среднесуточная температура равна {0}", val);
        }
    }
}
