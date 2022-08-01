using ProblemVowelCount;

Console.WriteLine("Write a word, the console will print the count of vowels.");

var word = Console.ReadLine();

var wordCounts = Kata.GetVowelCount(word);

Console.WriteLine($"The vowels count is: {wordCounts}, press any key to shut down...");

Console.ReadKey();