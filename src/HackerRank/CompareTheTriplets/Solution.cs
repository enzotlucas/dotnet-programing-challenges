namespace CompareTheTriplets
{
    public static class Solution
    {
        public static List<int> Resolve(List<int> a, List<int> b)
        {
            if (a is null || b is null | a.Count != b.Count)
                throw new ArgumentException("Invalid lists.");

            int pointsForA = 0, pointsForB = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    pointsForA++;

                if (b[i] > a[i])
                    pointsForB++;
            }

            return new List<int>() { pointsForA, pointsForB };
        }
    }
}
