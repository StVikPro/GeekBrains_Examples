// Задача 18 Напишите программу, которая по заданному номеру 
//четверти, показывает диапазон возможных координат точек
// в этой четверти (X и Y)

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

switch(num)//своеобразный переключатесь случаев внутри которого много переключателей if else
{
    case 1://кейсы
        Console.WriteLine("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0, y < 0");
        break;
    default://нужен для того чтобы заменить esle во всем, если число не соотверствует 1 2 3 4
        Console.WriteLine("Введено не корректное число");
        break;
}

