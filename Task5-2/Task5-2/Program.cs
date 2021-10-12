using System;
using System.IO;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            DateTime time = DateTime.Now;
            string t = Convert.ToString(time);
            File.AppendAllLines("time.txt", new[] { t , Environment.NewLine });
            //Не поняла, почему Environment.NewLine кроме одного переноса строки делает ещё два
        }
    }
}
