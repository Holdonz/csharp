using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор_с_использованием_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите арифметическую операцию: ");
            string operation = Console.ReadLine();

            Console.Write("Введите первый операнд: ");
            double firstOperand = double.Parse(Console.ReadLine());

            Console.Write("Введите второй операнд: ");
            double secondOperand = double.Parse(Console.ReadLine());

            if (operation == "+")
                Console.WriteLine($"Результат:\n{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");

            else if (operation == "-")
                Console.WriteLine($"Результат:\n{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");

            else if (operation == "*")
                Console.WriteLine($"Результат:\n{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");

            else if (operation == "/")
                Console.WriteLine($"Результат:\n{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");

            else
                Console.WriteLine("Вы ввели неизвестный оператор!");
        }
    }
}
