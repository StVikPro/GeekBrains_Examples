// Задача 8 Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от 1 до N
Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int counter = 2;

while (n > counter)
{
    Console.Write($"{counter} ");
    counter += 2;
}
