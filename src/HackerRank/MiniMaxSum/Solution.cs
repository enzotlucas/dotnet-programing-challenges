namespace MiniMaxSum
{
    public class Solution
    {
        public static void Resolve(List<long> arr)
        {
            var minimunSum = arr.OrderBy(x => x).Take(4).Sum();

            var maximunSum = arr.OrderByDescending(x => x).Take(4).Sum();

            Console.WriteLine($"{minimunSum} {maximunSum}");
        }
    }
}
