// Данны 2 числа вывести равны ли суммы цифр этих чисел

using System;
using static System.Console;
Clear();

int num1 = new Random().Next(100,1000);
int num2 = new Random().Next(100,1000);

Write($" {num1} {num2} ");

int sum1 = 0;
int sum2 =0;
while (num1 > 0)
{
    sum1 = sum1 + (num1%10);
    num1 = num1/10;
}


while(num2 > 0)
{
    sum2 = sum2 + (num2%10);
    num2 = num2/10;    
}

Write(sum1==sum2?$"Суммы {sum1} и {sum2} равны ":$" Суммы {sum1} и {sum2} не равны");