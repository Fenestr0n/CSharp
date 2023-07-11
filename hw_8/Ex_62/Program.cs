/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Main();

void Main()
{
    Console.Clear();
    int[,] array = new int[4, 4];
    FillSpiralArray(array);
    PrintArray(array);
}

void FillSpiralArray(int[,] array)
{
    int count = 10;
    int differenceToOne = count-1;
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0, i] = count;
        count++;
    }
    for (int j = 1; j < array.GetLength(0); j++)
    {
        array[j, array.GetLength(1) - 1] = count;
        count++;
    }
    for (int i = array.GetLength(1) - 2; i >= 0; i--)
    {
        array[array.GetLength(0) - 1, i] = count;
        count++;
    }
    for (int j = array.GetLength(0) - 2; j > 0; j--)
    {
        array[j, 0] = count;
        count++;
    }
    
    int coordRows = 1;                  
    int coordColumns = 1;
    
    while (count-differenceToOne < array.GetLength(0) * array.GetLength(1)) 
    { 
        while (array[coordRows, coordColumns + 1] == 0)
        {
            array[coordRows, coordColumns] = count;
            count++;
            coordColumns++;
        }
        while (array[coordRows + 1, coordColumns] == 0)
        {
            array[coordRows, coordColumns] = count;
            count++;
            coordRows++;
        }
        while (array[coordRows, coordColumns - 1] == 0)
        {
            array[coordRows, coordColumns] = count;
            count++;
            coordColumns--;
        }
        while (array[coordRows - 1, coordColumns] == 0)
        {
            array[coordRows, coordColumns] = count;
            count++;
            coordRows--;
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) array[i, j] = count;
        }
    }
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}