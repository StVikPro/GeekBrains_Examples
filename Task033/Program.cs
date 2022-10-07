/* Задача 33 Задайте массив. Напишите программу, которая определяет,
присутствует ли данное число в массиве
4; массив [6,7,19,345,3] -> нет
-3; массив [6,7,19,345,3] -> да */
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int [] array = new int[10];

FillArray(array);
PrintArray(array);

if (FindNumberInArray(array, num))
    Console.Write($"число {num} присутсвтвует в массиве");
else
    Console.Write($"число {num} отсутсвтвует в массиве");

    bool FindNumberInArray(int[] array, int num)
{
    for (int i = 0; i <10; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}

void FillArray(int[] array)
{
    Random randGeneration = new Random();
    for (int i =0; i <10; i++)
    {
        array[i] = randGeneration.Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
            Console.Write("]");
        else
            Console.Write(", ");
    }
}
