using System;
using System.Collections.Generic;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в 
             * разных аргументах и возвращающий объединённую строку с ФИО.Используя метод, написать программу, выводящую в консоль
             * 3–4 разных ФИО.
            */

            Console.WriteLine("Сколько ФИО в списке? Введите число в символьной форме.");
            int j = Convert.ToInt32(Console.ReadLine());
            int i = j * 3 - 1;//количество элементов массива
            int c = 1;
            List<string> fio = new List<string>();
            while (c <= i)
            {
                Console.WriteLine($"Введите имя, фамилию и отчество через пробел.");//запрашиваю в таком порядке, чтобы в выводе были видны изменения
                string s = Convert.ToString(Console.ReadLine());
                string[] curr = s.Split(' ');
                fio.Add(curr[0]);
                fio.Add(curr[1]);
                fio.Add(curr[2]);
                c += 3;
            }
            


            Write(i, fio);
            static void Write(int i, List<string> fio)
            {
                for (int count = 0; count <= i - 2; count += 3)
                {
                    Console.WriteLine(GetFullName(fio[count], fio[count + 1], fio[count + 2]));
                }
            }

            static string GetFullName(string firstName, string lastName, string patronymic)
            {
                string FullName = "";
                FullName += lastName + " ";
                FullName += firstName + " ";
                FullName += patronymic + " ";
                return FullName;
            }
        }
    }
}
