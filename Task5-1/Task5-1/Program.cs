using System;
using System.IO;
using System.Collections.Generic;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл
            List<string> messList = new List<string>();
            string s = "first";
            while (s != "")
            {
                string curr = Console.ReadLine();
                s = curr;
                if (s == "")
                    break;
                messList.Add(curr);
            }

            File.WriteAllLines("message.txt", messList);
        }
    }
}
