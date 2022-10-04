// Задача 12 Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли второе число кратным первому.
// Если второе число не ркатно первому, то программа выводит
// остаток от деления.
Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (b % a == 0)
    Console.Write($"{a} кратное {b}");
else
    Console.WriteLine($"остаток {a % b}");
