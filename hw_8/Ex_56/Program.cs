/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Main();

void Main()
{
    Console.Clear();
    int[,] array = GetArray(8, 4);
    PrintArray(array);
    Console.WriteLine($"Наименьшаяя сумма элементов находится в строке: {FindRowSmallSumElements(array)}");
}

int FindRowSmallSumElements(int[,] array)
{
    int minSumElementsRow = 0;
    int indexSmallRows = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minSumElementsRow += array[i, j];
        }
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumElements = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumElements += array[i, j];
        }
        if (sumElements < minSumElementsRow)
        {   minSumElementsRow = sumElements;
            indexSmallRows = i;
        }
    }
    return indexSmallRows + 1;
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
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}