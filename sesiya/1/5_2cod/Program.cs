// Написать программу которая принимает число и выводит первое и последние число

using System;
using static System.Console;


Write(" Введите число: ");
int num = Convert.ToInt32(ReadLine());
int X=num/10;
int Y=num%10;

Write($"x={X} y={Y}");

