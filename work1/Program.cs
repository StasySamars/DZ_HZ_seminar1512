//Семинар
// 1 вариант записи

//Console.Clear(); при запуске программы, очистин консоль


//Console.Write("Введите число: ");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Квадрат " + Convert.ToString(a) + "=" + (a * a));

// int number = Convert.ToInt32(Console.ReadLine()); можно использовать вместо int.Parse

// второй вариант записи
Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Квадрат {a} = {a * a}");