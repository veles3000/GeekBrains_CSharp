﻿// 

using System;
using static System.Console;
Clear();

/*
// Метод первый 
void Method1() // void не возвращает значений
{
    WriteLine(" Автор ... ");

}
Method1();
*/

/*
// Метод 2
void Method2(string msg)
{
    WriteLine(msg);
}
Method2(" Текст сообщения ");
*/
/*
void Method21(string msg, int count)
{
    int i =0;
    while(i< count)
    {
        WriteLine(msg);
        i++;
    }
}
//Method21(" Текст ", 4);
Method21(count: 4, msg: " Новый текст ");
*/

/*
// Метод 3
int Method3()
{
return DateTime.Now.Year;
}

int year = Method3();
WriteLine(year);
*/

/*
// Метод 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while(i<count)
    {
        result= result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf ");
Write(res);
*/

/*
string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method41(10, "asdf ");
Write(res);
*/

/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        WriteLine($" {i} x {j} = {i*j}");
    }
    WriteLine(" ");
}
*/