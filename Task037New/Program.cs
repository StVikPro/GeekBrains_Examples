/* Задача 37 Напишите метод, который обьеденяет 2 массива в 1.
[5,18,123,6,2]+[1,2,3]=[5,18,123,6,2,1,2,3] */
Console.Clear();

int[] ParseToArray(string str1, string str2)
{
   string str = str1 + ' ' + str2;
   string[] stringArray = str.Split(" ");
   int[] result = new int[stringArray.Length];

   for (int i = 0; i < stringArray.Length; i++)
   {
        result[i] = int.Parse(stringArray[i]);
   }
   return result;
}

Console.Write("Введите числа первого массива через пробел: ");
string firstdArray = Console.ReadLine()!;

Console.Write("Введите числа второго массива через пробел: ");
string secondArray = Console.ReadLine()!;

int[] newArray = ParseToArray(firstdArray, secondArray);

Console.WriteLine(String.Join(", ", newArray));