/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int step = 2;
if (num <= 1)
    {
        Console.WriteLine("Нет чётных чисел в диапазоне");
    }
else
    {
        while (step <= num)
        {
            Console.WriteLine(step);
            step = step + 2;
        }
    }
