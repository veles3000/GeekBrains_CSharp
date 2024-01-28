// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using System;
using static System.Console;
Clear();

Write(" Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteLine(Summa(number));

int Summa(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

