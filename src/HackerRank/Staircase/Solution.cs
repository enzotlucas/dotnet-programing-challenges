namespace Staircase
{
    public static class Solution
    {
        private static int _numberOfCharsPerLine;
        private static int _numberOfSpaces;
        private static char[] _spaceCharacters;
        private static char[] _stairCharacters;

        public static void Resolve(int n)
        {
            _numberOfCharsPerLine = 1;

            _numberOfSpaces = n - 1;

            _spaceCharacters = GenerateCharsArray(n - 1, ' ');

            _stairCharacters = GenerateCharsArray(n, '#');

            GenerateRightAlignedStair(n);
        }

        private static char[] GenerateCharsArray(int count, char character)
        {
            var array = new char[count];

            for (int i = 0; i < count; i++)
                array[i] = character;

            return array;
        }

        private static void GenerateRightAlignedStair(int numberOfRows)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write(_spaceCharacters, 0, _numberOfSpaces);

                Console.WriteLine(_stairCharacters, 0, _numberOfCharsPerLine);

                _numberOfCharsPerLine++;

                _numberOfSpaces--;
            }
        }
    }
}
