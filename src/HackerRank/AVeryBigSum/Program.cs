
using AVeryBigSum;

var list = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

var result = Solution.Resolve(list);

Console.WriteLine($"The sum of 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 is: {result}. Press any button to shut down...");

Console.ReadKey();