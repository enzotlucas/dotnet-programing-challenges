# Problem A Very Big Sum

In this challenge, you are required to calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

## Function Description

Complete the aVeryBigSum function in the editor below. It must return the sum of all array elements.

aVeryBigSum has the following parameter(s):

- int ar[n]: an array of integers.

## Return

- long: the sum of all array elements.

## Input Format

The first line of the input consists of an integer <b>n</b>.
The next line contains <b>n</b> space-separated integers contained in the array.

## Output Format

Return the integer sum of the elements in the array.

## Constraints
<b>
1 <= n <= 100
0 <= ar[i] <= 10^10
/b>

## Sample Input
```bash
5
1000000001 1000000002 1000000003 1000000004 1000000005
```

## Sample Output
```bash
5000000015
```

## Note
The range of the 32-bit integer is (-2^31) to (2^31 - 1) or [-2147483648, 2147483647].
When we add several integer values, the resulting sum might exceed the above range. You might need to use long int C/C++/Java to store such sums.

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

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    //This is the only method i've changed
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        if (a is null || b is null | a.Count != b.Count)
           throw new ArgumentException("Invalid lists.");
        
        int pointsForA = 0, pointsForB = 0;
        
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
                pointsForA++;
        
            if (b[i] > a[i])
                pointsForB++;
        }
        
        return new List<int>() { pointsForA, pointsForB };
    }       
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
```