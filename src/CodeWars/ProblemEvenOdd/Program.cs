
using ProblemEvenOdd;

Console.WriteLine("Write a number, the console will print if is even or odd");

var inputValue = Console.ReadLine();

var validNumber = int.TryParse(inputValue, out int number);

if(!validNumber)
{
    Console.WriteLine("Invalid number, press any button to shut down...");

    Console.ReadKey();

    Environment.Exit(0);
}

var evenOdd = SolutionClass.EvenOrOdd(number);

Console.WriteLine($"The number is: {evenOdd}");

Console.ReadKey();