using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(11, 2022, 01);
            Date date2 = new Date();

            Console.WriteLine(date1);
            Console.WriteLine(date2);

            Console.WriteLine($"Количество дней между датами: {date2 - date1}");

            Console.WriteLine($"Первая дата, увеличенная на 50 дней: {date1 + 50}");
        }
    }
}
