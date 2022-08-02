# Problem Multiples of 3 or 5
Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

## Answer 
```cs
using System;

namespace Solution
{
	public class SolutionClass
	{
		public static string EvenOrOdd(int number) => number % 2 == 0 ? "Even" : "Odd";
	}
}
```
