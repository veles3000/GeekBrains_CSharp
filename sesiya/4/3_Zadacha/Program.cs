// посчитать кольчество цифр в числе

using System;
using static System.Console;
Clear();

Write(" Введите число: ");
int A = int.Parse(ReadLine());


WriteLine(KolCifra(A));
int KolCifra(int number)
{
    int i=0;
    while (number>0)
    {
        i++;
        number/=10;
    }
    return i;
}
