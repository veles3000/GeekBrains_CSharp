// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;
using static System.Console;
Clear();

/*
// НОВОЕ РЕШЕНИЕ
Write(" Введите первое число: ");
int num = Convert.ToInt32(ReadLine());

string numS = Convert.ToString(num);
Write(numS[1]);
*/


// СТАРОЕ РЕШЕНИЕ
int a1;
Console.Write("Введите трех значное число: ");
a1 = Convert.ToInt32(Console.ReadLine());
if (a1 > 99)
{
    if (a1 < 1000)
    {
        a1 = a1 / 10;
        int result = a1 % 10;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine(" Число не соответствует критерию ");
    }
}
else
{
    if (a1 < -99)
    {
        if (a1 > -1000)
        {
            a1 = a1 / 10;
            int result = a1 % 10;
            Console.WriteLine(-result);
        }
        else
        {
            Console.WriteLine(" Число не соответствует критерию ");
        }
    }
    else
    {
        Console.WriteLine(" Число не соответствует критерию ");
    }
}