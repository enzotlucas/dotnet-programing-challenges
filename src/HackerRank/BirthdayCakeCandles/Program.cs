using BirthdayCakeCandles;

Console.WriteLine("Birthday Cake Candles Kata. \n The first line of the input consists of an integer n. The next line contains n space-separated integers contained in the array.");

var inputValue = Console.ReadLine().Trim();

var validNumber = int.TryParse(inputValue, out int n);

if (!validNumber || n < 1|| n > 1000000)
    PrintErrorMessage("Invalid size of array (1 < n <= 10^5). Press any button to shut down...", 1);

var candles = GetNumbersList(n);

var response = Solution.Resolve(candles);

Console.WriteLine($"The biggest candles count is {response}. Press any button to shut down...");

Console.ReadKey();

static void PrintErrorMessage(string message, int exitCode)
{
    Console.WriteLine(message);

    Console.ReadKey();

    Environment.Exit(exitCode);
}

static List<long> GetNumbersList(int n)
{
    var numbersList = Console.ReadLine().TrimEnd().Split(' ').ToList();

    if (numbersList is null || numbersList.Count != n)
        PrintErrorMessage($"Invalid number list ({n} space-separated integers). Press any button to shut down...", 2);

    var arr = new List<long>(n);

    foreach (var inputNumber in numbersList)
    {
        var validNumber = long.TryParse(inputNumber, out long number);

        if (!validNumber || number < 0 || number > 100000000)
            PrintErrorMessage("Invalid number (0 <= n <= 10^7). Press any button to shut down...", 3);

        arr.Add(number);
    }

    return arr;
}