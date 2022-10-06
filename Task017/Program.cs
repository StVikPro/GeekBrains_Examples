// Задача 17 Напишите программу, которая принимает на вход координаты точки (X и Y)
//причем X и Y не равняются 0 и выдает номер четверти проскости,
// в которой находится эта точка
Console.Clear();

Console.Write("Введите Х:");// водим переменную Х
int X = int.Parse(Console.ReadLine()!);// считываем переменную Х (Parse что целочисленно)

Console.Write("Введите Y:");// водим переменную Х
int Y = int.Parse(Console.ReadLine()!);

if (X > 0) {// попадет в 1 и 4 четверть
    if (Y > 0) 
    {
        Console.WriteLine("1");
    } 
    else 
    {
        Console.WriteLine("4");
    }
}
else // попадем во 2 и 3 четверти
{
    if  (Y > 0)
    {
        Console.WriteLine("2");
    }
    else 
    {
        Console.WriteLine("3");
    }
}