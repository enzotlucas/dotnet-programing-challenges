using PlusMinus;

Console.WriteLine("Plus Minus Kata \nInput some values, the first line contains an integer, n, the size of the array.\nThe second line contains n space-separated integers that describe arr[n].");

var inputValue = Console.ReadLine().Trim();

var validNumber = int.TryParse(inputValue, out int n);

if (!validNumber || n <= 0 || n > 100)
    PrintErrorMessage("Invalid size of array (0 < n <= 100). Press any button to shut down...", 1);

var arr = GetNumbersList(n);

Solution.Resolve(arr);

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

    if(numbersList is null || numbersList.Count != n)
        PrintErrorMessage($"Invalid number list ({n} space-separated integers). Press any button to shut down...", 2);

    var arr = new List<int>(n);

    foreach (var inputNumber in numbersList)
    {
        var validNumber = int.TryParse(inputNumber, out int number);

        if (!validNumber || number < -100 || number > 100)
            PrintErrorMessage("Invalid number (-100 <= n <= 100). Press any button to shut down...", 3);

        arr.Add(number);
    }

    return arr;
}
