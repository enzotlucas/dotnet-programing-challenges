namespace BirthdayCakeCandles
{
    public static class Solution
    {
        public static int Resolve(List<long> candles)
        {
            long biggestCandleSize = 0;
            var biggestCandleCount = 0;

            for (int i = 0; i < candles.Count; i++)
            {
                var candle = candles[i];

                if (candle.Equals(biggestCandleSize))
                    biggestCandleCount++;

                if (candle > biggestCandleSize)
                {
                    biggestCandleCount = 1;
                    biggestCandleSize = candle;
                }
            }

            return biggestCandleCount;
        }
    }
}
