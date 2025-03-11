using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод__Resize_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве: ");
            int[] myArray = new int[int.Parse(Console.ReadLine())];

            Console.WriteLine("Хотите заполнить массив данными?: ");
            string answer = Console.ReadLine();
            if (answer == "Да" || answer == "да" || answer == "ДА")
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine($"Введите элемент массива под индексом {i}: ");
                    myArray[i] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("На сколько элементов вы хотите увеличить или уменьшить массив?");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ваш массив:");
            Console.WriteLine();
            Array.Resize(ref myArray, 5);
            Resize(ref myArray, size);
        }
        
        //данный метод не работает как надо. Он добавляет элементы и при этом не помещает старые элементы в новый массив
        static void Resize(ref int[] array, int newSize)
        {
            int[] array2 = new int[array.Length + newSize];
            array = array2;
            if (0 > array.Length + newSize)
            {
                Console.WriteLine("Количество элементов не может быть отрицательным");
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }                       
        }
    }
}
