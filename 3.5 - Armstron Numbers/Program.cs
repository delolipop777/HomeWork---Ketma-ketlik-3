using System.Numerics;
Console.Write("Enter a number: ");
BigInteger number = BigInteger.Parse(Console.ReadLine()!);

BigInteger sum = 0;

short length = (short)number.ToString().Length;
BigInteger originalNumber = number;
while (number > 0)
{
    BigInteger digit = number % 10;
    sum += BigInteger.Pow(digit, length);
    number /= 10;
}

if (sum == originalNumber)
{
    Console.WriteLine($"{originalNumber} is an Armstrong Number");
}
else
{
    Console.WriteLine($"{originalNumber} is Not an Armstrong Number");
}