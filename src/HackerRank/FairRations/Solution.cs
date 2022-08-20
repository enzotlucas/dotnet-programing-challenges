namespace FairRations
{
    public static class Solution
    {
        private static string _amountOfBagsGivedResponse;
        private static int _amountOfBagsGived;
        private static int _amountOfTrys;
        private static int _personInLine;
        private static int _personInFront;
        private static int _personBehind;
        private static bool _oddNumberOfBagsExists;

        public static string Resolve(List<int> B)
        {
            DistributeLoafsOfBread(B);

            return _amountOfBagsGivedResponse;
        }

        private static void DistributeLoafsOfBread(List<int> B)
        {
            int loaves = 0;
            for (int i = 0; i < B.Count - 1; ++i)
            {
                if (B[i] % 2 == 1)
                {
                    loaves += 2;
                    B[i]++;
                    B[i + 1]++;
                }
            }

            if (B[B.Count - 1] % 2 == 1)
            {
                Console.Out.WriteLine("NO");
            }
            else
            {
                Console.Out.WriteLine(loaves);
            }
        }

        private static bool IsOdd(this int number) => number % 2 != 0;
    }
}