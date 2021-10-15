using System;

namespace Task3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).
            Console.WriteLine("Введите строку:");
            string s = Convert.ToString(Console.ReadLine());
            char[] inv = new char[s.Length];
            int j = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                inv[i] = s[j];
                j--;
            }
            s = new string(inv);
            Console.WriteLine(s);
        }
    }
}