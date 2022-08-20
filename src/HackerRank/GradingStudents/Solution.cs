namespace GradingStudents
{
    public static class Solution
    {
        public static void Resolve(int[] grades)
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
}
