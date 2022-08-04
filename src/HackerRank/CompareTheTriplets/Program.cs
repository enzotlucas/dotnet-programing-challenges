using CompareTheTriplets;

Console.WriteLine("Compare the Triplets. \n" +
                  "The first line contains 3 space-separated integers, a[0], a[1], and a[2], the respective values in triplet a." +
                  "The second line contains 3 space - separated integers, b[0], b[1], and b[2], the respective values in triplet b.");

var aliceRatingList = GetNumbersList();

var bobRatingList = GetNumbersList();

var response = Solution.Resolve(aliceRatingList, bobRatingList);

Console.WriteLine($"The final score is: {string.Join(" ", response)}. Press any button to shut down...");

Console.ReadKey();

static List<int> GetNumbersList()
{
    var numbersList = Console.ReadLine().TrimEnd().Split(' ').ToList();

    if (numbersList is null || numbersList.Count != 3)
        PrintErrorMessage("Invalid numbers (3 space-separated integers). Press any button to shut down...", 1);

    var arr = new List<int>(3);

    foreach (var inputNumber in numbersList)
    {
        var validNumber = int.TryParse(inputNumber, out int number);

        if (!validNumber || number < 1 || number > 100)
            PrintErrorMessage("Invalid number (1 <= n <= 100). Press any button to shut down...", 2);

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