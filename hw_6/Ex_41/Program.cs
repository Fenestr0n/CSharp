/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Main();

void Main()
{
    Console.Clear();
    Console.Write(NumCounter(GetNumbers()));
}

int[] GetNumbers()
{
    Console.Write("Введите числа через запятую: ");
    int[] array = Console.ReadLine()
        .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
        .Select(b => int.Parse(b))
        .ToArray();
    return array;
}

int NumCounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}