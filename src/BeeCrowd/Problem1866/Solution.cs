namespace Problem1866
{
    public static class Solution
    {
        private static readonly int _minimunNumber = 1;
        private static readonly int _maxNumber = 1000;
        private static int _numberOfCases;
        private static int[] _inputNumbers;

        public static void Resolve()
        {
            var ínputCaseNumbersValue = Console.ReadLine();

            var validCaseNumbers = int.TryParse(ínputCaseNumbersValue, out _numberOfCases);

            if (!validCaseNumbers)
                Environment.Exit(1);

            _inputNumbers = new int[_numberOfCases];

            for (int i = 0; i < _numberOfCases; i++)            
                ReadNumber(i);

            foreach(var inputNumber in _inputNumbers)
                PrintExpressionsResult(inputNumber);
        }

        private static void ReadNumber(int arrayIndex)
        {
            var inputValue = Console.ReadLine();

            var validNumber = int.TryParse(inputValue, out int inputNumber);

            if (!validNumber || inputNumber < _minimunNumber || inputNumber > _maxNumber)
                Environment.Exit(2);

            _inputNumbers[arrayIndex] = inputNumber;
        }

        private static void PrintExpressionsResult(int inputNumber)
        {
            var sum = 1;

            for(int i = _minimunNumber; i < inputNumber; i++)            
                sum = sum == 1 ? sum - 1 : sum + 1;            

            Console.WriteLine(sum);
        }
    }
}
