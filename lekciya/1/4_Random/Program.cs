// Сумма рандомных чисел

int NumberA = new Random().Next(1, 10); // Генерируем случайное число от 1 до 9
Console.WriteLine(NumberA); // выводим полученое число
int NumberB = new Random().Next(1, 10); // генерируем второе случайное число от 1 до 9
Console.WriteLine(NumberB); // Выводим второе число
int result = NumberA + NumberB; // Складываем числа
Console.Write(" Сумма = "); // Выводим Сумма =
Console.WriteLine(result); // Выводим значение параметра result
