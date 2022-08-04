# Problem Mini-Max Sum

Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

## Example
<b>arr = [1, 3, 5, 7, 9]</b>
The minimum sum is <b>1 + 3 + 5 + 7 = 16</b> and the maximum sum is <b>3 + 5 + 7 + 9 = 24</b>. The function prints

## Function Description

Complete the miniMaxSum function in the editor below.

miniMaxSum has the following parameter(s):

- arr: an array of <b>5</b> integers

## Print

Print two space-separated integers on one line: the minimum sum and the maximum sum of <b>4</b> of <b>5</b> elements.

## Input Format

A single line of five space-separated integers.

## Constraints
<b>
1 < arr[i] <= 10^9
</b>

## Output Format

Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

## Sample Input
```bash
1 2 3 4 5
```

## Sample Output
```bash
10 14
```

## Explanation

The numbers are <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, and <b>5</b>. Calculate the following sums using four of the five integers:

1. Sum everything <b>1</b> except , the sum is <b>2 + 3 + 4 + 5 = 14</b>.
2. Sum everything <b>2</b> except , the sum is <b>1 + 3 + 4 + 5 = 13</b>.
3. Sum everything <b>3</b> except , the sum is <b>1 + 2 + 4 + 5 = 12</b>.
4. Sum everything <b>4</b> except , the sum is <b>1 + 2 + 3 + 5 = 11</b>.
5. Sum everything <b>5</b> except , the sum is <b>1 + 2 + 3 + 4 = 10</b>.

## Hints
Beware of integer overflow! Use 64-bit Integer.

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
    public static void MiniMaxSum(List<long> arr)
    {
        var minimunSum = arr.OrderBy(x => x).Take(4).Sum();

        var maximunSum = arr.OrderByDescending(x => x).Take(4).Sum();
        
        Console.WriteLine($"{minimunSum} {maximunSum}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.MiniMaxSum(arr);
    }
}
```