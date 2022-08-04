
using CompareTheTriplets;

var listA = new List<int>() { 12, 15, 16};

var listB = new List<int>() { 20, 12, 22};

var response = Solution.Resolve(listA, listB);

Console.WriteLine($"The final score is: {string.Join(" ", response)}. Press any button to shut down...");

Console.ReadKey();