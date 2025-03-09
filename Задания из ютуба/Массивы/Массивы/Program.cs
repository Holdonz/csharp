using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenSumArray = 0;
            Console.Write("Введите количество элементов в массиве: ");
            int[] collectArray = new int [int.Parse(Console.ReadLine())];
            int minValueArray = collectArray[0];

            Console.WriteLine("Необходимо заполнить массив данными\nВведите для каждого элемента число:");
            for (int i = 0; i < collectArray.Length; i++)
            {
                collectArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВаш массив:");
            for (int i = 0; i < collectArray.Length; i++)
            {
                Console.WriteLine($"{i}: {collectArray[i]}");
            }

            Console.WriteLine("\nМассив в обратном порядке:");
            for (int i = collectArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i}: {collectArray[i]}");
            }

            Console.WriteLine("\nСумма четных чисел в массиве: " + evenSumArray);
            for (int i = 0; i < collectArray.Length; i++)
            {
                if (collectArray[i] % 2 == 0)
                {
                    evenSumArray += collectArray[i];
                }
            }

            //эту часть задания я не догадался сделать, но я смог реализовать через вызов метода collectArray.Min();
            Console.WriteLine("\nМинимальное значение в массиве: " + minValueArray);
            for (int i = 0; i < collectArray.Length; i++)
            {
                if (collectArray[i] < minValueArray)
                {
                    minValueArray = collectArray[i];
                }
            }
            
        }
    }
}
