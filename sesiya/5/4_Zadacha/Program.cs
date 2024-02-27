//

using System;
using static System.Console;
Clear();

int[] array = GetArray(12, 499, 599);
int num = 532;
WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

WriteLine(FindNum(array, num)? "yes": "no");
bool FindNum(int[] array, int num)
{
    foreach (int el in array)
    {
        if (el==num)
        {
            return true;
        }
    }
    return false;
}