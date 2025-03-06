using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Действия_над_числами
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > 0 && a < 99 && b > 0 && b < 99 && c > 0 && c < 99)
            {
                if (a > 0 && b == 10 && c >= 50)
                {
                    Console.WriteLine("\nЧисло a является положительным");
                    Console.WriteLine("Число b = 10");
                    Console.WriteLine("Число c >= 50");
                    Console.WriteLine($"\nСумма трех чисел: {a + b + c}");
                    Console.WriteLine($"Произведение трех чисел: {a * b * c}");
                    if (a > 0 && b > 0 && c > 0 && a + b == c)
                    {
                        Console.WriteLine("\nТри числа является положительным, сумма первых двух чисел равна третьему числу");
                    }
                    else if (a > 0 && b > 0 && c > 0 && a + b < c)
                    {
                        Console.WriteLine("\nТри числа является положительным, сумма двух первых чисел меньше третьего числа");
                    }
                    else
                    {
                        Console.WriteLine("Значение не совпадает с условием");
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение");
                }
                
            }
            else
            {
                Console.WriteLine("Числа не входят в диапазон");
            }
        }
    }
}
