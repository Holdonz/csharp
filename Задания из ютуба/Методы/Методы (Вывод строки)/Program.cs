using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы__Вывод_строки_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            string symbol = Console.ReadLine();

            Console.Write("Введите длину строки: ");
            uint lengthString = uint.Parse(Console.ReadLine());

            Console.WriteLine();

            PrintLine(symbol, lengthString);
        }

        static void PrintLine (string symbol, uint lengthString)
        {
            for (int i = 0; i < lengthString; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
