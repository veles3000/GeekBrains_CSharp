// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;
using static System.Console;
Clear();

Console.Write("Введите 5 значное чило: ");
int a = Convert.ToInt32(Console.ReadLine());



Write(a);




/*
//Старое решение
Console.Write("Введите 5 значное чило: ");
int a = Convert.ToInt32(Console.ReadLine());
string b = a.ToString();
char[] c = b.ToCharArray();
Array.Reverse(c);
b = new String(c);
string d = a.ToString();
Console.WriteLine(a<10000 || a>99999?"число не соответствует": d==b? "палиндром":"не палиндром");

// Как можно сделать, чтобы програма воспринимала 00900 как палиндром?
*/