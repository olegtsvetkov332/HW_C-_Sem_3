﻿//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int count = 1;
for (int N = Convert.ToInt32(Console.ReadLine()); count != N + 1; count++)
{
    Console.WriteLine(Math.Pow(count, 3));
}