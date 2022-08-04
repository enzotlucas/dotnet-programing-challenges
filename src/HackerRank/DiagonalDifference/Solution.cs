namespace DiagonalDifference
{
    public static class Solution
    {
        private static int _primaryDiagonal;
        private static int _secondaryDiagonal;
        private static int _lineCount;

        public static int Resolve(List<List<int>> arr)
        {
            _primaryDiagonal = 0;

            _secondaryDiagonal = 0;

            _lineCount = arr.Count;

            SumDiagonalValues(arr);

            return _primaryDiagonal > _secondaryDiagonal ?
                        _primaryDiagonal - _secondaryDiagonal :
                        _secondaryDiagonal - _primaryDiagonal;
        }

        private static void SumDiagonalValues(List<List<int>> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                var line = arr[i];

                SumLineValues(i, line);
            }
        }

        private static void SumLineValues(int index, List<int> line)
        {
            _primaryDiagonal += line[index];

            _secondaryDiagonal += line[_lineCount - 1 - index];
        }
    }
}
