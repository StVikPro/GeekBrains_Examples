// Задача 6 Напишите программу, которая на вход принимет число
// и выдает, является ли число четным (делится ли оно на два 
// без остатка)
Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");