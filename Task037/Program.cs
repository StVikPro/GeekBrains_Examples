/* Задача 37 Найдите произвеение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и последний элемент и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 583
[6 7 3 6] -> 3621 */
Console.Clear();

int[] CreateArray()
{
    int[] array = new int [new Random().Next(10,12)];
    return array;
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 11);
        index ++;
    }
}

int[] Multiply(int[] array)
{
    int[] result;

    if (array.Length % 2 == 0)
    {
        result = new int [array.Length / 2];
    }
    else
    {
        result = new int [array.Length / 2 + 1];
    }
    for (int i = 0; i < result.Length; i++)
    {
        if (i == array.Length -1 - i)
        {
           result[i] = array[i]; 
        }
        else
        {
            result[i] = array[i] * array[(array.Length - 1) - i];
        }
    }
    return result;
}

int[] array = CreateArray();
FillArray(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine();
Console.WriteLine(String.Join(", ", Multiply(array)));