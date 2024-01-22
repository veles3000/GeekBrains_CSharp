﻿//

using System;
using static System.Console;
Clear();
/*
string[,] table = new string[2, 5];
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
table[1, 2] = " Слово ";


for (int rown = 0; rown < 2; rown++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        WriteLine($"-{table[rown, columns]}-");
    }
}
*/

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Write($"{matr[i, j]} ");
        }
        WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
WriteLine();
PrintArray(matrix);