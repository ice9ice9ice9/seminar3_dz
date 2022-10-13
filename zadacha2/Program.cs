/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Double x1, x2, y1, y2, z1, z2, distance;

Console.WriteLine("Введите координаты A: ");
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты B: ");
x2 = Convert.ToDouble(Console.ReadLine());
y2 = Convert.ToDouble(Console.ReadLine());
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками в 3D пространстве равно {distance}");
