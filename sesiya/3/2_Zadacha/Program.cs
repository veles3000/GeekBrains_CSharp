//

using System;
using static System.Console;
Clear();

/**/
//
Write(" X = ");
int X = Convert.ToInt32(ReadLine());
Write(" Y = ");
int Y = Convert.ToInt32(ReadLine());

WriteLine(X>0&&Y>0?"1": X < 0&& Y>0?" 2 ": X<0&&Y<0?" 3 ":X>0&&Y<0?" 4 ": " нет таких координат");
