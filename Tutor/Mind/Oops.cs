using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Mind
{
    internal class Oops
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog("Chintuu");
            animal.Display();
            animal.MakeSound();
        }
    }

    public abstract class Animal
    {
        public string Name;

        public Animal(string name)
        {
            this.Name = name;
        }

        // concrete method has implementation
        public void Display()
        {
            Console.WriteLine("Animal.."+Name);
        }
        // Abstract Method :no implementation ,must be overridden
        public abstract void MakeSound();

    }

    public class Dog : Animal
    {
        public Dog(string name) :base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine("Dog says BOW..BOW");
        }
    }
}
