/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numb3 = int.Parse(Console.ReadLine());
int max = num1;
if (num2 > max){
    max = num2;
}
if (numb3 > max){
    max = numb3;
}
Console.WriteLine("Большее число: " + max);