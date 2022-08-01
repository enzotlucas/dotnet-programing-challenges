
using ProblemMultiples3Or5;

Console.WriteLine("Write a number, if the number is positive, you will get the sum of all the natural numbers bellow it (if it's multiple of 3 or 5)");

var inputValue = Console.ReadLine();

var validNumber = int.TryParse(inputValue, out int number);

if(!validNumber)
{
    Console.WriteLine("Invalid number");

    Environment.Exit(1);
}

var sum = Kata.Solution(number);

Console.WriteLine($"The sum of all the numbers are: {sum}");

Console.ReadKey();