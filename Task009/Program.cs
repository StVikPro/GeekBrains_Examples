// Задача 9 Напишите программу, которая выводит случайное число 
// из отрезка [10,99] и показывает наибольшую цифру числа
Console.Clear();

int number = new Random().Next(10,100);// генерируем число оператором

Console.WriteLine(number);//выводим
//Далее разбиваем числа на цифры первое и второе
int firstDigit = number % 10; //поиск младшего разряда числа это остаток от деления на 10
int lastDigit = number/10; //остаток 

if (firstDigit > lastDigit)
    Console.WriteLine(firstDigit);
else 
    Console.WriteLine(lastDigit);
