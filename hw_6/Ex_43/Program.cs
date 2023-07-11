/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите значение b1: ");
    float b1 = float.Parse(Console.ReadLine());
    Console.Write("Введите значение k1: ");
    float k1 = float.Parse(Console.ReadLine());
    Console.Write("Введите значение b2: ");
    float b2 = float.Parse(Console.ReadLine());
    Console.Write("Введите значение k2: ");
    float k2 = float.Parse(Console.ReadLine());
    (float x, float y) = GetPoint(b1, k1, b2, k2);
    Console.WriteLine($"Точка пересечения: {x}; {y}");
}

(float, float) GetPoint(float b1, float k1, float b2, float k2)
{
    float x = (b2 - b1) / (k1 - k2);
    if (x == -0) x = 0;
    float y = k1 * x + b1;
    return (x, y);
}