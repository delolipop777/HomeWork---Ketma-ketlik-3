﻿Console.Write($"Enter a number to calculate its power: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write($"Enter the power: ");
int power = int.Parse(Console.ReadLine()!);
int result = 1;

for (int i = 0; i < power; i++)
{
    result *= number;
}

Console.WriteLine($"{number} raised to the power of {power} is {result}.");
