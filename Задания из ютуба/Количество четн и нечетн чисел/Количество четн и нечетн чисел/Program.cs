using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Количество_четн_и_нечетн_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            // Решение составил сам, без помощи гпт)

            // Условия для выполнения программы
            Console.WriteLine("Введите диапозон целых чисел: ");
            Console.Write("Певрое число: ");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            int secondValue = int.Parse(Console.ReadLine());

            // Счетчики
            int even = 0;
            int odd = 0;
            int evenSum = 0;
            int oddSum = 0;

            // Пока первое число меньше или равно второму будет выполняться цикл
            while (firstValue <= secondValue) 
            {
                // Проверка на четность
                if (firstValue % 2 == 0)
                {
                    even++; // Добавление +1 к четному счетчику

                    // Прибавляет число и присваивает к счетчику, чтобы посчитать сумму нечетных чисел
                    evenSum += firstValue;  // evenSum = evenSum + firstValue
                }
                else
                {
                    odd++;  // Добавление +1 к нечетному счетчику

                    // Прибавляет число и присваивает к счетчику, чтобы посчитать сумму нечетных чисел
                    oddSum += firstValue;   // oddSum = oddSum + firstValue
                }

                // Добавляет +1 к числу для завершения цикла
                firstValue++;
            }

            // Вывод результатов
            Console.WriteLine("\nКоличество четных чисел: " + even);
            Console.WriteLine("Количество нечетных чисел: " + odd);

            Console.WriteLine("\nСумма четных чисел: " + evenSum);
            Console.WriteLine("Сумма нечетных чисел: " + oddSum);
        }
    }
}
