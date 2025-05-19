using Tutor.Models;

namespace Tutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var employees = context.Employees.ToList();

                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.Id}-{employee.Name}-{employee.Age}");
                }
            }
        }
    }
}
