using System;
using System.Collections.Generic;
using System.IO;

namespace Task5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
            List<byte> array = new List<byte>();
            Console.WriteLine("Введите произвольный набор целых чисел через пробел и нажмите enter");
            string currS = Console.ReadLine();
            string[] curr = currS.Split(' ');
            for (int j = 0; j < curr.Length; j++)
            {
                array.Add(Convert.ToByte(curr[j]));
            }
            byte[] byteArr = new byte[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                byteArr[i] = array[i];
            }
            File.WriteAllBytes("bytes.bin", byteArr);
        }
    }
}
