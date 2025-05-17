using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SystemDesign.LowLevelDesign
{
    public class Sumoo 
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Audi();
            vehicle.StartEngine();
            vehicle.StopEngine();
        }
    }

    public class Audi : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Audi Engine Starts..");
        }

        public void StopEngine()
        {
            Console.WriteLine("Audii Engine Stopss");
        }
    }
}
