
using MiniMaxSum;

Console.WriteLine("Mini-Max Sum Kata \nInput a single line of five space-separated integers.");

var numbers = GetNumbersList();

Solution.Resolve(numbers);

Console.WriteLine("Press any key to shut down...");

Console.ReadKey();

static List<long> GetNumbersList()
{
    var numbersList = Console.ReadLine().TrimEnd().Split(' ').ToList();

    if(numbersList is null || numbersList.Count != 5)
        PrintErrorMessage("Invalid numbers (5 space-separated integers). Press any button to shut down...", 1);

    var arr = new List<long>(5);

    foreach (var inputNumber in numbersList)
    {
        var validNumber = long.TryParse(inputNumber, out long number);

        if (!validNumber || number < 1 || number > 10000000000)
            PrintErrorMessage("Invalid number (1 <= n <= 100^9). Press any button to shut down...", 2);

        arr.Add(number);
    }

    return arr;
}

static void PrintErrorMessage(string message, int exitCode)
{
    Console.WriteLine(message);

    Console.ReadKey();

    Environment.Exit(exitCode);
}
