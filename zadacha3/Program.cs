/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */



Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Таблица кубов от 1 до {number}:");

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i * i * i}");
}


/*
{
    int stepen = 3;
    Console.WriteLine("число в кубе = " + Math.Pow(number, stepen));
    Console.ReadKey();
    
}
*/