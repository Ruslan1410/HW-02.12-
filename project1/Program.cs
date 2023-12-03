// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода: ");
            string input = Console.ReadLine();

            // Проверка на выход по символу 'q'
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            // Попытка преобразовать введенную строку в целое число
            if (int.TryParse(input, out int number))
            {
                // Проверка на сумму цифр числа
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} четная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {number} нечетная.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    }

    // Метод для проверки четности суммы цифр числа
    static bool IsSumOfDigitsEven(int number)
    {
        int sum = 0;
        // Получаем каждую цифру числа и суммируем их
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        // Проверяем четность суммы
        return sum % 2 == 0;
    }
}