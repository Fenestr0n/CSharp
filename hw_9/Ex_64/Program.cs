/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2,"
*/

string FindEven(int n)
{
    if (n % 2 != 0) n--;
    if (n <= 1) return string.Empty;
    else return $"{n} " + FindEven(n - 2);
}

void Main()
{
    Console.Clear();
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write(FindEven(n));
}

Main();