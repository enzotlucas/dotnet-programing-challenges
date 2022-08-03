# Problem Multiples of 3 or 5
Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. 
Spaces will be included only when more than one word is present.

Examples:
```
spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
spinWords( "This is a test") => returns "This is a test" 
spinWords( "This is another test" )=> returns "This is rehtona test"
```

## Answer 
```cs
using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    private static string[] _words;
    private static string _setenceWithSpinedWords;

    public static string SpinWords(string sentence)
    {
        _setenceWithSpinedWords = string.Empty;

        _words = sentence.Split(' ');

        for (int i = 0; i < _words.Length; i++)
        {
            var word = _words[i];

            SpinWordIfNeeded(word);

            AddSpaceBetweenWordsIfNeeded(i);
        }

        return _setenceWithSpinedWords;
    }

    private static void SpinWordIfNeeded(string word)
    {
        if (word.Length >= 5)
            word = SpinWord(word);

        _setenceWithSpinedWords += word;
    }

    private static string SpinWord(string word)
    {
        var spinedWord = string.Empty;

        for (int i = 0; i < word.Length; i++)
        {
            var index = word.Length - 1 - i;

            var lastLetter = i == 0 ? word.Substring(index) : word.Substring(index, 1);

            spinedWord += lastLetter;
        }

        return spinedWord;
    }

    private static void AddSpaceBetweenWordsIfNeeded(int wordsIndex)
    {
        if (_words.Length - 1 != wordsIndex)
            _setenceWithSpinedWords += " ";
    }
}
```
