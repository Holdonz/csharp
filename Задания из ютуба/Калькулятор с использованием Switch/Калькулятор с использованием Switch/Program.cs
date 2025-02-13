using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор_с_использованием_Switch
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

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат:\n{firstOperand} + {secondOperand} = {firstOperand + secondOperand}");
                    break;

                case "-":
                    Console.WriteLine($"Результат:\n{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
                    break;

                case "*":
                    Console.WriteLine($"Результат:\n{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
                    break;

                case "/":
                    Console.WriteLine($"Результат:\n{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
                    break;

                default:
                    Console.WriteLine("Вы ввели неизвестный оператор!");
                    break;
            }
        }
    }
}
