// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;
using static System.Console;
Clear();

Write("Введите 5 значное чило: ");
int num = Convert.ToInt32(ReadLine());

string numS = num.ToString();
char[] num2 = numS.ToCharArray();
string num3 = "";
int count = numS.Length;
int result = 0;
int count1 = numS.Length;
for (int i = 0; i < count; i++)
{
    num3 = num3 + num2[count1-1];
    Write(num3);
    Write(" ");
    count1--;
    result ++;
}
Write(numS==num3 ? $"{num} палиндром " : $"{num} не палиндром");

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