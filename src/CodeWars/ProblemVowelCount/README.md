# Problem Vowel Count
Return the number (count) of vowels in the given string.

We will consider a, e, i, o, u as vowels for this Kata (but not y).

The input string will only consist of lower case letters and/or spaces.

## Answer 
```cs
using System;
using System.Linq;

public static class Kata
{
	private static readonly char[]  _vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
	
	public static int GetVowelCount(string str)
	{
		int vowelCount = 0;
		
		foreach(var letter in str.ToLower())
			if(_vowels.Contains(letter))
				vowelCount++;
		
		return vowelCount;
	} 
}
```
