using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация массива строк
            string[] daysOfWeek = { "Hello", "Monday", "2",
      ":)", "Russia", "433", "computer" };

            // Вывод массива строк AS в цикле
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                if(daysOfWeek[i].Length<4)
                    Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
            }
            Console.ReadKey();
        }
    }
}