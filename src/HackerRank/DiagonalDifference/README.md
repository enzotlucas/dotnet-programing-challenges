# Problem Diagonal Difference

Given a square matrix, calculate the absolute difference between the sums of its diagonals.

For example, the square matrix <b>arr</b> is shown below:
```bash
1 2 3
4 5 6
9 8 9  
```

The left-to-right diagonal = <b>1 + 5 + 9 = 15</b>. The right to left diagonal = <b>3 + 5 + 9 = 17</b>. Their absolute difference is <b>|15 - 17| = 2</b>.

## Function Description

Complete the  function in the editor below.

diagonalDifference takes the following parameter:

- int arr[n][m]: an array of integers

## Return

- int: the absolute diagonal difference

## Input Format

The first line contains a single integer, <b>n</b>, the number of rows and columns in the square matrix <b>arr</b>.
Each of the next <b>n</b> lines describes a row, <b>arr[i]</b>, and consists of <b>n</b> space-separated integers <b>arr[i][j]</b>.

## Constraints
<b>
- -100 <= arr[i][j] <= 100
</b>

## Output Format

Return the absolute difference between the sums of the matrix's two diagonals as a single integer.

## Sample Input
```bash
3
11 2 4
4 5 6
10 8 -12
```

## Sample Output
```bash
15
```

## Explanation
The primary diagonal is:
```bash
11
   5
     -12
```
Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:
```bash
     4
   5
10
```
Sum across the secondary diagonal: 4 + 5 + 10 = 19
Difference: |4 - 19| = 15

## Note
|x| is the <a href="https://www.mathsisfun.com/numbers/absolute-value.html">absolute value</a> of x

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

//I changed this class
class Result
{
    private static int _primaryDiagonal;
    private static int _secondaryDiagonal;
    private static int _lineCount;
    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
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

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
```