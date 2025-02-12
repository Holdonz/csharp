using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите свой любимый цвет с маленькой буквы: ");

            switch (Console.ReadLine())
            {
                case "красный":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Твой цвет - красный!");
                break;

                case "зеленый":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Твой цвет - зеленый!");
                break;

                case "голубой":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Твой цвет - голубой!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Твой цвет - желытый!");
                break;

            }
        }
    }
}
