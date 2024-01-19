// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using System;
using static System.Console;
Clear();

/*
// Новое решение
Write(" Введите первое число: ");
int num = Convert.ToInt32(ReadLine());

string numS = Convert.ToString(num);
Write(numS.Length > 2?numS[2]:$" В числе {num} нет третьего символа");
*/


// СТАРОЕ РЕШЕНИЕ
int n;
Console.Write(" Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(n>99?n.ToString()[2]:n<-99?n.ToString()[3]: " нет третьего элемента");