// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using System;
using static System.Console;
Clear();


// Новое решение
Write(" Введите число: ");
int A = Convert.ToInt32(ReadLine());
Write(" Введите степень: ");
int B = int.Parse(ReadLine());

void Stepen(int Chis, int step)
{
   WriteLine(Math.Pow(A,B));
}
Stepen(A,B);


/*
// Старое решение
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
int i = 0;
int C = 1;
while (i<B)
{
    C=C*A;
    i++;
}
Console.WriteLine(C);
*/