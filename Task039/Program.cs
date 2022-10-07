/* Задача 39 Напишите программу, которая перевернет одномерный
массив (последний элемент будет на первом месте, а первый на
последнем и так далее
[1 2 3 4 5] -> [5 4 3 2 1])
[6 7 3 6] -> [6 3 7 6] */
Console.Clear();

int[] ParseToArray(string str)
{
    string[] stringArray = str.Split(" ");
    int[] result = new int[stringArray.Length];

    for (int i = 0; i < stringArray.Length; i++)
    {
       result[i] = int.Parse(stringArray[i]);
    }
    return result;
}

int[] Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int c = array [i];
        array [i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = c;
    }
    return array;
}

Console.Write("Введите элемент массива через пробел: ");
string array = Console.ReadLine()!;

int[] newArray = ParseToArray(array);
int[] newNewArray = Reverse(newArray);

Console.WriteLine(String.Join(", ", newNewArray));
