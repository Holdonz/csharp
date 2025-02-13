using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Арифметические_операции_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвертирование доллар/рубль");
            Console.WriteLine("Какую валюты вы хотите перевести? \nдол/руб");

            Console.Write("Введите валюту: ");
            string currency = Console.ReadLine();

            Console.Write("Введите конвертируемую сумму: ");
            double sum = int.Parse(Console.ReadLine());

            // По идее здесь не должна быть условная конструкция, но я решил ее сделать
            // Ибо я хочу дать чуть больше вариативности пользователю
            if (currency == "дол")
            {
                double result = sum * 94.05;
                Console.WriteLine("Конвертирование из доллар в рубль {0}", result);
            }
             //Также здесь можно поставить else if, чтобы избежать ошибок.
             //Допустим пользователь вводит евр, которое по условию не предусмотренно, а будет выводиться доллар.
             //Поэтому все таки лучше использовать else if, чтобы вызвать исключение,
             //но для данного уровня исключение будет неуместным
            else
            {
                double result = sum * 0.010633;
                Console.WriteLine("Конвертирование из рубль в доллар {0}", result);
            }
            
            
        }
    }
}
