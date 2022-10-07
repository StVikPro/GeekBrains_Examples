/* Задача 35 Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в 
отрезке [10,99]. (Пример для массива 5 элементов [5,18,123,6,2] -> 1)
[10,11,12,13,14 -> 5]
 */
 Console.Clear();
 int[] array = new int[123];
 FillArray(array);
 int c = GetCount(array);
 Console.WriteLine($"Количество элементов от 10 до 99 равно {c} ");

 int GetCount(int[] arr)
 {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        count ++;
    }
    return count;
 }

void FillArray(int[] array)
{
    Random rendGeneration = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rendGeneration.Next(0, 201);
    }
}