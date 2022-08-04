# Problem Simple Array Sum
Given an array of integers, find the sum of its elements.

For example, if the array <b>ar= [1,2,3]</b>, <b>1 + 2 + 3 = 6</b>, so return <b>6</b>.

## Function Description

Complete the simpleArraySum function in the editor below. It must return the sum of the array elements as an integer. 

simpleArraySum has the following parameter(s):

- ar: an array of integers

## Input Format

The first line contains an integer, <b>n</b>, denoting the size of the array.
The second line contains <b>n</b> space-separated integers representing the array's elements.

## Constraints

0 < n, ar[i] <= 1000

## Output Format

Print the sum of the array's elements as a single integer.

## Sample Input
```bash
6
1 2 3 4 10 11
```

## Sample Output
```bash
31
```

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
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

     //This is the only method i've changed
     public static int simpleArraySum(List<int> ar)
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

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
```
