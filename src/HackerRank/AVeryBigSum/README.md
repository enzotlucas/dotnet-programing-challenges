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
</b>

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
     * Complete the 'aVeryBigSum' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER_ARRAY ar as parameter.
     */

    //This is the only method i've changed
    public static long aVeryBigSum(List<long> ar)
    {
        return ar.Sum();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

```