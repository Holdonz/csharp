using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Напиши как тебя зовут: " );
            string name = Console.ReadLine();
            Console.Write("Напиши сколько тебе лет: ");
            byte age = Convert.ToByte( Console.ReadLine());

            Console.WriteLine($"Тебя зовут {name} и тебе {age}");
            Console.Write("Какой твой любимый день недели? ");

            //здесь сначало называется переменная, а потом строка конвертируется в число и указывает число недели
            DayOfWeek day = (DayOfWeek) Convert.ToByte(Console.ReadLine()); 

            Console.WriteLine("Твой любимый день недели: {0}", day);
        }
    }
}
