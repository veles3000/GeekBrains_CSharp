//

using System;
using static System.Console;
Clear();

// Write(" Введите X1 ");
// double x1 = Convert.ToInt32(ReadLine());
// Write(" Введите Y1 ");
// double y1 = Convert.ToInt32(ReadLine());
// Write(" Введите X2 ");
// double x2 = Convert.ToInt32(ReadLine());
// Write(" Введите Y2 ");
// double y2 = Convert.ToInt32(ReadLine());

// double a = (x1 - x2) * (x1-x2);
// double b = (y1-y2)*(y1-y2);
// double c= Math.Sqrt(Math.Pow((x1 - x2),2)+Math.Pow((y1-y2),2));

// WriteLine(Math.Sqrt(Math.Pow((x1 - x2),2)+Math.Pow((y1-y2),2)));


Write(" Введите переменные через пробел ");
string[] p1 = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);// Ввод значений через пробел

int x1 = int.Parse(p1[0]);
int y1 = int.Parse(p1[1]);
int x2 = int.Parse(p1[2]);
int y2 = int.Parse(p1[3]);

WriteLine($" X1={x1} Y1={y1} X2={x2} Y2={y2}");
WriteLine(Math.Sqrt(Math.Pow((x1 - x2),2)+Math.Pow((y1-y2),2)));

