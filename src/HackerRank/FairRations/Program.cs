using FairRations;

Console.WriteLine("Fair Rations \nThe first line contains an integer N, the number of subjects in the bread line. The second line contains N space-separated integers B[i].");

var inputValue = Console.ReadLine().Trim();

var validNumber = int.TryParse(inputValue, out int n);

if (!validNumber || n < 2 || n > 1000)
    PrintErrorMessage("Invalid size of array (0 < n <= 100). Press any button to shut down...", 1);

var B = GetNumbersList(n);

var response = Solution.Resolve(B);

Console.WriteLine($"The response is {response}. Press any key to shut down...");

Console.ReadKey();

static void PrintErrorMessage(string message, int exitCode)
{
    Console.WriteLine(message);

    Console.ReadKey();

    Environment.Exit(exitCode);
}

static List<int> GetNumbersList(int n)
{
    var numbersList = Console.ReadLine().TrimEnd().Split(' ').ToList();

    if (numbersList is null || numbersList.Count != n)
        PrintErrorMessage($"Invalid number list ({n} space-separated integers). Press any button to shut down...", 2);

    var arr = new List<int>(n);

    foreach (var inputNumber in numbersList)
    {
        var validNumber = int.TryParse(inputNumber, out int number);

        if (!validNumber || number < 1 || number > 10)
            PrintErrorMessage("Invalid number (1 <= n <= 10). Press any button to shut down...", 3);

        arr.Add(number);
    }

    return arr;
}