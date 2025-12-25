using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.DataTypes
{
    internal class Logical
    {
        static void Main(string[] args)
        {
            string mother = "Lakshmii";
            string father = "Gopal";

            if(mother == "Lakshmii" && father == "Gopal")
            {
                Console.WriteLine("Family");
            }
            else
            {
                Console.WriteLine("Check-Once..");
            }
        }
    }
}
