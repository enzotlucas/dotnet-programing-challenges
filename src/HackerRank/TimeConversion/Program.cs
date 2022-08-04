
using TimeConversion;

Console.WriteLine("Time Conversion. \nA single string 12 that represents a time in 12-hour clock format (i.e.: hh:mm:ssAM or hh:mm:ssPM).");

var inputValue = Console.ReadLine();

var response = Solution.Resolve(inputValue);

Console.WriteLine($"The date with the HH:mm:ss format is {response}. Press any button to shut down...");

Console.ReadKey();