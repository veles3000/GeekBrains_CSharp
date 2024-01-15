

Console.Write(" Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Luba")
{
    Console.Write(" Привет! Моя Любовь!");
}
else
{
    Console.Write(" Привет! ");
    Console.WriteLine(username);
}