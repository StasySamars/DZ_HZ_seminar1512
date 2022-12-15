// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();
Console.Write("Привет. Как тебя зовут? ");
string username = (Console.ReadLine());

Console.WriteLine(username + ", введи первое любое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(username + ", введи второе любое число:");
int Num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(username + ", введи третье любое число:");
int Num3 = Convert.ToInt32(Console.ReadLine());

if (Num1 > Num2)
{
    if (Num1 > Num3)
    {
        Console.WriteLine($"Максимальное значение = {Num1} ");
    }
    else
    {
        Console.WriteLine($"Максимальное значение = {Num3} ");
    }
}
else if (Num2 > Num3)
{

    Console.WriteLine($"Максимальное значение = {Num2} ");
}
else
{
    Console.WriteLine($"Максимальное значение = {Num3} ");
}


Console.WriteLine(username + ", Вы восхитительны!)");