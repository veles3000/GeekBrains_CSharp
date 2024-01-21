// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

using System;
using static System.Console;
Clear();


// НОВОЕ РЕШЕНИЕ
Write(" Введите координаты первой точки пробел ");
string[] p1 = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);// Ввод значений через пробел
int x1 = 0;
int y1 = 0;
int z1 = 0;
int x2 = 0;
int y2 = 0;
int z2 = 0;

if (p1.Length == 3)
{
    Write(" первые координаты приняты");
    x1 = int.Parse(p1[0]);
    y1 = int.Parse(p1[1]);
    z1 = int.Parse(p1[2]);
    WriteLine( );
}
else
{
    if (p1.Length > 3)
    {
        Write(" Слишком много знвчений возьмем первые 3");
        Write(" Перые координаты приняты");
        x1 = int.Parse(p1[0]);
        y1 = int.Parse(p1[1]);
        z1 = int.Parse(p1[2]);
            WriteLine( );
    }
    else
    {
        Write(" мало координат ");
    }
}
Write(" Введите координаты второй точки пробел ");
string[] p2 = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);// Ввод значений через пробел
if (p2.Length == 3)
{
    Write(" Вторые координаты приняты");
    x2 = int.Parse(p2[0]);
    y2 = int.Parse(p2[1]);
    z2 = int.Parse(p2[2]);
        WriteLine( );
}
else
{
    if (p2.Length > 3)
    {
        Write(" Слишком много знвчений возьмем первые 3");
        Write(" Вторые координаты приняты");
        x2 = int.Parse(p2[0]);
        y2 = int.Parse(p2[1]);
        z2 = int.Parse(p2[2]);
        WriteLine( );
    }
    else
    {
        Write(" мало координат ");
    }
}
Write($" растояние между точками {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))}");


// СТАРОЕ РЕШЕНИЕ
// Console.WriteLine("Введити координаты через пробел");
// string[] a1=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
// //Split- позволяет ввести все данные в одну строку
// //StringSplitOptions.RemoveEmptyEntries- уберает лишние разделитили
// int x1 = int.Parse(a1[0]);
// int y1 = int.Parse(a1[1]);
// int z1 = int.Parse(a1[2]);
// int x2 = int.Parse(a1[3]);
// int y2 = int.Parse(a1[4]);
// int z2 = int.Parse(a1[5]);

// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine($"Расстояние между точками: {result}");
