using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Title = "Практическая работа № 6"; // заголовок консоли

                int a, b, c; // объявление переменных

                Console.ForegroundColor = ConsoleColor.Yellow; // цвет шрифта
                Console.BackgroundColor = ConsoleColor.Magenta; // цвет фона шрифта
                Console.WriteLine("Здравствуйте!");

                Console.Write("Введите a = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите с = ");
                c = Convert.ToInt32(Console.ReadLine());

                if (a == b || b == c || c == a)
                    Console.Write("Числа не должны быть равны");

                switch (a > b && a > c && b > c)
                {
                    case true:
                        Console.WriteLine($"Результат: {c}, {b}, {a}"); break;
                }
                switch (a > b && a > c && c > b)
                {
                    case true:
                        Console.WriteLine($"Результат: {b}, {c}, {a}"); break;
                }
                switch (a > b && a < c && c > b)
                {
                    case true:
                        Console.WriteLine($"Результат: {b}, {a}, {c}"); break;
                }
                switch (a < b && b > c && a > c)
                {
                    case true:
                        Console.WriteLine($"Результат: {c}, {a}, {b}"); break;
                }
                switch (a < b && b > c && a < c)
                {
                    case true:
                        Console.WriteLine($"Результат: {a}, {c}, {b}"); break;
                }
                switch (a < b && b < c && c > a)
                {
                    case true:
                        Console.WriteLine($"Результат: {a}, {b}, {c}"); break;
                }
            }

            catch (FormatException) // обработка исключений
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка: введите число, а не символ");
            }
            catch (Exception е) // обработка исключений
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:"+е.Message);
            }
            Console.ReadKey();


        }
    }
}
