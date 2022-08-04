using SimpleArraySum;

Console.WriteLine("Simple Array Sum Kata \nInput a single line of three space-separated integers");

var list = GetNumbersList();

var result = Solution.Resolve(list);

Console.WriteLine($"The sum is {result}. Press any button to shut down...");

Console.ReadKey();

static List<int> GetNumbersList()
{
    var numbersList = Console.ReadLine().TrimEnd().Split(' ').ToList();

    if (numbersList is null ||  numbersList.Count != 3)
        PrintErrorMessage("Invalid numbers (3 space-separated integers). Press any button to shut down...", 1);

    var arr = new List<int>(3);

    foreach (var inputNumber in numbersList)
    {
        var validNumber = int.TryParse(inputNumber, out int number);

        if (!validNumber || number < 1 || number > 1000)
            PrintErrorMessage("Invalid number (1 <= n <= 1000). Press any button to shut down...", 2);

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