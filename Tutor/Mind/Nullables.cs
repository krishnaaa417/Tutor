using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Mind
{
    internal class Nullables
    {
        static void Main(string[] args)
        {
           Student s = new Student();

            if (s.FirstName == null)
            {
                Console.WriteLine("Firstname is null");
            }
           if (s.Age.HasValue)
            {
                Console.WriteLine("age is null");
            }
           // Console.WriteLine(s.FirstName);
        }


    }

    public class Student
    {
        //public Student()
        //{
        //    FirstName = "Nallapothula";
        //    LastName = "Venkata krishna";
        //}
        public string FirstName {  get; set; }
        public string LastName { get; set; }

        public int? Age { get; set; }
    }
}
