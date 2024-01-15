// Проверка является первое число квадратом второго

using System;
using static System.Console;

Write(" Введите первое число: ");
int numberA = int.Parse(ReadLine());
Write(" Введите второе число: ");
int numberB = int.Parse(ReadLine());

if (numberA / numberB == numberB)
{
    WriteLine($" Первое число ({numberA}) является квадратом второго ({numberB})");
}
else
{
    WriteLine($" Первое число ({numberA}) не является квадратом второго ({numberB})");
}