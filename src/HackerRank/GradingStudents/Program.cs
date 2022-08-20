using GradingStudents;

Console.WriteLine("Grading Students Kata. \n" +
                  "HackerLand University has the following grading policy:\n" +
                  " - Every student receives a grade in the inclusive range from 0 to 100.\n" +
                  " - Any grade less than 40 is a failing grade...\n" +
                  "Sam is a professor at the university and likes to round each student's <b>grade</b> according to these rules:\n" +
                  " - If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.\n" +
                  " - If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.");

Console.WriteLine("Write the number of students (1 <= n <- 60), them, write the grades of each students in each line (0 <= grade <= 100)");

var inputValue = Console.ReadLine().Trim();

var validNumber = int.TryParse(inputValue, out int numberOfStudents);

if (!validNumber || numberOfStudents <= 0 || numberOfStudents > 60)
    PrintErrorMessage("Invalid number of students (1 <= n <= 60). Press any button to shut down...", 1);

var grades = GetGrades(numberOfStudents);

Solution.Resolve(grades);

Console.WriteLine("\n\nPress any key to shut down...");
Console.ReadKey();

static void PrintErrorMessage(string message, int exitCode)
{
    Console.WriteLine(message);

    Console.ReadKey();

    Environment.Exit(exitCode);
}

static int[] GetGrades(int numberOfStudents)
{
    var grades = new int[numberOfStudents];

    for (int i = 0; i < numberOfStudents; i++)
    {
        var inputValue = Console.ReadLine().Trim();

        var validNumber = int.TryParse(inputValue, out int grade);

        if (!validNumber || grade < 0 || grade > 100)
            PrintErrorMessage("Invalid grade (0 <= n <= 100). Press any button to shut down...", 1);

        grades[i] = grade;
    }

    return grades;
}