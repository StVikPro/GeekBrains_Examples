/* Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

//Odd - это будут нечетные позиции
Console.Clear();

int[] array = CreateArray(5);

int countOFEven = CountEver(array);
int sumOfOddIndex = OddIndexSum(array);

Console.WriteLine(string.Join(" ", array));
Console.WriteLine(sumOfOddIndex);


int[] CreateArray(int length)
{
    int[] array = new int[length];

    Random rendGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rendGenerator.Next(-10,10);
    }
    return array;
}


int CountEver(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
            counter++; 
    }
    return counter;
}

int OddIndexSum(int[] array)//Odd - нечетные
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
        if (i % 2 !=0)
        sum += array[i];
   } 
   return sum;
}