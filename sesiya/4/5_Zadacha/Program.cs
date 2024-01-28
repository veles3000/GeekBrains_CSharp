// сгенерировать массив

using System;
using static System.Console;
Clear();

int[] arr = new int[8];


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        Write($" {array[i]} ");
    }
    WriteLine();
}

SelectionSort(arr);
