/* Задача (семинар 6) Напишите программу, которая принимает на вход
число и выдает количество цифр в числе.
Использовать рекурсию
456 -> 3
78 -> 2
89126 -> 5*/
Console.Clear();

int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В числе {num} число знаков равно {CountDigits(num)}");

int CountDigits(int number, int counter = 0)
{
    if (number / 10 == 0)
    {
        return counter + 1;
    }
    else
    {
       return counter +  CountDigits(number / 10) + 1;
    }
}