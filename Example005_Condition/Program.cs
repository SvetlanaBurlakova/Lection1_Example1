// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Привет, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}