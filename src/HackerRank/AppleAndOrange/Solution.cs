namespace AppleAndOrange
{
    public static class Solution
    {
        public static void Resolve(int houseStartingLocationPoint,
                                   int houseEndingLocationPoint,
                                   int appleTreeLocation,
                                   int orangeTreeLocation,
                                   List<int> applesFallDistances,
                                   List<int> orangesFallDistances)
        {
            int applesAtHouse = 0, orangesAtHouse = 0;

            foreach (var apple in applesFallDistances)
                if (apple + appleTreeLocation >= houseStartingLocationPoint && apple + appleTreeLocation <= houseEndingLocationPoint)
                    applesAtHouse++;

            foreach (var orange in orangesFallDistances)
                if (orange + orangeTreeLocation >= houseStartingLocationPoint && orange + orangeTreeLocation <= houseEndingLocationPoint)
                    orangesAtHouse++;

            Console.WriteLine($"{applesAtHouse}\n{orangesAtHouse}");
        }
    }
}
