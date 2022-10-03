// Напишите программу, которая принимает на вход трехзначное
// число и на выходе показыват последнюю цифру этого числа
// 345->5   678->8 и т.д.
Console.WriteLine("Введите число: ");
int num = Math.Abs(int.Parse(Console.ReadLine()));//Math.Abs() - чтобы учесть и отрицательные
if((num<1000) & (num>99))
{
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("Число не соотвествует условию задачи");
}