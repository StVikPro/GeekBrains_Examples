//Напишите программу, которая на вход принимает два числа
//и проверяет, является ли первое число квадратом второго
//а=25, в=5 - да
//Напишите программу, которая будет выдавать название дня недели по заданному номеру 3 - среда 5 - пятница
Console.WriteLine("Введите число 1: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("Введите число 2: ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
if(number2 * number2 == number1)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}
