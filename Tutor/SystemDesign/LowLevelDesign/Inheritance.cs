using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SystemDesign.LowLevelDesign
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
           PW1100G p = new PW1100G();
            p.EngineValue = 1;
            p.EngineValue = 2;
            p.EngineNumber = 123;
            p.display();
            PW1500G p2 = new PW1500G();
            p2.EventId = "123423";
            p2.show();
        }

        public class PW1100G
        {
            public int EngineNumber;
            public double EngineValue;
            public void display()
            {
                Console.WriteLine("EngineNumber.."+EngineNumber);
                Console.WriteLine("EngineValue.."+EngineValue);
            }
        }

        public class PW1500G : PW1100G 
        {
            public string EventId;

            public void show()
            {
                Console.WriteLine("EventId.."+EventId);
            }
        }
    }
}
