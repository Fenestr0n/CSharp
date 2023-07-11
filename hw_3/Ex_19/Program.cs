/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int temp = num;
int reverse = 0;

while (temp > 0)
{
    reverse = reverse * 10 + temp % 10;
    temp /= 10;
}
if (num == reverse) Console.WriteLine("Палиндром");
else Console.WriteLine("Обычное число");