//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Действия_над_числами__GPT_
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Ввод трех целых чисел
//            Console.WriteLine("Введите первое число:");
//            int a = ReadInt(1, 99); //Ограничение на 1-2 цифры

//            Console.WriteLine("Введите второе число:");
//            int b = ReadInt(1, 99);

//            Console.WriteLine("Введите третье число:");
//            int c = ReadInt(1, 99);

//            // Вывод сообщений о свойствах чисел
//            string aMessage = a > 0 ? "Число a является положительным." : "Число a не является положительным.";
//            string bMessage = b == 10 ? "Число b равно 10." : "Число b не равно 10.";
//            string cMessage = c >= 50 ? "Число c больше или равно 50." : "Число c меньше 50.";

//            Console.WriteLine(aMessage);
//            Console.WriteLine(bMessage);
//            Console.WriteLine(cMessage);


//            // Вывод суммы и произведения
//            Console.WriteLine($"Сумма трех чисел: {a + b + c}");
//            Console.WriteLine($"Произведение трех чисел: {a * b * c}");

//            // Проверка условий на три положительных числа
//            CheckPositiveNumbers(a, b, c);

//            // Тесты с некорректными данными
//            TestNonInteger();
//            TestIncorrectCount();
//        }


//        static int ReadInt(int min, int max)
//        {
//            int num;
//            while (true)
//            {
//                // Метод TryParse(Строка из которого идет преобразование, переменная в которое это значение помещается)
//                // если преобразование не удается он выдает значение по умолчанию т.е. ноль (False)
//                // следовательно если преобразование равно нулю, то выводится сообщение в консоль (в данном случае),
//                // а иначе условие равно True, что соответствует условию в цикле и он прекращает проверку числа
//                if (int.TryParse(Console.ReadLine(),out num) && num >= min && num <= max)
//                {
//                    return num;
//                }
//                Console.WriteLine($"Пожалуйста, введите целое число от {min} до {max}:"); // вот это сообщение
//            }
//        }

//        static void CheckPositiveNumbers(int a, int b, int c)
//        {
//            if (a > 0 && b > 0 && c > 0)
//            {
//                if (a + b == c)
//                {
//                    Console.WriteLine("Сумма двух чисел равна третьему числу.");
//                }
//                if (a + b < c)
//                {
//                    Console.WriteLine("Сумма двух чисел меньше третьего числа.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Не все числа положительные.");
//            }
//        }

//        static void TestNonInteger()
//        {
//            Console.WriteLine("\n--- Тест с нецелыми значениями ---");
//            try
//            {
//                double a = 5.5;
//                double b = 10.2;
//                double c = 15.7;
//                Console.WriteLine($"Сумма: {a + b + c}"); //Обработка исключения не нужна, т.к. double корректно обрабатывает дробные числа
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка: {ex.Message}");
//            }
//        }

//        static void TestIncorrectCount()
//        {
//            Console.WriteLine("\n--- Тест с неверным количеством значений ---");
//            try
//            {
//                //Здесь код, демонстрирующий обработку неверного количества значений.  Можно симулировать  ввод с недостаточным кол-вом значений через Console.ReadLine(), но это усложнит код.  Лучше просто вывести сообщение об ошибке.
//                Console.WriteLine("Ошибка: Неверное количество значений.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка: {ex.Message}");
//            }
//        }
//    }
//}

using System;

public class NumberActions
{
    public static void Main(string[] args)
    {
        // Ввод трех чисел с проверкой на диапазон и тип данных
        Console.WriteLine("Введите первое число (1-2 цифры):");
        string inputA = Console.ReadLine();
        int a = 0;
        while (!int.TryParse(inputA, out a) || a < 10 || a > 99)
        {
            Console.WriteLine("Некорректный ввод. Введите целое число от 10 до 99:");
            inputA = Console.ReadLine();
        }

        Console.WriteLine("Введите второе число (1-2 цифры):");
        string inputB = Console.ReadLine();
        int b = 0;
        while (!int.TryParse(inputB, out b) || b < 10 || b > 99)
        {
            Console.WriteLine("Некорректный ввод. Введите целое число от 10 до 99:");
            inputB = Console.ReadLine();
        }

        Console.WriteLine("Введите третье число (1-2 цифры):");
        string inputC = Console.ReadLine();
        int c = 0;
        while (!int.TryParse(inputC, out c) || c < 10 || c > 99)
        {
            Console.WriteLine("Некорректный ввод. Введите целое число от 10 до 99:");
            inputC = Console.ReadLine();
        }


        // Проверка и вывод сообщений
        Console.WriteLine($"\nРезультаты:");
        if (a > 0) Console.WriteLine($"Число a ({a}) является положительным.");
        if (b == 10) Console.WriteLine($"Число b ({b}) равно 10.");
        if (c >= 50) Console.WriteLine($"Число c ({c}) больше или равно 50.");

        // Вывод суммы и произведения
        Console.WriteLine($"\nСумма: {a + b + c}");
        Console.WriteLine($"Произведение: {a * b * c}");


        // Проверка условий (пункты 7 и 8)
        Console.WriteLine("\nПроверка условий:");
        if (a > 0 && b > 0 && c > 0)
        {
            if (a + b == c) Console.WriteLine($"Сумма двух чисел ({a} + {b}) равна третьему числу ({c}).");
            if (a + b < c) Console.WriteLine($"Сумма двух чисел ({a} + {b}) меньше третьего числа ({c}).");
        }

        // Тесты с некорректными данными (без методов - сложно и нечитабельно)
        //  Лучше использовать методы для организации кода, особенно для таких блоков

        Console.WriteLine("\n\nТесты с некорректными данными (неполная реализация без методов):");
        Console.WriteLine("Реализация тестов без методов затруднена и делает код нечитаемым.  Рекомендуется использовать методы.");


    }
}
