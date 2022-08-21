using AppleAndOrange;

Console.WriteLine
(   
    "Apple and Orange Kata\n" +
    "The first line contains two space-separated integers denoting the respective values of s and t.\n" +
    "The second line contains two space-separated integers denoting the respective values of a and b.\n" +
    "The third line contains two space-separated integers denoting the respective values of m and n.\n" +
    "The fourth line contains m space-separated integers denoting the respective distances that each apple falls from point a.\n" +
    "The fifth line contains n space-separated integers denoting the respective distances that each orange falls from point b."
);


//Question header
string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int s = Convert.ToInt32(firstMultipleInput[0]);

int t = Convert.ToInt32(firstMultipleInput[1]);

string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int a = Convert.ToInt32(secondMultipleInput[0]);

int b = Convert.ToInt32(secondMultipleInput[1]);

string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

int m = Convert.ToInt32(thirdMultipleInput[0]);

int n = Convert.ToInt32(thirdMultipleInput[1]);

List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

Solution.Resolve(s, t, a, b, apples, oranges);

Console.WriteLine("\n\nPress any ley to shut down...");

Console.ReadKey();