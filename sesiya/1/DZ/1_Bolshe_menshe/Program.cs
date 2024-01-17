// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

using System;
using static System.Console;

Write(" Введите первое число: ");
int a = int.Parse(ReadLine());
Write(" Введите второе число: ");
int b = Convert.ToInt32(ReadLine());

if (a > b) WriteLine($" Первое число ({a}) больше второго ({b})");
if (a < b) WriteLine($" Второе число ({b}) больше первого ({a})");
if (a == b) WriteLine($" Числа {a} и {b} равны");