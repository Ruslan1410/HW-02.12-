// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
using System;

class Program
{
    static void Main()
    {
        // Пример массива
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Переворачиваем массив
        ReverseArray(array);

        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    // Метод для переворота массива
    static void ReverseArray(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            // Обмениваем элементы с обоих концов массива
            int temp = array[i];
            array[i] = array[length - 1 - i];
            array[length - 1 - i] = temp;
        }
    }

    // Метод для вывода массива
    static void PrintArray(int[] array)
    {
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}