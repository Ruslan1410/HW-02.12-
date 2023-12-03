// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int arraySize = 10; // Можете изменить размер массива по вашему усмотрению

        // Создаем массив случайных трехзначных чисел
        int[] randomNumbers = GenerateRandomNumbers(arraySize);

        // Выводим массив
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(randomNumbers);

        // Получаем количество четных чисел
        int evenCount = CountEvenNumbers(randomNumbers);

        // Выводим результат
        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    // Метод для генерации случайных трехзначных чисел
    static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        return numbers;
    }

    // Метод для вывода массива
    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    // Метод для подсчета четных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int evenCount = 0;

        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        return evenCount;
    }
}