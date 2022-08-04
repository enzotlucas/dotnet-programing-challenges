# Problem Staircase

Staircase detail

This is a staircase of size <b>n = 4</b>:
```bash
    #
   ##
  ###
 ####
```
Its base and height are both equal to <b>n</b>. It is drawn using # symbols and spaces. The last line is not preceded by any spaces.

Write a program that prints a staircase of size <b>n</b>.

## Function Description

Complete the staircase function in the editor below.

staircase has the following parameter(s):

- int n: an integer

## Print

Print a staircase as described above.

## Input Format

A single integer, <b>n</b>, denoting the size of the staircase.

## Constraints
<b>
0 < n <= 100
</b>

## Output Format

Print a staircase of size <b>n</b>. using # symbols and spaces.

<b>Note</b>: The last line must have <b>0</b>. spaces in it.

## Sample Input
```bash
6
```

## Sample Output
```bash
      #
     ##
    ###
   ####
  #####
 ######
```

## Explanation

The staircase is right-aligned, composed of # symbols and spaces, and has a height and width of <b>n = 6</b>.

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
    private static int _numberOfCharsPerLine;
    private static int _numberOfSpaces;
    private static char[] _spaceCharacters;
    private static char[] _stairCharacters;
    
    public static void Staircase(int n)
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

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.Staircase(n);
    }
}
```