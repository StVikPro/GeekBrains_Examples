//Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 345->4

Console.Clear();

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.WriteLine(MakeArray(number, count));



int ReadInt(string message)//Отображения в консоли и вывод результата введенных данных.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int a, int b)// Принимает число введенное пользователем, количество символов, и выводит третью цифру числа или же если третьей цифры нет пишет об этом.
{
int result = 0;
    if (b < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}