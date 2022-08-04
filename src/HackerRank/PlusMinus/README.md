# Problem Plus Minus

Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with <b>6</b> places after the decimal.

## Note

This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to <b>10^-4</b> are acceptable.

## Example

<b>arr = [1, 1, 0, -1, -1]</b>
There are <b>n = 5</b> elements, two positive, two negative and one zero. Their ratios are <b>2/5 = 0.400000</b>, <b>2/5 = 0.400000</b> and <b>1/5 = 0.200000</b>. Results are printed as:
```bash
0.400000
0.400000
0.200000
```

## Function Description

Complete the plusMinus function in the editor below.

plusMinus has the following parameter(s):

- int arr[n]: an array of integers

## Print

Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with <b>6</b> digits after the decimal. The function should not return a value.

## Input Format

The first line contains an integer, , the size of the array.
The second line contains  space-separated integers that describe <b>arr[n]</b>.

## Constraints
<b>
0 < n <= 100
-100 <= arr[i] <= 100
</b>

## Output Format

<b>Print</b> the following  lines, each to  decimals:

 1. proportion of positive values
 2. proportion of negative values
 3. proportion of zeros

## Sample Input
```bash
STDIN           Function
-----           --------
6               arr[] size n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
```

## Sample Output
```bash
0.500000
0.333333
0.166667
```

## Explanation

There are <b>3</b> positive numbers, <b>2</b> negative numbers, and <b>1</b> zero in the array.
The proportions of occurrence are positive: <b>3/6 = 0.500000</b>, negative: <b>2/6 = 0.333333</b> and zeros: <b>1/6 = 0.166667</b>.

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
    public static void PlusMinus(List<int> arr)
    {
        double positiveNumberCount = arr.Where(n => n > 0).Count();
        
        double negativeNumberCount = arr.Where(n => n < 0).Count();
        
        double zeroCount = arr.Where(n => n is 0).Count();
        
        Console.WriteLine($"{(positiveNumberCount / arr.Count).ToString("#0.000000").Replace(',','.')} \n{(negativeNumberCount / arr.Count).ToString("#0.000000").Replace(',','.')} \n{(zeroCount / arr.Count).ToString("#0.000000").Replace(',', '.')}");
    }

}

class Solution
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.PlusMinus(arr);
    }
}
```