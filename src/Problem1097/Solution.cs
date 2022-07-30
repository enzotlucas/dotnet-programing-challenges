namespace Problem1097
{
    public static class Solution
    {
        private static int _valueNumber = 6;
        private static int _sumNumber = 2;
        private static int _maxNumber = 9;

        public static void Resolve()
        {
            for (int i = 1; i <= _maxNumber; i += _sumNumber)            
                PrintValues(i);            
        }

        private static void PrintValues(int index)
        {
            for (int i = 0; i < 3; i++)
                Console.WriteLine($"I={index} J={_valueNumber + index - i}");
        }
    }
}
