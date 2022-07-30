# Problem 1866 - Account
Two friends ask a cafeteria attendant to propose a challenge, so that whoever gets it right doesn't have to pay the bill. So the following was proposed: Given the following summation below, inform the result, with a number of terms in it:

S = 1 - 1 + 1 - 1 + 1 - 1 + 1 - 1 ...

Write a program that, given a number of terms, reports the result of the sum above.

<b>Input</b>

An integer C will be informed, which will be the number of test cases. Each test case starts with an integer N (1 ≤ N ≤ 1000), indicating the number of terms in the sum.

<b>Output</b>

For each test case print a number S, which is the result of the sum of the N terms of the expression.

## Input example
```bash
3
11
7
18
```

## Output example
```bash
1
1
0
```

## Answer 
```cs
using System; 

class URI 
{
    private static readonly int _minimunNumber = 1;
    private static readonly int _maxNumber = 1000;
    private static int _numberOfCases;
    private static int[] _inputNumbers;
        
    static void Main() 
    { 
        var ínputCaseNumbersValue = Console.ReadLine();

        var validCaseNumbers = int.TryParse(ínputCaseNumbersValue, out _numberOfCases);

        if (!validCaseNumbers)
            Environment.Exit(1);

        _inputNumbers = new int[_numberOfCases];

        for (int i = 0; i < _numberOfCases; i++)            
            ReadNumber(i);

        foreach(var inputNumber in _inputNumbers)
            PrintExpressionsResult(inputNumber);
    }

    private static void ReadNumber(int arrayIndex)
    {
        var inputValue = Console.ReadLine();

        var validNumber = int.TryParse(inputValue, out int inputNumber);

        if (!validNumber || inputNumber < _minimunNumber || inputNumber > _maxNumber)
            Environment.Exit(2);

        _inputNumbers[arrayIndex] = inputNumber;
    }

    private static void PrintExpressionsResult(int inputNumber)
    {
        var sum = 1;

        for(int i = _minimunNumber; i < inputNumber; i++)            
            sum = sum == 1 ? sum - 1 : sum + 1;            

        Console.WriteLine(sum);
    }   
}
```