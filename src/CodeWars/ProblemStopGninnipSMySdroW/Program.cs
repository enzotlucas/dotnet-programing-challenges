
using ProblemStopGninnipSMySdroW;

Console.WriteLine("Write a setence, with any count of words, any word with more than 4 letters will be spined up.");

var setence = Console.ReadLine();

Console.WriteLine($"The final setence is:\n{Kata.SpinWords(setence)}");

Console.ReadKey();