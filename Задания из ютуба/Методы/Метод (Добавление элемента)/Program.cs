using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод__Добавление_элемента_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6 };
            AddElement(ref myArray, 4, 55);
        }

        //Пытался повторить метод, который добавляет элемент в массив (в конец, начало и по индексу), но у меня совершенно
        //нет идей. Я ебанный затупок который не понимает как работают методы циклы и массивы.
        static void AddElement(ref int[] array, int element, int value)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
                if (newArray[i] == 0)
                {
                    newArray[i] = value;
                }
            }
            array = newArray;
        }
    }
}
