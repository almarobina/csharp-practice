Console.Write("Enter hours: ");
decimal hours = decimal.Parse(Console.ReadLine()!);


if (hours <= 0)
{
	Console.WriteLine("INVALID HOURS");
}
else if (hours > 5)
{
	decimal firstHours = 2 * 30;
	decimal nextHours = 3 * 20;
	decimal remaining = hours - 5;
	decimal thirdPart = remaining * 15;
	decimal total = firstHours + nextHours + thirdPart;

	Console.WriteLine($"Total: ₱{total:N2}");
}
else if (hours > 2)
{
	decimal firstHours = 2 * 30;
	decimal remaining = hours - 2;
	decimal thirdPart = remaining * 20;
	decimal total = firstHours + thirdPart;

	Console.WriteLine($"Total: ₱{total}");
}
else
{
	decimal total =  hours * 30;

	Console.WriteLine($"Total ₱{total}");
}
