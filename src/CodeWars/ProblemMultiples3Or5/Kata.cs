namespace ProblemMultiples3Or5
{
    public static class Kata
    {
        private static readonly List<int> _multiples = new();

        public static int Solution(int value)
        {
            _multiples.Clear();

            if (value < 0)
                return 0;

            FindMultiplesOfThreeOrFiveBellow(value);

            return SumAllMultiplesValues();
        }

        private static void FindMultiplesOfThreeOrFiveBellow(int value)
        {
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 && !_multiples.Any(m => m.Equals(i)))
                    _multiples.Add(i);
            }
        }

        private static int SumAllMultiplesValues()
        {
            var sum = 0;

            foreach (var number in _multiples)            
                sum += number;            

            return sum;
        }
    }
}
