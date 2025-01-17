﻿// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример:
// 123 => 6
// 63 => 9

int SumDigits(int num) // 123, 12, 1
{    
    if (num == 0) return 0;
    return num % 10 + SumDigits(num / 10); //123, 12, 1
    // 1 % 1 => 1 + 12 % 10 => 2 + 123 % 10 => 3 = 1+2+3 = 6 + 0 
}

Console.WriteLine(SumDigits(63));