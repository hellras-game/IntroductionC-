using System;

namespace Task2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли,
            //только за место динамических, по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были
            //заранее заготовлены до вывода на консоль.
            string company = "Ozon", adress = "Piece street, 12", email = "support@ozon.ru", site = "ozon.ru", thing = "pencil";
            DateTime date = DateTime.Now;
            int clientNumb = 24, receiptNumb = 12354, count = 3;
            float cost = 20.2f, sum = 60.8f;
            Console.WriteLine(company);
            Console.WriteLine(adress);
            Console.WriteLine(email);
            Console.WriteLine(site);
            Console.WriteLine("__________________________________");
            Console.WriteLine("           Receipt " + receiptNumb);
            Console.WriteLine("__________________________________");
            Console.WriteLine("Client " + clientNumb);
            Console.WriteLine("__________________________________");
            Console.WriteLine(thing + " x "+count+" -------------------" + cost);
            Console.WriteLine("                         Sum: " + sum);


        }
    }
}
