int attempts = 3;
int correctPin = 1234;

while (attempts > 0)
{
	Console.Write("Enter pin: ");
	int pin = int.Parse(Console.ReadLine()!);

	if (pin == correctPin)
	{
		Console.WriteLine("ACCESS GRANTED");
		break;
	}
	else 
	{
		attempts--;
		
		Console.WriteLine("WRONG PIN");
		Console.WriteLine($"Attempts remaining: {attempts}");
	}
}
if (attempts == 0)
{
	Console.WriteLine("ACCOUNT LOCKED");
}
