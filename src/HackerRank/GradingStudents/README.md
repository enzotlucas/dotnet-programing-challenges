# Problem Grading Students

HackerLand University has the following grading policy:

- Every student receives a <b>grade</b> in the inclusive range from <b>0</b> to <b>100</b>.
- Any <b>grade</b> less than <b>40</b> is a failing grade..

Sam is a professor at the university and likes to round each student's <b>grade</b> according to these rules:

- If the difference between the <b>grade</b> and the next multiple of <b>5</b> is less than <b>3</b>, round <b>grade</b> up to the next multiple of <b>5</b>.
- If the value of  <b>grade</b> is less than <b>38</b>, no rounding occurs as the result will still be a failing grade.

## Examples

- <b>grade</b> = <b>84</b> round to <b>85</b> (85 - 84 is less than 3)
- <b>grade</b> = <b>29</b> do not round (result is less than 40)
- <b>grade</b> = <b>57</b> do not round (60 - 57 is 3 or higher)

Given the initial value of <b>grade</b> for each of Sam's <b>n</b> students, write code to automate the rounding process.

## Function Description

Complete the function gradingStudents in the editor below.

gradingStudents has the following parameter(s):

- int grades[n]: the grades before rounding

## Returns

- int[n]: the grades after rounding as appropriate

## Input Format

The first line contains a single integer, <b>n</b>, the number of students.
Each line <b>i</b> of the <b>n</b> subsequent lines contains a single integer, <b>grades[i]</b>.

## Constraints
<b>
- 1 <= n <= 60
- 0 <= grades[i] <= 100
</b>

## Sample Input
```bash
4
73
67
38
33
```

## Sample Output
```bash
75
67
40
33
```

## Explanation
1. Student <b>1</b> received a <b>73</b>, and the next multiple of <b>5</b> from <b>73</b> is <b>75</b>. Since <b>75 - 73 < 3</b>, the student's grade is rounded to <b>75</b>.

2. Student <b>2</b> received a <b>67</b>, and the next multiple of <b>5</b> from <b>67</b> is <b>70</b>. Since <b>70 - 67 = 3</b>, the grade will not be modified and the student's final grade is <b>75</b>.

3. Student <b>3</b> received a <b>38</b>, and the next multiple of <b>5</b> from <b>38</b> is <b>40</b>. Since <b>49 - 38 < 3</b>, the student's grade will be rounded to <b>40</b>.

34 Student <b>4</b> received a grade below <b>33</b>, so the grade will not be modified and the student's final grade is <b>33</b>.

## Answer 
```cs
using System;

class Solution
{
    public static void Main()
    {
        var inputValue = Console.ReadLine().Trim();

        var validNumber = int.TryParse(inputValue, out int numberOfStudents);
        
        if (!validNumber || numberOfStudents <= 0 || numberOfStudents > 60)
            Environment.Exit(1);
        
        var grades = GetGrades(numberOfStudents);
        
        PrintFinalGrades(grades);
    }
    
    private static int[] GetGrades(int numberOfStudents)
    {
        var grades = new int[numberOfStudents];
    
        for (int i = 0; i < numberOfStudents; i++)
        {
            var inputValue = Console.ReadLine().Trim();
    
            var validNumber = int.TryParse(inputValue, out int grade);
    
            if (!validNumber || grade < 0 || grade > 100)
                Environment.Exit(2);
    
            grades[i] = grade;
        }
    
        return grades;
    }
    
    private static void PrintFinalGrades(int[] grades)
    {
        foreach (var grade in grades)
        {
            if (grade < 37 || grade % 5 == 0)
            {
                Console.WriteLine(grade);
                continue;
            }
    
            for (int i = 1; i <= 3; i++)
            {
                if ((grade + i) % 5 == 0 && i < 3)
                {
                    Console.WriteLine(grade + i);
                    break;
                }
    
                if (i >= 3)
                    Console.WriteLine(grade);
            }
        }
    }
}
```