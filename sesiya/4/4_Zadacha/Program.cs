// произведение от 1 до т

using System;
using static System.Console;
Clear();

Write(" Введите число: ");
int N = int.Parse(ReadLine());

WriteLine(Factorial(N));

int Factorial(int number)
{
    int proisvedenie = 1;
    for (int i = 1; i <= number; i++)
    {
        proisvedenie *= i;
    }
    return proisvedenie;
}