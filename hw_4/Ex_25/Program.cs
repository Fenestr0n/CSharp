/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Write("Введите основание степени: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите показатель степени: ");
int b = Convert.ToInt32(Console.ReadLine());

int numPow(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++) res = res * a;
    return res;
}
Console.WriteLine($"Число {a} в степени {b} = {numPow(a, b)}");