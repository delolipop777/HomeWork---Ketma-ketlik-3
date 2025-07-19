Console.Write($"Enter a number to know its factors: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"The factors of {number} are:");
if (number % 2 == 0)
{
    Console.Write($"2");
}
for (int i = 3; i <= 10; i++)
{
    if (number % i == 0)
    {
        Console.Write($", {i}");
    }
}
