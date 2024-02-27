//

using System;
using static System.Console;
Clear();

int[] array = GetArray(12, 9, -9);
WriteLine(String.Join(" ", array));

for (int i = 0; i < array.Length; i++)
{
    array[i]=array[i]*-1;
    Write($"{array[i]} ");
}


int[] GetArray(int size, int maxValue, int minValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
