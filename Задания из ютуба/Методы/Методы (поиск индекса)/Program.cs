using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Методы__поиск_индекса_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество в случайном массиве: ");
            uint length = uint.Parse(Console.ReadLine());

            Console.Write("Введите минимальный диапазон значений: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Введите максимальный диапазон значений: ");
            int max = int.Parse(Console.ReadLine());

            int[] myArray = GetRandomArray(length, min, max);

            Console.Write("Введите элемент который вы хотите найти: ");
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш элемент находится под индексом " + FindIndex(myArray, element));
        }

        static int[] GetRandomArray (uint length, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] randomArray = new int[length];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue);
            }
            return randomArray;
        }

        static int FindIndex (int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
