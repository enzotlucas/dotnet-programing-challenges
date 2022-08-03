using System.Collections.Generic;
using System.Linq;
using System;

namespace ProblemStopGninnipSMySdroW
{
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
}