Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);

if (number <= 0)
{
    Console.WriteLine("INVALID NUMBER");
}
else
{
    int total = 0;
    string series = "";
    int i = 1;

    while (i <= number)
    {
        total = total + i;
        if (i == 1)
        {
            series = series + i;
        }
        else
        {
            series = series + "+" + i;
        }

        i++;
    }

    Console.WriteLine($"{series} = {total}");
}
