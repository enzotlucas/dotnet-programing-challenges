using PlusMinus;

Console.WriteLine("Input some values, the first line contains an integer, n, the size of the array.\nThe second line contains n space-separated integers that describe arr[n].");

var inputValue = Console.ReadLine().Trim();

var validNumber = int.TryParse(inputValue, out int n);

if (!validNumber || n <= 0 || n > 100)
    PrintErrorMessage("Invalid size of array. Press any button to shut down...", 1);

var arr = GetNumbersList();

Solution.Resolve(arr);

Console.ReadKey();

static void PrintErrorMessage(string message, int exitCode)
{
    Console.WriteLine(message);

    Console.ReadKey();

    Environment.Exit(exitCode);
}

static List<int> GetNumbersList()
{
    var numbersList = Console.ReadLine().TrimEnd().Split(' ').ToList();

    var arr = new List<int>();

    foreach (var inputNumber in numbersList)
    {
        var validNumber = int.TryParse(inputNumber, out int number);

        if (!validNumber || number < -100 || number > 100)
            PrintErrorMessage("Invalid number. Press any button to shut down...", 2);

        arr.Add(number);
    }

    return arr;
}
