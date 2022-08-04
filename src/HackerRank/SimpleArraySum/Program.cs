using SimpleArraySum;

var list = new List<int>() { 1, 2, 3 };

var result = Solution.Resolve(list);

Console.WriteLine($"The sum of 1, 2 and 3 is {result}. Press any button to shut down...");

Console.ReadKey();