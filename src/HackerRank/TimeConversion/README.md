# Problem Time Conversion

Given a time in <b>12</b>-hour AM/PM format, convert it to military (24-hour) time.

Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

## Example

- <b>s = '12:01:00PM'</b>
Return '12:01:00'.

- <b>s = '12:01:00AM'</b>
Return '00:01:00'.

## Function Description

Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.

timeConversion has the following parameter(s):

- string s: a time in <b>12</b> hour format.

## Return

- string: the time in <b>24</b> hour format

## Input Format

A single string <b>12</b>  that represents a time in <b>12</b>-hour clock format (i.e.: <b>hh:mm:ssAM</b> or <b>hh:mm:ssPM</b>).

## Constraints
<b>
- All input times are valid
</b>

## Sample Input
```bash
07:05:45PM
```

## Sample Output
```bash
19:05:45
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
    public static string TimeConversion(string s)
    {
        var validDate = DateTime.TryParse(s, out var date);

        if(!validDate)            
            PrintErrorMessage("Invalid date. Press any button to shut down...", 1);

        return date.ToString("HH:mm:ss");
    }
    
    private static void PrintErrorMessage(string message, int code)
    {
        Console.WriteLine(message);
        
        Console.ReadKey();
        
        Environment.Exit(code);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.TimeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
```