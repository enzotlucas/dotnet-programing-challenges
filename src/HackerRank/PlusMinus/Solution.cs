namespace PlusMinus
{
    public static class Solution
    {
        public static void Resolve(List<int> arr)
        {
            double positiveNumberCount = arr.Where(n => n > 0).Count();

            double negativeNumberCount = arr.Where(n => n < 0).Count();

            double zeroCount = arr.Where(n => n is 0).Count();

            Console.WriteLine($"{(positiveNumberCount / arr.Count).ToString("#0.000000").Replace(',','.')} \n{(negativeNumberCount / arr.Count).ToString("#0.000000").Replace(',','.')} \n{(zeroCount / arr.Count).ToString("#0.000000").Replace(',', '.')}");
        }
    }
}
