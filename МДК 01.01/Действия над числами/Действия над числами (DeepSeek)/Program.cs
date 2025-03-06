//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Действия_над_числами__DeepSeek_
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                // Ввод трех целых чисел
//                Console.WriteLine("Введите три целых числа (каждое число от 1 до 99):");

//                int a = ReadNumber("Введите число a: ");
//                int b = ReadNumber("Введите число b: ");
//                int c = ReadNumber("Введите число c: ");

//                // Проверка условий и вывод сообщений
//                CheckConditions(a, b, c);

//                // Вывод суммы и произведения
//                Console.WriteLine($"Сумма чисел: {a + b + c}");
//                Console.WriteLine($"Произведение чисел: {a * b * c}");

//                // Проверка на сумму двух чисел равную третьему
//                CheckSumEqualsThird(a, b, c);

//                // Проверка на сумму двух чисел меньше третьего
//                CheckSumLessThanThird(a, b, c);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка: {ex.Message}");
//            }
//        }

//        static int ReadNumber(string prompt)
//        {
//            Console.Write(prompt);
//            string input = Console.ReadLine();
//            if (!int.TryParse(input, out int number) || input.Length < 1 || input.Length > 2)
//            {
//                throw new Exception("Неверный ввод. Число должно быть целым и содержать 1 или 2 цифры.");
//            }
//            return number;
//        }

//        static void CheckConditions(int a, int b, int c)
//        {
//            if (a > 0)
//                Console.WriteLine("Число a является положительным.");
//            else
//                Console.WriteLine("Число a не является положительным.");

//            if (b == 10)
//                Console.WriteLine("Число b равно 10.");
//            else
//                Console.WriteLine("Число b не равно 10.");

//            if (c >= 50)
//                Console.WriteLine("Число c больше или равно 50.");
//            else
//                Console.WriteLine("Число c меньше 50.");
//        }

//        static void CheckSumEqualsThird(int a, int b, int c)
//        {
//            if (a > 0 && b > 0 && c > 0)
//            {
//                if (a + b == c || a + c == b || b + c == a)
//                    Console.WriteLine("Сумма двух чисел равна третьему числу.");
//                else
//                    Console.WriteLine("Сумма двух чисел не равна третьему числу.");
//            }
//        }

//        static void CheckSumLessThanThird(int a, int b, int c)
//        {
//            if (a > 0 && b > 0 && c > 0)
//            {
//                if (a + b < c || a + c < b || b + c < a)
//                    Console.WriteLine("Сумма двух чисел меньше третьего числа.");
//                else
//                    Console.WriteLine("Сумма двух чисел не меньше третьего числа.");
//            }
//        }
//    }
//}

using System;

public class NumberActions
{
    public static void Main(string[] args)
    {
        // Ввод трех чисел
        Console.WriteLine("Введите первое число (1-2 цифры):");
        int a = ReadNumber(10, 99);  // Ограничение на 1-2 цифры

        Console.WriteLine("Введите второе число (1-2 цифры):");
        int b = ReadNumber(10, 99);

        Console.WriteLine("Введите третье число (1-2 цифры):");
        int c = ReadNumber(10, 99);


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


        // Тесты с некорректными данными
        TestIncorrectInput();
        TestNonIntegerInput();
    }

    // Вспомогательная функция для чтения числа с проверкой диапазона
    static int ReadNumber(int min, int max)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int num) && num >= min && num <= max)
            {
                return num;
            }
            else
            {
                Console.WriteLine($"Пожалуйста, введите целое число от {min} до {max}:");
            }
        }
    }


    static void TestIncorrectInput()
    {
        Console.WriteLine("\n\nТест: Неверное количество значений");
        try
        {
            // Попытка обработки некорректного количества значений (например, только два числа)
            string[] input = Console.ReadLine().Split(' '); // Предполагается разделение пробелами
            if (input.Length != 3)
            {
                Console.WriteLine("Ошибка: Необходимо ввести три числа.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка во время обработки теста: {ex.Message}");
        }
    }


    static void TestNonIntegerInput()
    {
        Console.WriteLine("\n\nТест: Нецелые значения");
        try
        {
            // Попытка обработки нецелых значений
            Console.WriteLine("Введите три числа через пробел (с нецелыми значениями):");
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length == 3)
            {
                double a = double.Parse(input[0]);
                double b = double.Parse(input[1]);
                double c = double.Parse(input[2]);

                if (!a.Equals((int)a) || !b.Equals((int)b) || !c.Equals((int)c))
                {
                    Console.WriteLine("Ошибка: Введены нецелые значения.");
                }
                else
                {
                    Console.WriteLine("Сумма чисел: " + (a + b + c));
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Необходимо ввести три числа.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка во время обработки теста: {ex.Message}");
        }
    }
}
