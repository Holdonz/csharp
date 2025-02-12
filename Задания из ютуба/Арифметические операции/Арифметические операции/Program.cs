using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Арифметические_операции
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите 2 числа, чтобы вычеслить среднеарифметическое значение:");

            Console.Write("Первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = (firstNumber + secondNumber) / 2;
            Console.WriteLine($"Среднеарифмитическое {firstNumber} и {secondNumber}: {result}"); 
        }
    }
}
