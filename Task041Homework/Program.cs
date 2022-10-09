/* Задача 41: Пользователь вводит с клавиатуры число M, потом 
вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 
ввёл пользователь.
5
0
7
8
-2
-2 -> 2
5
1
-7
567
89
223-> 3 */
 
Console.Clear();

Console.Write("Введите количество чисел для ввода и через ENTER введите числа: ");
 
int numberCount = int.Parse(Console.ReadLine()!);
int[] numberArray = new int[numberCount];
 
for (int i = 0; i < numberArray.Length; i++)
{
    numberArray[i] = int.Parse(Console.ReadLine()!);
}
 
//Console.WriteLine(CountPositiveNumbers(numberArray));
//Console.WriteLine($"В числе {num} число знаков равно {CountDigits(num)}");
Console.WriteLine($"Число чисел больше 0 = {CountPositiveNumbers(numberArray)}"); 
 
int CountPositiveNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    return counter;
}
