// напишите программу котороя принемает 2 числа и говорит кратны они или нет

using System;
using static System.Console;
Clear();

/*
// ПЕРВОЕ РЕШЕНИЕ
int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);

if (num1 % num2 == 0)
{
Write($" {num1} и {num2} кратны ");
}
else
if(num2 % num1 == 0) 
{
Write($" {num2} и {num1} кратны ");
}
else
Write($" {num1} и {num2} не кратны, остаток {num1 % num2} ");
*/

/*
// ВТОРОЕ РЕШЕНИЕ
int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);

Write(num1 % num2 == 0 ? $"{num1} и {num2} кратны " : num2 % num1 == 0 ? $" {num2} и {num1} кратны " : $" {num1} и {num2} не кратны, остаток {num1 % num2} ");
*/

