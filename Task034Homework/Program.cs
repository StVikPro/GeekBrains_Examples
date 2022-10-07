/* Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
Console.Clear();

int[] array = new int[8];

Random randomGenerator = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randomGenerator.Next(100, 1000);
}

int countOfEven = CountEver(array);

Console.WriteLine(string.Join(" ", array));
Console.WriteLine(countOfEven);



int CountEver(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 ==0)
            counter++; 
    }
    return counter;
}