# Problem 1070 
You must make a program that displays the sequence as shown in the example below.

<b>Input</b>

There is no input in this issue.

<b>Output</b>

Print the sequence as shown below.

## Input example
```bash
8
```

## Output example
```bash
I=1 J=7
I=1 J=6
I=1 J=5
I=3 J=9
I=3 J=8
I=3 J=7
...
I=9 J=15
I=9 J=14
I=9 J=13
```

## Answer 
```cs
using System; 

class URI 
{
    private static int _valueNumber = 6;
    private static int _sumNumber = 2;
    private static int _maxNumber = 9;

    static void Main() 
    { 
        for (int i = 1; i <= _maxNumber; i += _sumNumber)            
            PrintValues(i);  
    }
    
    private static void PrintValues(int index)
    {
        for (int i = 0; i < 3; i++)
            Console.WriteLine($"I={index} J={_valueNumber + index - i}");
    }
}
```
