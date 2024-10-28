﻿// Задание 2: Замена элементов массива
// Описание: Задайте массив из 10 элементов, заполненный числами от -10 до 10.
// Замените отрицательные числа на их абсолютные значения, а положительные числа
// на их отрицательные эквиваленты.

int[] array = new int[10] { 6, -2, 4, -8, -3, 9, -5, 3, 0, -10 };

for (int i = 0; i < array.Length; i++)
{
    array[i] *= -1;
}

foreach (int numArray in array)
{
    Console.Write($"{numArray}, ");
}