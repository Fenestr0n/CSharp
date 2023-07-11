/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("Нет третьей цифры в " + num);
}
else
{
    long i = 100;
    while (num >= i)
    {
        i = i * 10;
    }
    Console.WriteLine(num / (i / 1000) % 10);
}