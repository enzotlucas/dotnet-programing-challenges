using DiagonalDifference;

Console.WriteLine("Diagonal Differece Kata \n" +
                  "Input some values, " +
                  "the first line contains a single integer, n, the number of rows and columns in the square matrix arr." +
                  "Each of the next n lines describes a row, arr[i], and consists of n space-separated integers arr[i][j].");

var inputValue = Console.ReadLine().Trim();

var validNumber = int.TryParse(inputValue, out int n);

if (!validNumber || n <= 0 || n > 100)
    PrintErrorMessage("Invalid size of array (0 < n <= 100). Press any button to shut down...", 1);

var arr = new List<List<int>>(n);

for (int i = 0; i < n; i++)
    arr.Add(GetNumbersList(n));

var response = Solution.Resolve(arr);

Console.WriteLine($"The diference is {response}. Press any button to shut down...");

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
        PrintErrorMessage($"Invalid number line ({n} space-separated integers). Press any button to shut down...", 2);

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