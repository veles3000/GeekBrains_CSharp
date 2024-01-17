// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;
using static System.Console;

Write(" Введите первое число: ");
int a = Convert.ToInt32(ReadLine());
Write(" Введите второе число: ");
int b = Convert.ToInt32(ReadLine());
Write(" Введите третье число: ");
int c = Convert.ToInt32(ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;

Write(max);