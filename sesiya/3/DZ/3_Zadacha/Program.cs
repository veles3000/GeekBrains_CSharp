// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;
using static System.Console;
Console.Clear();

Console.Write("Введитее любое чило: ");
int number = int.Parse(ReadLine());
for(int N = 1; N <= number; N++)
{
    Console.Write($"{N*N*N}, ");
}