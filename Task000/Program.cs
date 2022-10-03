//Напишите программу, которая на вход принимает число и выдает
//его квадрат (число умножает на само себя)
//Вариант 1
//Console.Clear();
//Console.WriteLine("Введите число: ");
//string input = Console.ReadLine();
//int number = int.Parse(input);
//Console.WriteLine(number*number);
//Вариант 2
Console.Clear();

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

int  sqr = number * number;
int  sqr2 = (int)Math.Pow(number,2);//(int) - в скобках перед присваивает значение Инт переменной
Console.WriteLine(sqr);
Console.WriteLine(sqr2);