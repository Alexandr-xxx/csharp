﻿// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет
// количество чётных чисел в массиве.
// Пример:
// массив [6 7 19 34 3 1 4 7 9 1] => 3
// массив [1 8 43 4 55 60 3 2 1 3] => 4

int[] array = new int[] {6, 7, 19, 34, 3, 1, 4, 7, 9, 1};
// int[] array = new int[] {1, 8, 43, 4, 55, 60, 3, 2, 1, 3};
int quantity = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        quantity++;
    }
}
Console.Write($"Количество четных чисел в масиве равно:{quantity}");