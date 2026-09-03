// See htt
Console.Write("Enter number: ");
int numbers = int.Parse(Console.ReadLine()!);


if (numbers <= 0)
{
	Console.WriteLine("INVALID NUMBER");
}
else
{

int i = 1;
int total = 0;

	while (i <= numbers)
	{
	
		if(i % 2 == 0)
		{
			total = total + i;
		
		}

		i++;
	}

	Console.WriteLine($"Total: {total}");
}

