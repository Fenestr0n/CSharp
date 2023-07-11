/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();

Console.WriteLine("Введите координаты точки A: ");
Console.Write("Ax: ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("Ay: ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("Az: ");
int Az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("Bx: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("By: ");
int By = int.Parse(Console.ReadLine());
Console.Write("Bz: ");
int Bz = int.Parse(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)), 2);

Console.WriteLine("Растояние между точками равно: " + distance);
