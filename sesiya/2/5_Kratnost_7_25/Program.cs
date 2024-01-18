// Написать програму которая принимает число и проверяет кратно ли он 7 и 25

using System;
using static System.Console;
Clear();

//int num = new Random().Next(34,36);
Write(" Введите число: ");
int num = Convert.ToInt32(ReadLine());

//Write((num%7==0&&num%35==0?$"{num} кратно ":$"{num} не кратно"));
Write((num%35==0?$"{num} кратно 35 ":num%7==0?$"{num} кратно 7":$"{num} не кратно"));
