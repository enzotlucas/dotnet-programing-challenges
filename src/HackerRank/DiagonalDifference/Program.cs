using DiagonalDifference;

var list1 = new List<int>(3) { 11, 2, 4 };
var list2 = new List<int>(3) { 4, 5, 6 };
var list3 = new List<int>(3) { 10, 8, -12 };

var arr = new List<List<int>>(3) { list1, list2, list3 };

var response = Solution.Resolve(arr);

Console.WriteLine($"The response is {response}. Press any button to shut down...");

Console.ReadKey();
