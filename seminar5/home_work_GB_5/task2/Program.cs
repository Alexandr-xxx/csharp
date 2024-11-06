﻿// Задание 2: Поиск суммы элементов в каждом столбце
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// находит сумму элементов в каждом столбце массива и выводит её.
// Пример входных данных:
// 1 2 3
// 4 5 6
// 7 8 9
// 10 11 12
// Пример результата:
// Сумма элементов в столбце 0: 22
// Сумма элементов в столбце 1: 26
// Сумма элементов в столбце 2: 30

int[,] CreateMatrixIntRnd(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void ShowArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine();
    }
}

void GetSumElementIncolumnMatrix(int[,] matrix)
{    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i,j];
        }
        Console.Write($"Сумма элементов в столбце {j}: {sum}");
        Console.WriteLine();
    }
    
}

int[,] array2d = CreateMatrixIntRnd(3, 5, -10, 10);
ShowArray(array2d);
GetSumElementIncolumnMatrix(array2d);