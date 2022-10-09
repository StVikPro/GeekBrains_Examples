﻿/* Задача 48: Задайте двумерный массив размера m на n, каждый 
элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

Console.Clear();

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int [m,n];
FillArray(array);
PrintArray(array);


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
        {    
                Console.Write($"{array[i,j]} ");   
        }    
        Console.WriteLine("");
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
        {    
                array[i,j] = i + j;   
        }    
    }
}