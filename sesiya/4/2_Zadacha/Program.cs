// 

using System;
using static System.Console;
Clear();

Write(" Введите А: ");
int A=int.Parse(Console.ReadLine());
WriteLine(Summa(A));

int Summa(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}
