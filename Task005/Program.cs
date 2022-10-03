// Напишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = -1 * num;

while(count <= num)
{
    Console.Write($"{count} ");
    count ++;
}

