﻿Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

while (i < N)
{
    i = i + 1;
    Console.WriteLine(i);
    i += 1;
}