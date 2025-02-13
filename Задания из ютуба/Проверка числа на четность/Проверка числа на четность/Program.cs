using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_числа_на_четность
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для проверки на четность: ");
            double  value = double.Parse(Console.ReadLine());
            
            //Если введеное число делится без остатка на 2 (True), то выполнится первое условие, иначе второе.
            if (value % 2 == 0)
                Console.WriteLine("Число четное");
            else
                Console.WriteLine("Число нечетное");
        }
    }
}
