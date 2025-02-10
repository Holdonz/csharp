using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SF1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Nikita";
            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");

            Console.ReadKey();
        }
    }
}
