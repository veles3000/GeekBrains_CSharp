// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
using static System.Console;

Write(" Введите число: ");
int a = Convert.ToInt32(ReadLine());

int i = 1;
while (i <= a)
{
    if (i%2 == 0) Write($"{i} ");
    i++;
}