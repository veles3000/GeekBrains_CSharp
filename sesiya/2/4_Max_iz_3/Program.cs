// Найти максимум из 3 чисел

using System;
using static System.Console;
Clear();

int a = 22;
int b = 5;
int c = 5;

//int max = (a >= b && a >= c) ? a : (b >= a && b >= c) ? b : (c >= a && c >= b) ? c :a;


// ПЕРВОЕ РЕШЕНИЕ
Write(a >= b && a >= c ? a : b >= a && b >= c ? b : c >= a && c >= b ? c : a);


/*
// ВТОРОЕ РЕШЕНИЕ
int max = (a > b && a > c) ? a : (b > a && b > c) ? b : c;
*/

/*
// ТРЕТИЕ РЕШЕНИЕ
if (a > b && a > c)
{
    Write(a);
}
else
if ((b > a && b > c)
{
    Write(b);
}
else
    Write(c);
*/