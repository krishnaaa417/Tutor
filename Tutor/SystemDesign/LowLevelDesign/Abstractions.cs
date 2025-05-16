using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.SystemDesign.LowLevelDesign
{
    internal class Abstractions
    {
        static void Main(string[] args)
        {
           Animal anime = new Dog();
            anime.Sleep();
            anime.Eat();
           
            Dog d = new Dog();
            d.Sound();
        }
    }

    public class Dog : Animal
    {
        public void Sound()
        {
            Console.WriteLine("Sound..");
        }
        public override void Sleep()
        {
            Console.WriteLine("Sleeping..");
        }
    }

    public abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating.. Food");
        }
        public abstract void Sleep();
    }
}
