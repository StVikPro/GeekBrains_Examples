//Задача 15: Напишите программу, которая принимает на вход 
//цифру, обозначающую день недели, и проверяет, является ли 
//этот день выходным. 6 -> да, 7 -> да, 1 -> нет

Console.Clear();

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)// Принимает сообщение которое отображать в косоли, и выводит результат введенных данных.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)// Функция принимает число от 1 до 7 и выводит сообщение - является ли день выходным или нет.
{
    if (a > 0 && a < 8)// && - логическое И выполнение обоих условий
    {
        if (a == 7 || a == 6)
        {
            Console.Write(+ a + " - Выходной");
        }
        else
        {
            Console.Write(+ a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели не верное число, невозможно определить");
    }
    return " день.";
}