// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;
using static System.Console;
Clear();

int k = int.Parse(ReadLine());
Console.WriteLine(string.Join(" ",Array(k)));

int[] Array(int l)
{
    int[] arr = new int[l];
    for(int i=0; i<l; i++)
    {
        arr[i] = new Random().Next(100);
    }
    return arr;
}