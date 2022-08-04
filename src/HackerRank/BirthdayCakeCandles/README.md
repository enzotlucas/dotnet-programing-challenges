# Problem Birthday Cake Candles

You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age. They will only be able to blow out the tallest of the candles. Count how many candles are tallest.

## Examples

<b>candles = [4, 4, 1, 3]</b>

The maximum height candles are <b>4</b> units high. There are <b>2</b> of them, so return <b>2</b>.

## Function Description

Complete the function birthdayCakeCandles in the editor below.

birthdayCakeCandles has the following parameter(s):

- int candles[n]: the candle heights

## Returns

- int: the number of candles that are tallest

## Input Format

The first line contains a single integer, <b>n</b>, the size of <b>candles[]</b>.
The second line contains <b>n</b> space-separated integers, where each integer <b>i</b> describes the height of <b>candles[i]</b>.

## Constraints
<b>
- 1 <= n <= 10^5
- 1 <= candles[i] <= 10^7
</b>

## Sample Input
```bash
4
3 2 1 3
```

## Sample Output
```bash
2
```

## Explanation
Candle heights are <b>[3, 2, 1, 3]</b>. The tallest candles are <b>3</b> units, and there are <b>2</b> of them.

## Note
This kata has a time limmit for the solution, then, i've commented the elegant solution, and left the faster one.

## Answer 
```cs
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    //This is the elegant solution
    //public static int BirthdayCakeCandles(List<long> candles)  =>
    //      candles.Where(c => c.Equals(candles.Max())).Count();

    public static int BirthdayCakeCandles(List<long> candles)
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

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt64(candlesTemp)).ToList();

        int result = Result.BirthdayCakeCandles(candles);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

```