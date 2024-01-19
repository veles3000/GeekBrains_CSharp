// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using System;
using static System.Console;
Clear();

/*
// НОВОЕ РЕШЕНИЕ
Write(" Введите число которое обозначает день недели: ");
int num = Convert.ToInt32(ReadLine());

WriteLine(num<1?$" Такого дня недели не бывает":num>8?$" Такого дня недели не бывает":num==6||num==7?$" Выходной ":$" Рабочий день ");
*/


// Старое решение
int n;
Console.Write(" Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    if (n < 8)
    {
        Console.WriteLine(n == 6 ? " Выходной " : n == 7 ? " Выходной " : " Рабочий ")ж
    }
    else
    {
        Console.WriteLine(" не найден номер дня недели ")
    }
}
else
{
    Console.WriteLine(" не найден номер дня недели ")
}