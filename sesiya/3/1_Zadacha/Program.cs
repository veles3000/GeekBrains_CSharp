// Напишите программу которая по номеру выводи четверть

using System;
using static System.Console;
Clear();

/**/
//
Write(" Введите число: ");
int num = Convert.ToInt32(ReadLine());

switch (num)
{
    case 1:
    {
        WriteLine(" X>0 Y>0");
        break;
    }
        case 2:
    {
        WriteLine(" X<0 Y>0");
        break;
    }
        case 3:
    {
        WriteLine(" X<0 Y<0");
        break;
    }
        case 4:
    {
        WriteLine(" X>0 Y<0");
        break;
    }
    default:
    {
        Console.WriteLine(" Число не соответствут ");
        break;
    }
}
