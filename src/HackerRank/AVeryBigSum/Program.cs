using AVeryBigSum;

Console.WriteLine("A very big Sum Kata. \n" +
                  "The first line of the input consists of an integer n." +
                  "The next line contains n space - separated integers contained in the array.");

var inputValue = Console.ReadLine().Trim();

var validNumber = int.TryParse(inputValue, out int n);

if (!validNumber || n <= 0 || n > 10)
    PrintErrorMessage("Invalid size of array (0 < n <= 10). Press any button to shut down...", 1);

var ar = GetNumbersList(n);

var result = Solution.Resolve(ar);

Console.WriteLine($"The sum is: {result}. Press any button to shut down...");

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

        if (!validNumber || number < 0 || number > 100000000000)
            PrintErrorMessage("Invalid number (0 <= n <= 10^10). Press any button to shut down...", 3);

        arr.Add(number);
    }

    return arr;
}