using System;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов:
            //первый элемент хранит имя контакта, второй — номер телефона/email.
            
            //немного увлеклась, но вроде всё работает
            Console.WriteLine("Вас приветствует телефонный справочник.");
            string[,] phone = new string[5, 2];
            Console.WriteLine("Введите 'new' для создания нового контакта, 'acc' для показа контактов или 'end' для закрытия справочника.");
            Phone(phone);
        }

        public static void Phone(string[,] phone)
        {
            string command = Convert.ToString(Console.ReadLine());
            if (command == "new")
            {
                for (int i = 0; i <= 5; i++)
                {
                    if (i == 5)
                    {
                        Console.WriteLine("К сожалению, справочник заполнен.\n Введите 'acc' для показа контактов или 'end' для закрытия справочника.");
                        Phone(phone);
                    }
                    else if (phone[i, 0] == null)
                    {
                        Console.WriteLine("Введите имя контакта.");
                        phone[i, 0] = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите контактный номер");
                        phone[i, 1] = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите 'new' для создания нового контакта, 'acc' для показа контактов или 'end' для закрытия справочника.");
                        Phone(phone);
                    }
                }
            }
            else if (command == "end")
            {
                Environment.Exit(0);
            }
            else if (command == "acc")
            {
                if (phone[0, 0] != null)
                {
                    Console.WriteLine("Ваши контакты:");
                    for (int i = 0; i < 5; i++)
                    {
                        if (phone[i, 0] != null)
                        {
                            Console.WriteLine("Контакт №{0}. Имя {1}. Номер телефона {2}.", i + 1, phone[i, 0], phone[i, 1]);
                        }
                        else
                            break;
                    }
                    Console.WriteLine("Введите 'new' для создания нового контакта, 'acc' для показа контактов или 'end' для закрытия справочника.");
                    Phone(phone);
                }
                else
                {
                    Console.WriteLine("Ваши контакты пусты!");
                    Console.WriteLine("Введите 'new' для создания нового контакта, 'acc' для показа контактов или 'end' для закрытия справочника.");
                    Phone(phone);
                }
            }
            else
            {
                Console.WriteLine("Ошибка!\nК сожалению, команда не распознана. Попробуйте ещё раз.");
                Console.WriteLine("Введите 'new' для создания нового контакта, 'acc' для показа контактов или 'end' для закрытия справочника.");
                Phone(phone);
            }
        }
    }
}
