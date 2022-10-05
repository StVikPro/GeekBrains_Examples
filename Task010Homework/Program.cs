//Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа 456 -> 5
Console.Clear();

int number = ReadInt("Введите трехзначное число: ");
int total = number.ToString().Length;

if (total < 3 || total > 3)// total - итоговае число
{
    Console.WriteLine("Введенеое число не является трехзначиным");
}
else
{
    Console.WriteLine(InCenter(number));
}



// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем. 
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вывода цифры стоящей в середине трехзначногно числа.
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}