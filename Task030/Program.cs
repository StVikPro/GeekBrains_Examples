/* Задача 30 Напишите программу, число, создает массив данного размера,
заполняет его нулями и единицами в случайном порядке и выводит его в консоль
8 ->[1,0,1,1,0,1,0,0] */
Console.Clear();

Console.Write("Введите размер массива: ");
int arrayLenght = int.Parse(Console.ReadLine()!);

int[] array = new int[arrayLenght];

FillArray(array);
PrintArray(array);


void FillArray(int[] array)
{
    Random randGeneration = new Random();
    for (int i = 0; i < arrayLenght; i++)
    {
        array [i] = randGeneration.Next(0, 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < arrayLenght; i++)
    {
        Console.Write($"{array[i]} ");
    }
}