// See https://aka.ms/new-console-template for more information
Console.Write("Enter the number of Expenses: ");
int n = int.Parse(Console.ReadLine());
int[] expenses = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter Expense {i + 1}: ");
    expenses[i] = int.Parse(Console.ReadLine());
}

int total = 0;
foreach (int expense in expenses)
{
    total += expense;
}
Console.WriteLine($"Total: {total}");