namespace Problem1070
{
    public static class Solution
    {
        private static int _number;
        private static bool NumberIsOdd => _number % 2 != 0;

        public static void Resolve()
        {
            var inputedValue = Console.ReadLine();

            var numberValid = int.TryParse(inputedValue, out _number);

            if (!numberValid)
            {
                Environment.Exit(1);
            }

            PrintOddNumbers();
        }

        private static void PrintOddNumbers()
        {
            for (int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    if (NumberIsOdd)
                    {
                        PrintOddNumber();

                        continue;
                    }
                }

                _number += 1;

                PrintOddNumber();
            }
        }

        private static void PrintOddNumber()
        {
            Console.WriteLine(_number);

            _number += 1;
        }
    }
}
