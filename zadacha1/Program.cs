﻿/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет

12821 -> да

23432 -> да */


Console.WriteLine("Введите пятизначное число: ");
string num5 = Console.ReadLine();
if (num5.Length != 5)
{
    Console.WriteLine("Введено не пятизначное число");
}

{
        if (num5[0] == num5[4] & num5[1] == num5[3])
        {
            Console.WriteLine("Является палиндромом!");
        }

        else
        {
            Console.WriteLine("Не является палиндромом!");
        }
}
