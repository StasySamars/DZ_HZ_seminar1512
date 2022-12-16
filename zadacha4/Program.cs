// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Рад Вас видеть! Как я могу к Вам обращаться? ");
string username = (Console.ReadLine());

Console.WriteLine(username + ", введите любое число и мы узнаем, какие четные числа оно в себе хранит: ");
int Num1 = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < (Num1-1))
{
    i += 2;
    Console.WriteLine(i);
}

Console.WriteLine(username + ", Все четные числа входящие в число " + (Num1) + " найдены!");