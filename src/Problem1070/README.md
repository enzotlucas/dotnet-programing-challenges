# Problem 1070 
Read an integer value X. Then display the 6 consecutive odd values ​​starting from X, one value per line, including the X if applicable.

Input
The input will be a positive integer value.

Output
The output will be a sequence of six odd numbers.

## Input example
```bash
8
```

## Output example
```bash
9
11
13
15
17
19
```

## Answer 
```cs
using System;

class URI 
{
    private static int _number;
    private static bool NumberIsOdd => _number % 2 != 0;
    
    static void Main() 
    { 
        var inputedValue = Console.ReadLine();

        var numberValid = int.TryParse(inputedValue, out _number);
        
        if (!numberValid)
        {
            Environment.Exit(1);
        }
        
        PrintOddNumbers();
    }
    
    private static void PrintOddNumbers()
    {
        for (int i = 0; i < 6; i++)
        {
            if (i == 0)
            {
                if (NumberIsOdd)
                {
                    PrintOddNumber();
                    continue;
                }
            }
            
            _number += 1;
            
            PrintOddNumber();
        }
    }

    private static void PrintOddNumber()
    {
        Console.WriteLine(_number);
        
        _number += 1;
    }
}
```
