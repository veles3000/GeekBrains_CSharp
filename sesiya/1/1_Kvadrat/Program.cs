// возведение в квадрат

using System; // подключаем библиотеку System
using static System.Console; // говорим использовать консоль по умолчанию

Write(" Введите число: ");
int number = int.Parse(ReadLine()); //считываем консоль и переводим строку в число
int sqr = number * number;
WriteLine($" Результат = {sqr} "); // $ позволяет выводить смешаный вывод (Форматирование строки)
// WriteLine($" Результат = " + sqr);

/*
Console.Write(" Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(A * A);
*/
