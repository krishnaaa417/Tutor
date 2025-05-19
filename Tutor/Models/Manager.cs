using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Models
{
    internal class Manager
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Navigation property
        //One manager can have many employees
        public ICollection<Employee> Employees { get; set; }
    }
}
