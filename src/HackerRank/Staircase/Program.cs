using Staircase;

Console.WriteLine("Staircase Problem \nInput a single integer, n, denoting the size of the staircase.");

var inputValue = Console.ReadLine().Trim();

var validNumber = int.TryParse(inputValue, out int n);

if (!validNumber || n <= 0 || n > 100)
{
    Console.WriteLine("Invalid number (0 < n <= 100). Press any button to shut down...");

    Console.ReadKey();

    Environment.Exit(1);
}

Solution.Resolve(n);

Console.WriteLine("Press any key to shut down...");

Console.ReadKey();