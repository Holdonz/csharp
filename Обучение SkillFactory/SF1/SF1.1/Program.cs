using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Никита";
            byte age = 18;
            bool pet = true;
            double sizeFoot = 41.5;

            Console.WriteLine("Меня зовут " + myName);
            Console.WriteLine("Мне " + age);
            Console.WriteLine("У меня есть собака, его зовут Балу " + pet);
            Console.WriteLine("Мой размер ноги " + sizeFoot);
        }
    }
}
