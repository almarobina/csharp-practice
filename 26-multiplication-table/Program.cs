Console.Write("Enter number: ");
int numbers = int.Parse(Console.ReadLine()!);


if (numbers <= 0)
{
	Console.WriteLine("INVALID NUMBER");
}
else 
{
	int i = 1;
	while (i <= 10)
	{
		int products = numbers * i;
		
		
	
	Console.WriteLine($"{numbers} X {i} = {products}");
	i++;
	}
}
