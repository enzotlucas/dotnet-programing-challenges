using System.Linq;

namespace Certifications.CsharpBasic
{
    public static class SecondQuestion
    {
        //Question header
        public static void Resolve()
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }

        //Question challenge
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees) =>
            employees.GroupBy(c => c.Company)
                     .Select(e => new
                     {
                         e.Key,
                         Value = (int)e.Where(c => c.Company == e.Key)
                                       .Select(a => a.Age)
                                       .Average()
                     })
                     .ToDictionary(k => k.Key, v => v.Value);


        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees) =>
            employees.GroupBy(c => c.Company)
                     .Select(e => new
                     {
                         e.Key,
                         Value = e.Where(t => t.Company == e.Key)
                                  .Count()
                     })
                     .ToDictionary(k => k.Key, v => v.Value);

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees) =>
            employees.GroupBy(c => c.Company)
                     .Select(e => new
                     {
                         e.Key,
                         Value = e.Where(c => c.Company == e.Key && c.Age == e.Max(a => a.Age))
                                  .FirstOrDefault()
                     })
                     .ToDictionary(k => k.Key, v => v.Value);
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
