/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Main();

void Main()
{
    Console.Clear();
    int[,] array = GetArray(4, 4);
    Console.WriteLine("Массив со случайными значениями:");
    PrintArray(array);
    SortRowsElement(array);
    Console.WriteLine("Массив с отсортированными строками:");
    PrintArray(array);
}

void SortRowsElement(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = array[i, j];
            int indexMax = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, k] > max)
                {
                    max = array[i, k];
                    indexMax = k;
                }
            }
            int temp = array[i, j];
            array[i, j] = max;
            array[i, indexMax] = temp;
        }
    }
}

int[,] GetArray(int sizeRows, int sizeColumns)
{
    int[,] array = new int[sizeRows, sizeColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}