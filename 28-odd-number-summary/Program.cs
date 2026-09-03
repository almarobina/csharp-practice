// See https://aka.ms/new-console-template for more information
Console.Write("Enter number ");
int numbers = int.Parse(Console.ReadLine()!);

if(numbers <= 0)
{
	Console.WriteLine("INVALID NUMBER");
}
else
{
	int i = 1;
	int total = 0;
	int count = 0;
	while (i <= numbers)
	{
		if(i % 2 != 0)
		{
			total += i;
			count++;
		}
		i++;
	}
	Console.WriteLine($"Odd count: {count}");
	Console.WriteLine($"Odd sum: {total}");
}
