// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

Console.Clear();
Console.Write("Привет. Как тебя зовут? ");
string username = (Console.ReadLine());

Console.WriteLine(username + ", введи первое любое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(username + ", введи второе любое число:");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1 < Num2)
{
    Console.WriteLine($"Максимальное значение = {Num2} , Минимальное значение = {Num1} ");

}
else
{
    Console.WriteLine($"Минимальное значение = {Num1} , Максимальное значение = {Num2} ");

}

Console.WriteLine(username + ", Вы восхитительны!)");