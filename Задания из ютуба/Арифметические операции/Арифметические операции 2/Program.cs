using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Арифметические_операции_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа для подсчета их суммы и произведения:");

            Console.Write("Первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Третье число: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine($"Сумма трех чисел: {sum}");

            int com = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine($"Произведенике трех чисел: {com}");
        }
    }
}
