/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Main();

void Main()
{
    Console.Clear();
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Среднее арифметическое столбцов: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(Average(array, j) + "\t");
    }
    Console.WriteLine();
}

double Average(int[,] array, int col)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++) sum += array[i, col];
    return Math.Round(sum / array.GetLength(0), 1);
}
