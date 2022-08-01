using System;
using System.Linq;

namespace ProblemVowelCount
{
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
}