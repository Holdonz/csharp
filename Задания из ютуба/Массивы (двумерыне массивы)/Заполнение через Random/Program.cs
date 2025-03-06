using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заполнение_через_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество столбцов и строк в двумерном массиве:");
            int[,] collectArray = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];

            Random random = new Random();

            for (int i = 0; i < collectArray.GetLength(0); i++)
            {
                for (int j = 0; j < collectArray.GetLength(1); j++)
                {
                    collectArray[i, j] = random.Next(1000);
                }
            }

            Console.WriteLine("\nМассив заполненный случайным методом:");
            for (int y = 0; y < collectArray.GetLength(0); y++)
            {
                for (int x = 0; x < collectArray.GetLength(1); x++)
                {
                    Console.Write(collectArray[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
