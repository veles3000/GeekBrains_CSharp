//

using System;
using static System.Console;
Clear();

// 5! = 5*4*3*2*1

double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1 || n == 0) return 1;
    else return n * Factorial(n-1);

}


for (int i = 1; i < 40; i++)
{
    WriteLine($"{i} - {Factorial(i)}");
}
