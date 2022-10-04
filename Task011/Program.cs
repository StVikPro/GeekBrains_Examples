// Задача 11 Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

int firstDigit = number / 100; //поиск первого числа
int lastDigit = number % 10; //остаток второе число

Console.WriteLine((firstDigit * 10) + lastDigit);
