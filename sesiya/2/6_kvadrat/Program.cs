// написать программу которая принимает 2 числа и выдает является ли одно из них квадратом второго

using System;
using static System.Console;
Clear();

Write(" Введите первое число: ");
int num1 = Convert.ToInt32(ReadLine());
Write(" Введите второе число: ");
int num2 = Convert.ToInt32(ReadLine());

// int num1 = new Random().Next(1,100);
// int num2 = new Random().Next(1,100);

Write(num1/num2==num2?$"{num1} является квадратом {num2} ":num2/num1==num1?$"{num2} является квадратом {num1} ":$" Числа {num1} и {num2} не являются квадратом");