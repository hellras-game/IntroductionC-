using System;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.
            Console.WriteLine("Введите номер текущего месяца.");
            int n = Convert.ToInt32(Console.ReadLine());
            Month(n);

        }
        private static void Month(int n)
        {
            if (n > 12 || n < 1)
            {
                Console.WriteLine("Ошибка. Введите число от 1 до 12.");
                n = Convert.ToInt32(Console.ReadLine());
                Month(n);
            }
            else
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Январь");
                        break;
                    case 2:
                        Console.WriteLine("Февраль");
                        break;
                    case 3:
                        Console.WriteLine("Март");
                        break;
                    case 4:
                        Console.WriteLine("Апрель");
                        break;
                    case 5:
                        Console.WriteLine("Май");
                        break;
                    case 6:
                        Console.WriteLine("Июнь");
                        break;
                    case 7:
                        Console.WriteLine("Июль");
                        break;
                    case 8:
                        Console.WriteLine("Август");
                        break;
                    case 9:
                        Console.WriteLine("Сентябрь");
                        break;
                    case 10:
                        Console.WriteLine("Октябрь");
                        break;
                    case 11:
                        Console.WriteLine("Ноябрь");
                        break;
                    case 12:
                        Console.WriteLine("Декабрь");
                        break;
                }
            }
            
        }
    }
}
