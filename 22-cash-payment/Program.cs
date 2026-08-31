// See https://aka.ms/new-console-template for more information
Console.Write("Item price: ");
	decimal itemPrice = decimal.Parse(Console.ReadLine()!);

Console.Write("Cash paid: ");
	 decimal cashPaid = decimal.Parse(Console.ReadLine()!);



if (itemPrice <= 0)
{
	Console.WriteLine("INVALID PRICE");
}
else if(cashPaid <= 0)
{
	Console.WriteLine("INVALID PAYMENT");
}
else if (cashPaid < itemPrice)
{
	Console.WriteLine("INSUFFICIENT PAYMENT");
}
else if (cashPaid == itemPrice)
{
	Console.WriteLine("PAYMENT SUCCESSFUL");
	Console.WriteLine("Exact payment");
	
}
else
{
	decimal change = cashPaid - itemPrice;

	Console.WriteLine("PAYMENT SUCCESSFUL");
	Console.WriteLine($"Change: ₱{change:N2}");
}
