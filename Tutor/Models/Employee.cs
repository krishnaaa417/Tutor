using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age {  get; set; }

        //Foreign key
        public int ManagerId { get; set; }


        public Manager Manager { get; set; }
    }
}
