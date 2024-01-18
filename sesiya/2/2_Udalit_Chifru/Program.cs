// Написать программу котора принимает на вход трехзначное число и удаляет средний элемент

using System;
using static System.Console;
Clear(); //очистить консоль ( Console.Clear(); )
/*
Write(" Введите число: ");
int num = Convert.ToInt32(ReadLine());

int a = num / 100;
int b = num % 10;

if (num > 99)
{
    if (num < 1000)
    {
        Write($"{a}{b}");
    }
    else
        Write(" Не соответствует критерию! ");
}
else
    Write(" Не соответствует критерию! ");
*/

/*
int num = new Random().Next(100,1000);
int a = num / 100;
int b = num % 10;

Write($"{num} -> {a}{b}");
*/

int num = new Random().Next(100,1000);
string numS = num.ToString();
int a1 = Convert.ToInt32(numS[0].ToString());
int a2 = Convert.ToInt32(numS[1].ToString());
Write($"{num} -> {a1}{a2}");