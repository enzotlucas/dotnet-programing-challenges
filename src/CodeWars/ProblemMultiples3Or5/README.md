# Problem Multiples of 3 or 5
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in. Additionally, if the number is negative, return 0 (for languages that do have them).

Note: If the number is a multiple of both 3 and 5, only count it once.

## Answer 
```cs
using System.Collections.Generic;

public static class Kata
{
      private static readonly List<int> _multiples = new();

      public static int Solution(int value)
      {
          _multiples.Clear();
        
          if (value < 0)
              return 0;

          FindMultiplesOfThreeOrFiveBellow(value);

          return SumAllMultiplesValues();
      }

      private static void FindMultiplesOfThreeOrFiveBellow(int value)
      {
          for (int i = 1; i < value; i++)
          {              
              if (i % 3 == 0 || i % 5 == 0)
                  _multiples.Add(i);
          }
      }

      private static int SumAllMultiplesValues()
      {
          var sum = 0;
          
          foreach (var number in _multiples) 
            sum += number;    
          
          return sum;
      }
}
```
