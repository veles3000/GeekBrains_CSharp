// Напишите программу которая генерирует двухзначное число и выодит наибольшую цифру из него

using System;
using static System.Console;
Clear(); //очистить консоль ( Console.Clear(); )

// ПЕРВОЕ РЕШЕНИЕ
/*
int num = new Random().Next(10, 100);

int a1 = num / 10;
int a2 = num % 10;

if (a1 > a2)
{
    Write($"{num}->{a1}");
}
else
    Write($"{num}->{a2}");
*/


// ВТОРОЕ РЕШЕНИЕ

int num = new Random().Next(10, 100);

int a1 = num / 10;
int a2 = num % 10;

Write(a1 > a2 ?$"{num} -> {a1}": a1 < a2 ?$"{num} -> {a2}":$"{a1} равен {a2}");



// ТРЕТИЕ РЕШЕНИЕ
/*
int num = new Random().Next(10, 100);
string numS=num.ToString();

int a1 = Convert.ToInt32(numS[0].ToString());
int a2 = Convert.ToInt32(numS[1].ToString());

Write(a1 > a2 ? num + " -> " + a1: a1 < a2 ? num + " -> " + a2: a1 + " равен " + a2);
*/
