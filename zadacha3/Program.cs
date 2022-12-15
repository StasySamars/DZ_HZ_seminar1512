// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Рад Вас видеть! Как я могу к Вам обращаться? ");
string username = (Console.ReadLine());

Console.WriteLine(username + ", введите любое число и мы узнаем, четное оно или нет: ");
int Num1 = Convert.ToInt32(Console.ReadLine());

if (Num1%2 == 0)
Console.WriteLine(username + ", введенное Вами число, является четным! ");

else
Console.WriteLine(username + ", введенное Вами число, является НЕчетным!");

Console.WriteLine("Если хотите попробовать еще раз, просто введите команду dotnet run");