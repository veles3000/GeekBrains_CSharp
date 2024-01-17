// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;
using static System.Console;

Write(" Введите число: ");
int a = Convert.ToInt32(ReadLine());

if (a%2 == 0) Write(" да ");
if (a%2 != 0) Write(" нет ");