﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите желаемое число:");

int N = int.Parse(Console.ReadLine());

if(N == 0)
{
    Console.WriteLine("Введите число отличное от нуля.");
}
else
{
    if(N % 2 == 0)
    {
        Console.WriteLine("Данное число является четным.");
    }
    else
    {
        Console.WriteLine("Данное число является нечетным.");
    }
}